using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using TDDCursusLibrary.Service;

namespace TDDCursusLibraryTest.Service
{
    [TestClass]
    public class WinstServiceTest
    {
        private Mock<IKostDAO> mockKostDAO;
        private Mock<IOpbrengstDAO> mockOpbrengstDAO;
        private IKostDAO kostDAO;
        private IOpbrengstDAO opbrengstDAO;
        private WinstService winstService;

        [TestInitialize]
        public void Initialize()
        {
            mockKostDAO = new Mock<IKostDAO>();
            mockOpbrengstDAO = new Mock<IOpbrengstDAO>();
            kostDAO = mockKostDAO.Object;
            opbrengstDAO = mockOpbrengstDAO.Object;
            winstService = new WinstService(opbrengstDAO, kostDAO);

            mockKostDAO.Setup(eenKostDAO => eenKostDAO.TotaleKost()).Returns(200m);
            mockOpbrengstDAO.Setup(eenOpbrengstDAO => eenOpbrengstDAO.TotaleOpbrengst()).Returns(250m);
        }

        [TestMethod]
        public void Winst_Bereken_GeeftCorrecteWaarde()
        {
            Assert.AreEqual(50m, winstService.Winst);
            mockKostDAO.Verify(eenKostDAO => eenKostDAO.TotaleKost());
            mockOpbrengstDAO.Verify(eenOpbrengstDAO => eenOpbrengstDAO.TotaleOpbrengst());
        }
    }
}
