using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDCursusLibrary.Service;

namespace TDDCursusLibraryTest.Service
{
    public class KostDAOStub : IKostDAO
    {
        public decimal TotaleKost()
        {
            //throw new NotImplementedException();
            return 200m;
        }
    }
}
