using AutoMapper;
using Models;

namespace Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Dictionary<string, string>, Message>()
                 .ConvertUsing<DictionaryToMessageConverter>(); ;
        }
    }
}
