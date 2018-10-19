using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        MovieModel movieModel = new MovieModel();

        // GET: Movies
        [Route("movies")]
        public ActionResult List()
        {
            return View(movieModel);
        }

        [Route("movies/details/{id:int}")]
        public ActionResult Details(int id)
        {
            return View(movieModel.GetMovieById(id));
        }
    }
}