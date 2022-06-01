using AluraApiSolid.Usuarios.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraApiSolid.Usuarios.Services
{
    public interface ICadastroService
    {
        bool CadastraUsuario(UsuarioDTO usuarioDTO);
    }
}
