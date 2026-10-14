using System.Runtime.InteropServices;
using AutoMapper;
using Uper.Controllers;
using Uper.DTO;

namespace Uper.Mapping
{
    public class AllProfile:Profile
    {
        public AllProfile()
        {
             CreateMap<UserController,UserCreateDto>().ReverseMap();
            CreateMap<UserController,UserReadDto>().ReverseMap();
        }
    }
}
