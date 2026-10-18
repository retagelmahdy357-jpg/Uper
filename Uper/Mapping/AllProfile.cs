using System.Runtime.InteropServices;
using AutoMapper;
using Uper.Controllers;
using Uper.DTO;
using Uper.Model;

namespace Uper.Mapping
{
    public class AllProfile:Profile
    {
        public AllProfile()
        {
            CreateMap<User,UserCreateDto>().ReverseMap();
          // .ForMember(dest => dest.f,
          //opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));
//CreateMap<User,UserCreateDto>().ForMember(des=>des.FullName,x=>x.MapFrom(y=> $"{y.FirstName} {x.}"))
            CreateMap<User,UserReadDto>().ReverseMap();
            CreateMap<AppUser,RigesterDTO>().ReverseMap();
            CreateMap<Vehicle,VehcileDto>().ReverseMap();
            CreateMap<Ride,RideDto>().ReverseMap();
            CreateMap<Payment,PaymentDTO>().ReverseMap();

        }
    }
}
