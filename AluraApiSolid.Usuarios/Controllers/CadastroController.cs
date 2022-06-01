using AluraApiSolid.Usuarios.Dtos;
using AluraApiSolid.Usuarios.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraApiSolid.Usuarios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CadastroController : ControllerBase
    {
        ICadastroService _cadastroService;

        public CadastroController(ICadastroService cadastroService)
        {
            _cadastroService = cadastroService;
        }

        [HttpPost]
        public IActionResult Cadastra(UsuarioDTO usuarioDTO)
        {
            bool result = _cadastroService.CadastraUsuario(usuarioDTO);
            if (result) return Ok();
            return BadRequest("Falha ao realizar o cadastro");
        }
    }
}
