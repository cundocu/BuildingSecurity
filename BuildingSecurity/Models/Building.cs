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
        public ICollection<HomeUnit> homeUnits { get; set; }
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