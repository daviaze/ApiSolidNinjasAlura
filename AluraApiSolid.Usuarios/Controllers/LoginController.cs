using AluraApiSolid.Usuarios.Requests;
using AluraApiSolid.Usuarios.Services.Interfaces;
using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraApiSolid.Usuarios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        public IActionResult Login(LoginRequest loginrequest)
        {
            Result result = _loginService.Login(loginrequest);
            if (result.IsSuccess) return Ok(result.Successes[0]);
            return Unauthorized(result.Errors);

        }
    }
}
