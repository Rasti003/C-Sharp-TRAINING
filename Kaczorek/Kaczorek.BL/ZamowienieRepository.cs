using System;
using System.Collections.Generic;
using System.Text;

namespace Kaczorek.BL
{
    public class ZamowienieRepository
    {
 
        public Zamowienie Pobierz(int zamowienieId)
        {
            Zamowienie zamowienie = new Zamowienie(zamowienieId);



            if(zamowienieId == 10)
            {
                zamowienie.DataZamowienia = new DateTimeOffset(2018, 4, 20, 11, 00, 00, new TimeSpan(7, 0, 0));
            }
            return zamowienie;
        }


        public List<Zamowienie> Pobierz()
        {
            return new List<Zamowienie>();
        }

        public bool Zapisz(Zamowienie zamowienie)
        {

            var sukces = true;
            if (zamowienie.MaZmiany && zamowienie.DanePrawidlowe)
            {
                if (zamowienie.JestNowy)
                {
                    //procedura insert
                }
                else
                {
                    //procedura update
                }
            }

            return sukces;
        }

        public WyswietlanieZamowienia PobierzZamowienieDoWyswietlenia(int zamowieniaId)
        {
            WyswietlanieZamowienia wyswietlanieZamowienia = new WyswietlanieZamowienia();

            if (zamowieniaId == 10)
            {
                wyswietlanieZamowienia.Imie = "Jacek";
                wyswietlanieZamowienia.Nazwisko = "Kowal";
                wyswietlanieZamowienia.DataZamowienia = new DateTimeOffset(2018, 5, 21, 12, 00, 00, new TimeSpan(5, 0, 0));
                wyswietlanieZamowienia.AdresDostrawy = new Adres()
                {
                    AdresTyp = 2,
                    Ulica = "Mila",
                    Miasto = "Katowice",
                    Kraj = "Polska",
                    KodPocztowy = "44-400"

                };
                wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniaLista = new List<WyswietlaniePozycjiZamowienia>();
                if (zamowieniaId == 10)
                {
                    var wyswietlaniePozycjiZamowienia = new WyswietlaniePozycjiZamowienia()
                    {
                        NazwaProduktu = "Stol",
                        CenaZakupu = 300.50M,
                        Ilosc = 10
                    };

                    wyswietlaniePozycjiZamowienia = new WyswietlaniePozycjiZamowienia()
                    {
                        NazwaProduktu = "Blat",
                        CenaZakupu = 50.33M,
                        Ilosc = 5
                    };

                    wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniaLista.Add(wyswietlaniePozycjiZamowienia);
                }

            }

            return wyswietlanieZamowienia;
        }

    }
}
