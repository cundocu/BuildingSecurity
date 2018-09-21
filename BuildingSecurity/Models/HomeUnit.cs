using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingSecurity.Models
{
    public class HomeUnit
    {
        [Key]
        public int HomeNumber;
        public int BuildingID { get; set; }

        [ForeignKey("BuildingRefId")]
        public Building  Building  { get; set; }
    }
}


//public class Student
//{
//    public int StudentID { get; set; }
//    public string StudentName { get; set; }

//    public int StandardRefId { get; set; }

//    [ForeignKey("StandardRefId")]
//    public Standard Standard { get; set; }
//}

//public class Standard
//{
//    public int StandardId { get; set; }
//    public string StandardName { get; set; }

//    public ICollection<Student> Students { get; set; }
//}