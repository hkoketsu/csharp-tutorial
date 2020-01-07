using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using razer_pages_movie.Models;

namespace razer_pages_movie.Data
{
    public class RazerPagesMovieContext : DbContext
    {
        public RazerPagesMovieContext (DbContextOptions<RazerPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<razer_pages_movie.Models.Movie> Movie { get; set; }
    }
}
