using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingSecurity.Models
{
    public class Person
    {
        [Key]
        public Guid     PersonID   { get; set; } 
        public string   FirstName  { get; set; }
        public string   MiddleName { get; set; }
        public string   LastName   { get; set; }
    }
}
