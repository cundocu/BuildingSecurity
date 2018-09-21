using BuildingSecurity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingSecurity.BLL
{
    public interface IPeopleRepository
    {
        IEnumerable<Person>  People { get; }
    }
}
