using System;
using Kaczorek.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kaczorek.BLTest
{
    [TestClass]
    public class ZmowienieRepositoryTest
    {
        [TestMethod]
        public void PobierzZamowienieTest()
        {
            //Arrange
            var zamowienieRepository = new ZamowienieRepository();
            var oczekiwane = new Zamowienie(10)
            {

                DataZamowienia = new DateTimeOffset(2018, 4, 20, 11, 00, 00, new TimeSpan(7, 0, 0))
            };
            
            //Act
            var aktualne = zamowienieRepository.Pobierz(10);
            //Assert
            Assert.AreEqual(oczekiwane.ZamowienieId, aktualne.ZamowienieId);
            Assert.AreEqual(oczekiwane.DataZamowienia, aktualne.DataZamowienia);

        }
    }
}
