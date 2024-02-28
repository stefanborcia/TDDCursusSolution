using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class Rechthoek
    { 
        public int Breedte { get; set; }
        public int Lengte { get; set; }

        public Rechthoek(int breedte, int lengte)
        {
            Breedte = breedte;
            Lengte = lengte;
        }

        public int Omtrek()
        {
            return 2 * (Breedte+Lengte);
        }
        public int Oppervlakte()
        {
            return Breedte * Lengte;
        }
    }
}
