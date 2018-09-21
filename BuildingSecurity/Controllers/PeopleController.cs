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



        public ViewResult List() => View(repository.People);

        public string ImportResidents (string s) => s = "Sorbeto";
    }
}