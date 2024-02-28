using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using TDDCursusLibrary.Land;

namespace TDDCursusLibraryTest.Land
{
    [TestClass]
    public class LandServiceTest
    {
        private ILandDAO landDAO;
        private LandService landService;
        private Mock<ILandDAO> mockFactory;

        [TestInitialize]
        public void Initialize()
        {
            mockFactory = new Mock<ILandDAO>();

            mockFactory.Setup(eenLandDAO => eenLandDAO.OppervlakteAlleLanden()).Returns(20);
            mockFactory.Setup(eenLandDAO => eenLandDAO.Read("B")).Returns(new TDDCursusLibrary.Land.Land { LandCode = "B", Oppervlakte = 5 });

            mockFactory.Setup(eenLandDAO => eenLandDAO.Read("NL")).Returns(new TDDCursusLibrary.Land.Land { LandCode = "NL", Oppervlakte = 6 });
            mockFactory.Setup(eenLandDAO => eenLandDAO.Read(string.Empty)).Throws(new ArgumentException());

            landDAO = mockFactory.Object;
            landService = new LandService(landDAO);
        }

        [TestMethod]
        public void FindVerhoudingOppervlakteLandTovOppervlakteAlleLanden()
        {
            Assert.AreEqual(0.25m, landService.VerhoudingOppervlakteLandTovOppervlakteAlleLanden("B"));

            mockFactory.Verify(eenLandDAO => eenLandDAO.OppervlakteAlleLanden());
            mockFactory.Verify(eenLandDAO => eenLandDAO.Read("B"));
        }
    }
}
