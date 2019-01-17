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

        public bool Zapisz()
        {

            return true;
        }

    }
}
