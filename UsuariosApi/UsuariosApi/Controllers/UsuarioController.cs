using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UsuariosApi.Data.Dtos.Usuario;
using UsuariosApi.Models;
using UsuariosApi.Services;

namespace UsuariosApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
    private UsuarioService _cadastroService;

    public UsuarioController(UsuarioService cadastroService)
    {
        _cadastroService = cadastroService;
    }

    [HttpPost("cadastro")]
    public async Task<IActionResult> CadastraUsuario(CreateUsariosDto dto)
    {
        await _cadastroService.Cadastro(dto);
        return Ok("Usuário cadastrado!");
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginUsuarioDto dto)
    {
        var token = await _cadastroService.Login(dto);
        return Ok(token);
    }
}
