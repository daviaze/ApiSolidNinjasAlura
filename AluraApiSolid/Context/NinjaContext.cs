using AluraApiSolid.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraApiSolid.Context
{
    public class NinjaContext :DbContext
    {
        public NinjaContext(DbContextOptions<NinjaContext> options) : base(options)
        {

        }

        public DbSet<Ninja> Ninjas { get; set; }
        public DbSet<Vila> Vilas { get; set; }

    }
}
