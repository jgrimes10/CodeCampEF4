using AutoMapper;
using TheCodeCamp.Models;

namespace TheCodeCamp.Data
{
    public class SpeakerMappingProfile : Profile
    {
        public SpeakerMappingProfile()
        {
            CreateMap<Speaker, SpeakerModel>();
        }
    }
}
