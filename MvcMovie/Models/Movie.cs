using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price {  get; set; }
        // public int Ratings { get; set; }


    }

    public class MovieDBContext : DbContext  // class represents the EF movie db context, which handles fetching, storing, and updating Movie class instances in a db. 
    {
        public DbSet<Movie> Movies { get; set; }
    }
}