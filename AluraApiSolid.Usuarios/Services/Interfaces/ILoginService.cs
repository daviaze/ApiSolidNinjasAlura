using AluraApiSolid.Usuarios.Requests;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraApiSolid.Usuarios.Services.Interfaces
{
    public interface ILoginService
    {
        Result Login(LoginRequest loginRequest);
    }
}
