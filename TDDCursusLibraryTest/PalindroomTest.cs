using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class PalindroomTest
    {
        [TestMethod]
        public void LepelIsEenPalindroom()
        {
            Assert.IsTrue(new Palindroom("lepel").IsPalindroom());
        }
        [TestMethod]
        public void VorkIsGeenPalindroom()
        {
            Assert.IsFalse(new Palindroom("vork").IsPalindroom());
        }
        [TestMethod]
        public void EenLegeStringIsEenPalindroom()
        {
            Assert.IsTrue(new Palindroom(string.Empty).IsPalindroom());
        }
    }
}
