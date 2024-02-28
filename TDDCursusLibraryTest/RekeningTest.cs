using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class RekeningTest
    {
        private Rekening rekening;
        [TestInitialize]
        public void Initialize()
        {
            rekening = new Rekening();
        }
        [TestMethod,ExpectedException(typeof(ArgumentException))]
        public void HetBedragVanEenStortingMagNietNulZijn()
        {
            rekening.Storten(decimal.Zero);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void HetBedragVanEenStortingMagNietNegatiefZijn()
        {
            rekening.Storten(-1m);
        }
        [TestMethod]
        public void HetSaldoVanEenNieuweRekeningIsNul()
        {
            Assert.AreEqual(decimal.Zero, rekening.Saldo);
        }
        [TestMethod]
        public void HetSaldoNaEenEersteStortingIsHetBedragVanDieStorting()
        {
            var bedrag = 2.5m;
            rekening.Storten(bedrag);
            Assert.AreEqual(bedrag, rekening.Saldo);
        }
        [TestMethod]
        public void HetSaldoNaTweeStortingenIsDeSomVanDeBedragenVanDieStortingen()
        {
            rekening.Storten(2.5m);
            rekening.Storten(1.2m);
            Assert.AreEqual(3.7m, rekening.Saldo);
        }
    }
}
