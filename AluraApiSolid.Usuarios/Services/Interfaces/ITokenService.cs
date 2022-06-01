using AluraApiSolid.Usuarios.Utils;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraApiSolid.Usuarios.Services.Interfaces
{
    public interface ITokenService
    {
        public Token CreateToken(IdentityUser<int> usuario, string role);

    }
}
