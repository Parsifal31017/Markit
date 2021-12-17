using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Markit.Models;

namespace Markit.Data
{
    public class MarkitContext : DbContext
    {
        public MarkitContext (DbContextOptions<MarkitContext> options)
            : base(options)
        {
        }

        public DbSet<Markit.Models.Markit> Markit { get; set; }
    }
}
