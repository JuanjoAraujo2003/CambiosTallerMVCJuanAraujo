using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CambiosTallerMVCJuanAraujo.Models;

namespace CambiosTallerMVCJuanAraujo.Data
{
    public class CambiosTallerMVCJuanAraujoContext : DbContext
    {
        public CambiosTallerMVCJuanAraujoContext (DbContextOptions<CambiosTallerMVCJuanAraujoContext> options)
            : base(options)
        {
        }

        public DbSet<CambiosTallerMVCJuanAraujo.Models.Burger> Burger { get; set; } = default!;
    }
}
