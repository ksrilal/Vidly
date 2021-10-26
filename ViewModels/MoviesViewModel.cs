using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MoviesViewModel
    {
        public List<Movie> Movies { get; set; }

        public MoviesViewModel() {
            Movies = new List<Movie>
            {
                new Movie {Id=1, Name="Harry Potter"},
                new Movie {Id=2, Name="Lord of the Rings"},
                new Movie {Id=3, Name="Star Wars"},
                new Movie {Id=4, Name="Dune"}
            };
        }
    }
}