using Microsoft.AspNetCore.Mvc;
using Services.Messages;
using System.Text;

namespace SwiftMessagesProcessor.Web.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SwiftMessagesController : ControllerBase
    {
        private readonly IMessagesService messagesService;
        private readonly ILogger<SwiftMessagesController> logger;
        public SwiftMessagesController(IMessagesService msssagesService, ILogger<SwiftMessagesController> logger)
        {
            this.logger = logger;
            this.messagesService = msssagesService;
        }

        [HttpPost]
        public async Task<IActionResult> GetMessageFile(IFormFile file)
        {
            this.logger.LogInformation("Begin upload of a file.");
            var message = await GetFileTextContentAsync(file);

            var mess = await messagesService.SaveMessageAsync(message);
            Console.WriteLine(message);
            return Ok(mess);
        }

        private async Task<string> GetFileTextContentAsync(IFormFile file)
        {
            using var memoryStream = file.OpenReadStream();

            using var memoryStreamReader = new StreamReader(memoryStream);
            var strBuilder = new StringBuilder();

            while (!memoryStreamReader.EndOfStream)
            {
                var line = await memoryStreamReader.ReadLineAsync();
                this.logger.LogInformation("Line: {@line} has been read", line);
                strBuilder.AppendLine(line);

            }

            return strBuilder.ToString();
        }
    }
}
