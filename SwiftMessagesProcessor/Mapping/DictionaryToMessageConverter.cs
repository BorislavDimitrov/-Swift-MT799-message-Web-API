using AutoMapper;
using Models;

namespace Mapping
{
    public class DictionaryToMessageConverter : ITypeConverter<Dictionary<string, string>, Message>
    {
        public Message Convert(Dictionary<string, string> source, Message? destination, ResolutionContext context)
        {
            destination ??= new Message();

            foreach (var property in destination.GetType().GetProperties())
            {
                var key = source.Keys.FirstOrDefault(x => property.Name.Contains(x));

                if (!string.IsNullOrEmpty(key))
                {
                    var value = source[key];
                    property.SetValue(destination, value);
                }

            }

            return destination;
        }
    }
}
