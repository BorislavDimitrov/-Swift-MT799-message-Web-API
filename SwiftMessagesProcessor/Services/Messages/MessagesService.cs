using AutoMapper;
using Common;
using Data;
using Microsoft.Extensions.Logging;
using Models;
using System.Text.RegularExpressions;

namespace Services.Messages
{
    public class MessagesService : IMessagesService
    {
        private readonly ApplicationDbContext dbContext;
        private readonly ILogger logger;
        private readonly IMapper mapper;

        public MessagesService(ApplicationDbContext dbContext, ILogger<MessagesService> logger, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.logger = logger;
            this.mapper = mapper;
        }

        public async Task<Message> SaveMessageAsync(string MTmessage)
        {
            var bankIdentifier = ObtainFirstAndSecondSectionsTags(MTmessage, TagsAndSectionsConstants.Section1Tag);
            var typeAndReference = ObtainFirstAndSecondSectionsTags(MTmessage, TagsAndSectionsConstants.Section2Tag);
            var MAC = ObtainFifthSectionsTags(MTmessage, TagsAndSectionsConstants.MACTag);
            var CHK = ObtainFifthSectionsTags(MTmessage, TagsAndSectionsConstants.CHKTag);

            var tags = ObtainFourthSectionTags(MTmessage);
            var newMessage = mapper.Map<Message>(tags);

            newMessage.BankIdentifier = bankIdentifier;
            newMessage.TypeAndReference = typeAndReference;
            newMessage.MAC = MAC;
            newMessage.CHK = CHK;

            await dbContext.Messages.AddAsync(newMessage);
            await dbContext.SaveChangesAsync();

            return newMessage;

        }

        private string ObtainFirstAndSecondSectionsTags(string message, string sectionTag)
        {
            var section = ObtainFirstAndSecondSections(message, sectionTag);
            this.logger.LogInformation(section);
            var result = section.TrimStart('{').TrimEnd('}').Replace(sectionTag, "");
            return result;
        }

        private string ObtainFirstAndSecondSections(string message, string sectionTag)
        {

            var sectionTemplate = TagsAndSectionsConstants.GetCodeTemplate(sectionTag);
            var regex = new Regex(sectionTemplate);
            var match = regex.Match(message);

            if (!match.Success)
            {
                this.logger.LogInformation($"Obtaining of section {sectionTag} failed.");
            }

            return match.Value;
        }

        public Dictionary<string, string> ObtainFourthSectionTags(string message)
        {
            var section = ObtainFourthSection(message);
            section = section.TrimStart();

            var tagCodes = new Dictionary<string, string>(TagsAndSectionsConstants.TagCodes);

            foreach (var match in Regex.Matches(section, ":\\d+:").Cast<Match>())
            {
                var someNumber = match.Value;
                var startIndex = match.Index;
                var endIndex = (match.NextMatch().Success) ? match.NextMatch().Index : section.Length;
                var content = section[startIndex..endIndex].Trim();

                if (tagCodes.Keys.Select(x => x.Contains(someNumber)).Any())
                {
                    var key = tagCodes.Keys.FirstOrDefault(x => x.Contains(someNumber.Trim(':')));
                    tagCodes[key] = content.Replace(someNumber, "");
                }

                logger.LogInformation($"Pattern: {someNumber}, Content: {content}");
            }

            return tagCodes;
        }

        private string ObtainFourthSection(string message)
        {
            var sectionTemplate = TagsAndSectionsConstants.GetSection4Template;
            var regex = new Regex(sectionTemplate);
            var match = regex.Match(message);

            if (!match.Success)
            {
                this.logger.LogInformation($"Obtaining of section 4 failed.");
            }

            return match.Value;
        }

        private string ObtainFifthSectionsTags(string message, string sectionTag)
        {
            var section = ObtainFifthSection(message, sectionTag);
            this.logger.LogInformation(section);
            var result = section.TrimStart('{').TrimEnd('}').Replace(sectionTag, "");
            return result;
        }

        private string ObtainFifthSection(string message, string sectionTag)
        {

            var sectionTemplate = TagsAndSectionsConstants.GetCodeTemplate(sectionTag);
            var regex = new Regex(sectionTemplate);
            var match = regex.Match(message);

            if (!match.Success)
            {
                this.logger.LogInformation($"Obtaining of section {sectionTag} failed.");
            }

            return match.Value;
        }

    }
}
