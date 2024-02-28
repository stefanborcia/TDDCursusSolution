using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class RechthoekTest
    {
        [TestMethod]
        public void Oppervlakte_Rechthoek_5op3_Is15()
        {
            Assert.IsTrue(new Rechthoek(5,3).Oppervlakte().Equals(15));
        }
        [TestMethod]
        public void Omtrek_Rechthoek_5op3_Is16()
        {
            Assert.IsTrue(new Rechthoek(5,3).Omtrek().Equals(16));
        }
    }
}
