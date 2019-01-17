
using Kaczorek.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kaczorek.BLTest
{
    [TestClass]
    public class ProduktRepositoryTest
    {
        [TestMethod]
        public void PobierzProduktTest()
        {
            //Arrange
            var produktRepository = new ProduktRepository();
            var oczekiwane = new Produkt(5)
            {
                NazwaProduktu = "Klocki",
                Opis = "Klocki dla dzieci",
                AktalnaCena = 89.99M
            };
            //Act
            var aktualne = produktRepository.Pobierz(5);
            //Assert
            Assert.AreEqual(oczekiwane.ProduktId, aktualne.ProduktId);
            Assert.AreEqual(oczekiwane.NazwaProduktu, aktualne.NazwaProduktu);
            Assert.AreEqual(oczekiwane.Opis, aktualne.Opis);
            Assert.AreEqual(oczekiwane.AktalnaCena, aktualne.AktalnaCena);
        }
    }
}
