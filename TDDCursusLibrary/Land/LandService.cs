﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary.Land
{
    public class LandService
    {
        private readonly ILandDAO landDAO;
        public LandService(ILandDAO landDAO)
        {
            this.landDAO = landDAO;
        }
        public decimal VerhoudingOppervlakteLandTovOppervlakteAlleLanden(string landcode)
        {
            var land = landDAO.Read(landcode);
            var oppervlakteAlleLanden = landDAO.OppervlakteAlleLanden();
            return (decimal)land.Oppervlakte / oppervlakteAlleLanden;
        }
    }
}
