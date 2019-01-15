using System;
using System.Collections.Generic;
using System.Text;

namespace Kaczorek.BL
{
    public class Zamowienie
    {
        public Zamowienie()
        {

        }

        public Zamowienie(int zamowienieId)
        {
            this.ZamowienieId = zamowienieId;
        }
        public int ZamowienieId { get; private set; }
        public DateTimeOffset? DataZamowienia { get; set; }

        public bool Zwaliduj()
        {
            var poprawne = true;

            if (DataZamowienia == null)
            {
                return false;
            }

            return poprawne;

        }

        public bool Zapisz()
        {

            return true;
        }

        public Zamowienie Pobierz(int zamowienieId)
        {
            return new Zamowienie();
        }


        public List<Zamowienie> Pobierz()
        {
            return new List<Zamowienie>();
        }


    }
}
