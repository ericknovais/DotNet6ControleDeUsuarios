using UsuariosApi.Data.Dtos.Usuario;
using UsuariosApi.Models;

namespace UsuariosApi.Profile;

public class UsuarioProfile : AutoMapper.Profile
{
    public UsuarioProfile()
    {
        CreateMap<CreateUsariosDto, Usuario>();
    }
}
