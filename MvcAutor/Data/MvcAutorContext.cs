using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcAutor.Models;

namespace MvcAutor.Data
{
    public class MvcAutorContext : DbContext
    {
        public MvcAutorContext (DbContextOptions<MvcAutorContext> options)
            : base(options)
        {
        }

        public DbSet<MvcAutor.Models.Autor> Autor { get; set; } = default!;
    }
}
