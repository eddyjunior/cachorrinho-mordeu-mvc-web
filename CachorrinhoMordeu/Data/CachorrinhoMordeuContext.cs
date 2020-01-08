using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CachorrinhoMordeu.Models
{
    public class CachorrinhoMordeuContext : DbContext
    {
        public CachorrinhoMordeuContext (DbContextOptions<CachorrinhoMordeuContext> options)
            : base(options)
        {
        }

        public DbSet<CachorrinhoMordeu.Models.Department> Department { get; set; }
    }
}
