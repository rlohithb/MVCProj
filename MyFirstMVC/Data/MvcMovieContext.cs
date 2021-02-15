using System;
using Microsoft.EntityFrameworkCore;
using MyFirstMVC.Models;

namespace MyFirstMVC.Data
{
    public class MvcMovieContext: DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            :base(options)
        {             
        }
        public DbSet<Movie> Movie { get; set; }
    }
}
