using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/MovieList
        public ActionResult MovieList()
        {
            var moviesViewModel = new MoviesViewModel();
            return View(moviesViewModel);
        }
        public ActionResult Movie(int id)
        {
            var moviesViewModel = new MoviesViewModel();
            var movie = moviesViewModel.Movies.Single(m => m.Id.Equals(id));
            return View(movie);
        }
    }
}