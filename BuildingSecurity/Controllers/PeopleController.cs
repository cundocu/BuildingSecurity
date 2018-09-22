using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuildingSecurity.BLL;
using Microsoft.AspNetCore.Mvc;

namespace BuildingSecurity.Controllers
{
    public class PeopleController : Controller
    {
        IPeopleRepository repository;

        public PeopleController( IPeopleRepository repo)
        {
            this.repository = repo;
        }

        public ViewResult Index(string searchString)
        {
            //var movies = from m in _context.Movie
            //             select m;

            //if (!String.IsNullOrEmpty(searchString))
            //{
            //    movies = movies.Where(s => s.Title.Contains(searchString));
            //}

            return View( repository.People);
        }

        public ViewResult List() => View(repository.People);

        public string ImportResidents (string s) => s = "Sorbeto";
    }
}