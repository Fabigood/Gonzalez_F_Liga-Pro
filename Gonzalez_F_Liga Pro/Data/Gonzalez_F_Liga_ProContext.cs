using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gonzalez_F_Liga_Pro.Models;

namespace Gonzalez_F_Liga_Pro.Data
{
    public class Gonzalez_F_Liga_ProContext : DbContext
    {
        public Gonzalez_F_Liga_ProContext (DbContextOptions<Gonzalez_F_Liga_ProContext> options)
            : base(options)
        {
        }

        public DbSet<Gonzalez_F_Liga_Pro.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<Gonzalez_F_Liga_Pro.Models.Jugador> Jugador { get; set; } = default!;
    }
}
