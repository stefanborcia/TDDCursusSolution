using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDCursusLibrary.Land;

namespace TDDCursusLibraryTest.Land
{
    public class LandDAOStub : ILandDAO
    {
        public TDDCursusLibrary.Land.Land Read(string landcode)
        {
            return new TDDCursusLibrary.Land.Land { LandCode = landcode, Oppervlakte = 5 };
        }
        public int OppervlakteAlleLanden() => 20;
    }
}
