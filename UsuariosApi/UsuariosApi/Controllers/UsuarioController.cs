using Microsoft.AspNetCore.Mvc;
using UsuariosApi.Data.Dtos.Usuario;

namespace UsuariosApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
    [HttpPost]
    public IActionResult CadastraUsuario(CreateUsariosDto dto)
    {
        throw new NotImplementedException();
    }
}
