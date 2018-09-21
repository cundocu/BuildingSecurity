using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingSecurity.Models
{
    public class Building
    {
        [Key]
        public int    BuildingID   { get; set; }
        public  string DisplayName  { get; set; }
    }
}
