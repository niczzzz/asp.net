using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _03_Movies.Models;

namespace _03_Movies.Data
{
    public class _03_MoviesContext : DbContext
    {
        public _03_MoviesContext (DbContextOptions<_03_MoviesContext> options)
            : base(options)
        {
        }

        public DbSet<_03_Movies.Models.Movie> Movie { get; set; } = default!;
    }
}
