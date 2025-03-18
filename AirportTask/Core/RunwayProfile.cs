using AirportTask.Model;
using AutoMapper;

namespace AirportTask.Core
{
    public class RunwayProfile:Profile
    {
        public RunwayProfile()
        {
            CreateMap<Runway22, Runway19>()
                .ForMember(dest => dest.ThresholdCrossingHeight, opt =>
                    opt.MapFrom(src => src.ThresholdCrossingHeight.TrimStart('0').Substring(0, 2)));
        }
    }
}
