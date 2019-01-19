using System;
using System.Collections.Generic;
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

        [TestMethod]
        public void PobierzZamowieniaDoWyswietleniaTest()
        {
            //Arrange
            var zamowienieRepository = new ZamowienieRepository();
            var oczekiwana = new WyswietlanieZamowienia()
            {
                Imie = "Jacek",
                Nazwisko = "Kowal",
                DataZamowienia = new DateTimeOffset(2018, 5, 21, 12, 00, 00, new TimeSpan(5, 0, 0)),
                AdresDostrawy = new Adres()
                {
                    AdresTyp = 2,
                    Ulica = "Mila",
                    Miasto = "Katowice",
                    Kraj = "Polska",
                    KodPocztowy = "44-400"
                },
                WyswietlaniePozycjiZamowieniaLista = new List<WyswietlaniePozycjiZamowienia>()
                {
                    new WyswietlaniePozycjiZamowienia()
                    {
                        NazwaProduktu = "Blat",
                        CenaZakupu = 50.33M,
                        Ilosc = 5
                      
                    },

                    new WyswietlaniePozycjiZamowienia()
                    {
                        NazwaProduktu ="Stol",
                        CenaZakupu = 300.50M,
                        Ilosc =10


                    }
                }
            };

            //Act
            var aktualna = zamowienieRepository.PobierzZamowienieDoWyswietlenia(10);

            //Assert
            Assert.AreEqual(oczekiwana.ZamowienieID, aktualna.ZamowienieID);
            Assert.AreEqual(oczekiwana.DataZamowienia, aktualna.DataZamowienia);
            Assert.AreEqual(oczekiwana.Imie, aktualna.Imie);
            Assert.AreEqual(oczekiwana.Nazwisko, aktualna.Nazwisko);

            Assert.AreEqual(oczekiwana.AdresDostrawy.AdresTyp, aktualna.AdresDostrawy.AdresTyp);
            Assert.AreEqual(oczekiwana.AdresDostrawy.Ulica, aktualna.AdresDostrawy.Ulica);
            Assert.AreEqual(oczekiwana.AdresDostrawy.Ulica, aktualna.AdresDostrawy.Ulica);
            Assert.AreEqual(oczekiwana.AdresDostrawy.Miasto, aktualna.AdresDostrawy.Miasto);
            Assert.AreEqual(oczekiwana.AdresDostrawy.KodPocztowy, aktualna.AdresDostrawy.KodPocztowy);
            Assert.AreEqual(oczekiwana.AdresDostrawy.Kraj, aktualna.AdresDostrawy.Kraj);

            for (int i = 0; i < 1; i++)
            {
                
                    Assert.AreEqual(oczekiwana.WyswietlaniePozycjiZamowieniaLista[i].NazwaProduktu, aktualna.WyswietlaniePozycjiZamowieniaLista[i].NazwaProduktu);
                    Assert.AreEqual(oczekiwana.WyswietlaniePozycjiZamowieniaLista[i].Ilosc, aktualna.WyswietlaniePozycjiZamowieniaLista[i].Ilosc);
                    Assert.AreEqual(oczekiwana.WyswietlaniePozycjiZamowieniaLista[i].CenaZakupu, aktualna.WyswietlaniePozycjiZamowieniaLista[i].CenaZakupu);
                

            }
         
        }

    }
}
