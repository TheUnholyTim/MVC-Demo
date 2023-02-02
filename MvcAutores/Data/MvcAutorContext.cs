using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcAutores.Models;

namespace MvcAutores.Data
{
    public class MvcAutorContext : DbContext
    {
        public MvcAutorContext (DbContextOptions<MvcAutorContext> options)
            : base(options)
        {
        }

        public DbSet<MvcAutores.Models.Autor> Autor { get; set; } = default!;
    }
}
