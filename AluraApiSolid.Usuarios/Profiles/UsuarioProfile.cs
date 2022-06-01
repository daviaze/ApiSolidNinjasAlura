using AluraApiSolid.Usuarios.Dtos;
using AluraApiSolid.Usuarios.Models;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraApiSolid.Usuarios.Profiles
{
    public class UsuarioProfile
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<UsuarioDTO, Usuario>();
                config.CreateMap<Usuario, IdentityUser<int>>();

            });
            return mappingConfig;
        }
    }
}
