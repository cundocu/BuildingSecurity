using BuildingSecurity.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingSecurity.Models
{
    public class FakePeopleRepository : IPeopleRepository
    {
        public IEnumerable<Person> People => new List<Person>  {
                                                 new Person {  PersonID = Guid.NewGuid() ,   FirstName="aa" , MiddleName = "bbb" , LastName = "bbb"},
                                                 new Person {  PersonID = Guid.NewGuid() ,   FirstName="dsd" , MiddleName = "bbb" , LastName = "bbb"},
                                                 new Person {  PersonID = Guid.NewGuid() ,   FirstName="dd" , MiddleName = "bbb" , LastName = "bbb"},
                                                 new Person {  PersonID = Guid.NewGuid() ,   FirstName="dd" , MiddleName = "bbb" , LastName = "bbb"},
                                                 new Person {  PersonID = Guid.NewGuid() ,   FirstName="dd" , MiddleName = "bbb" , LastName = "bbb"},
                                                 new Person {  PersonID = Guid.NewGuid() ,   FirstName="dd" , MiddleName = "bbb" , LastName = "bbb"},
                                                 new Person {  PersonID = Guid.NewGuid() ,   FirstName="d" , MiddleName = "bbb" , LastName = "bbb"},
                                                 new Person {  PersonID = Guid.NewGuid() ,   FirstName="dd" , MiddleName = "bbb" , LastName = "bbb"},
                                                 new Person {  PersonID = Guid.NewGuid() ,   FirstName="dd" , MiddleName = "bbb" , LastName = "bbb"},
                                                 new Person {  PersonID = Guid.NewGuid() ,   FirstName="dd" , MiddleName = "bbb" , LastName = "bbb"},
                                                 new Person {  PersonID = Guid.NewGuid() ,   FirstName="dd" , MiddleName = "bbb" , LastName = "bbb"},
                                                 new Person {  PersonID = Guid.NewGuid() ,   FirstName="dd" , MiddleName = "bbb" , LastName = "bbb"}
                                               };
     }
}
