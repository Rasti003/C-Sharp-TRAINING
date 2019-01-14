using System;
using Kaczorek.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kaczorek.BLTest
{
    [TestClass]
    public class KlientTest
    {
        [TestMethod]
        public void ImieNazwiskoTest()
        {
            //Arrange (przygotówj test)
            Klient klient = new Klient();
            klient.Imie = "Robert";
            klient.Nazwisko = "Kowal";

            string oczekiwana = "Robert, Kowal";


            //Act (działaj)
            string akrualna = klient.ImieNazwisko;

            //Assert (potwierdz test) 
            Assert.AreEqual(oczekiwana, akrualna);

        }

        [TestMethod]
        public void ImieNazwiskoImiePusteTest()
        {
            //Arrange (przygotówj test)
            Klient klient = new Klient();
            klient.Nazwisko = "Kowal";

            string oczekiwana = "Kowal";


            //Act (działaj)
            string akrualna = klient.ImieNazwisko;

            //Assert (potwierdz test) 
            Assert.AreEqual(oczekiwana, akrualna);

        }


        [TestMethod]
        public void ImieNazwiskoPusteImieTest()
        {
            //Arrange (przygotówj test)
            Klient klient = new Klient();
            klient.Imie = "Robert";

            string oczekiwana = "Robert";


            //Act (działaj)
            string akrualna = klient.ImieNazwisko;

            //Assert (potwierdz test) 
            Assert.AreEqual(oczekiwana, akrualna);

        }

        [TestMethod]
        public void staticTest()
        {
            //Arrange (przygotówj test)
            var kln1 = new Klient();
            kln1.Imie = "Jacek";
            Klient.licznik += 1;

            var kln2 = new Klient();
            kln1.Imie = "Maciek";
            Klient.licznik += 1;

            var kln3 = new Klient();
            kln1.Imie = "Irek";
            Klient.licznik += 1;


            //Act (działaj)



            //Assert (potwierdz test) 
            Assert.AreEqual(3, Klient.licznik);

        }

    }
}
