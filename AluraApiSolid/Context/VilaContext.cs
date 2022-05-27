using AluraApiSolid.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraApiSolid.Context
{
    public class VilaContext : DbContext
    {
        public VilaContext(DbContextOptions<VilaContext> options) : base(options)
        {

        }

        public DbSet<Vila> Vilas { get; set; }
    }
}
