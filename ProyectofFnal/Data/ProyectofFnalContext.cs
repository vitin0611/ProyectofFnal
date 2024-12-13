using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorWebAppMovies.Models;

namespace ProyectofFnal.Data
{
    public class ProyectofFnalContext : DbContext
    {
        public ProyectofFnalContext (DbContextOptions<ProyectofFnalContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorWebAppMovies.Models.Movie> Movie { get; set; } = default!;
    }
}
