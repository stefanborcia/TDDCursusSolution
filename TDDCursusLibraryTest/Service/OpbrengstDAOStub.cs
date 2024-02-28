using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDCursusLibrary.Service;

namespace TDDCursusLibraryTest.Service
{
    public class OpbrengstDAOStub : IOpbrengstDAO
    {
        public decimal TotaleOpbrengst()
        {
            //throw new NotImplementedException();
            return 250m;
        }
    }
}
