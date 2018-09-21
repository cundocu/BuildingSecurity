using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuildingSecurity.BLL;
using Microsoft.AspNetCore.Mvc;

namespace BuildingSecurity.Controllers
{
    public class DutyController : Controller
    {

        IPeopleRepository repository;
        public DutyController( IPeopleRepository repo)
        {
           this.repository = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ViewResult SearchResidents () => View(new {peoplelist =   repository.People , buildinglist = new List<string> { "101","102","103"} }  );
    }
}
