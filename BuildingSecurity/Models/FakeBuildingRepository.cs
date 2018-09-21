using BuildingSecurity.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingSecurity.Models
{
    public class FakeBuildingRepository : IBuildingRepository
    {
        public IEnumerable<Building> Building => new List<Building> {     new Building { BuildingID = 101 ,  DisplayName = "101" },
                                                                          new Building { BuildingID = 102 ,  DisplayName = "102" },
                                                                          new Building { BuildingID = 103 ,  DisplayName = "103" }
                                                                     };
    }

}
