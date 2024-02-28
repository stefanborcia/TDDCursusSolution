using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class RekeningnummerTest
    {
        [TestMethod]
        public void NummerMet16TekensMetCorrecteControleIsOK()
        {
            // dit nummer mag geen exception veroorzaken
            new Rekeningnummer("BE72091012240116");
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NummerMet15TekensIsVerkeerd()
        {
            new Rekeningnummer("BE7209101224011");
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NummerMet17CijfersIsVerkeerd()
        {
            new Rekeningnummer("BE720910122401160");
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NietBelgischNummerIsNietOK()
        {
            new Rekeningnummer("NL72091012240116");
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NummerMetOngeldigeTekensIsNietOK()
        {
            new Rekeningnummer("BEX209101224011Y");
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NummerMetTeKleinControlegetalIsNietOK()
        {
            new Rekeningnummer("BE01091012240116");
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NummerMetTeGrootControlegetalIsNietOK()
        {
            new Rekeningnummer("BE99091012240116");
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NummerMet16TekensMetVerkeerdeControleIsVerkeerd()
        {
            new Rekeningnummer("BE72091012240115");
        }
        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void NullNummerIsNietOK()
        {
            new Rekeningnummer(null);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void LegeStringNummerIsNietOK()
        {
            new Rekeningnummer(string.Empty);
        }
        [TestMethod]
        public void ToStringMoetHetNummerTeruggeven()
        {
            var nummer = "BE72091012240116";
            var rekeningnummer = new Rekeningnummer(nummer);
            Assert.AreEqual(nummer, rekeningnummer.ToString());
        }
    }
}
