using AutoMapper;
using TheCodeCamp.Models;

namespace TheCodeCamp.Data
{
    public class TalkMappingProfile : Profile
    {
        public TalkMappingProfile()
        {
            CreateMap<Talk, TalkModel>();
        }
    }
}
