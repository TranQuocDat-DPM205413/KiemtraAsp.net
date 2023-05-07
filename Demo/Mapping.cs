using AutoMapper;
using Demo.Models;
using Infrastructure.Entities;
using Infrastructure.Entitites;

namespace Demo
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<User, UserViewModel>();
            CreateMap<UserViewModel, User>();

            CreateMap<SinhVien, SinhVienViewModel>();
            CreateMap<SinhVienViewModel, SinhVien>();
        }
    }
}
