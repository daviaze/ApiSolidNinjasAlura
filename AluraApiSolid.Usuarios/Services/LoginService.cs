using AluraApiSolid.Usuarios.Requests;
using AluraApiSolid.Usuarios.Utils;
using FluentResults;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraApiSolid.Usuarios.Services.Interfaces
{
    public class LoginService : ILoginService
    {
        private SignInManager<IdentityUser<int>> _userManager;
        private ITokenService _tokenService;
        public LoginService(SignInManager<IdentityUser<int>> userManager, ITokenService tokenService)
        {
            _userManager = userManager;
            _tokenService = tokenService;
        }
        public Result Login(LoginRequest loginRequest)
        {
            var resultado = _userManager.PasswordSignInAsync(loginRequest.Username, loginRequest.Password, false, false);
            if (resultado.Result.Succeeded)
            {
                var identityUser = _userManager.UserManager.Users.FirstOrDefault(u => u.NormalizedUserName == loginRequest.Username.ToUpper());

                Token token = _tokenService.CreateToken(identityUser, _userManager.UserManager.GetRolesAsync(identityUser).Result.FirstOrDefault());
                return Result.Ok().WithSuccess(token.Value);
            }
            return Result.Fail("O Login Falhou");
        }
    }
}
