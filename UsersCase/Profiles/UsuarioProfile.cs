using AutoMapper;
using UsersCase.Data.Dtos;
using UsersCase.Models;

namespace UsersCase.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDto, Usuario>();
        }
    }
}
