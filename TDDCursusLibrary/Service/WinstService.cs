using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary.Service
{
    public class WinstService
    {
        private readonly IOpbrengstDAO opbrengstDAO;
        private readonly IKostDAO kostDAO;
        public decimal Winst => opbrengstDAO.TotaleOpbrengst() - kostDAO.TotaleKost();

        public WinstService(IOpbrengstDAO opbrengstDAO, IKostDAO kostDAO)
        {
            this.opbrengstDAO = opbrengstDAO;
            this.kostDAO = kostDAO;
        }

    }
}
