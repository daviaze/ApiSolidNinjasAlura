using AluraApiSolid.Usuarios.Dtos;
using AluraApiSolid.Usuarios.Models;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraApiSolid.Usuarios.Services
{
    public class CadastroService : ICadastroService
    {
        IMapper _mapper;
        private UserManager<IdentityUser<int>> _userManager;
        private RoleManager<IdentityRole<int>> _roleManager;

        public CadastroService(IMapper mapper, UserManager<IdentityUser<int>> userManager, RoleManager<IdentityRole<int>> roleManager)
        {
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public bool CadastraUsuario(UsuarioDTO usuarioDTO)
        {
            Usuario usuario = _mapper.Map<Usuario>(usuarioDTO);
            IdentityUser<int> usuarioIdentity = _mapper.Map<IdentityUser<int>>(usuario);
            Task<IdentityResult> resultado = _userManager.CreateAsync(usuarioIdentity, usuarioDTO.Password);
            if (resultado.Result.Succeeded)
            {
                var result = _userManager.AddToRoleAsync(usuarioIdentity, "normal").Result;

                return true;
            }
            return false;
        }
    }
}
