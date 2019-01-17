using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaczorek.BL
{
    public class KlientRepository
    {
        

        public Klient Pobierz(int klientId)
        {
            Klient klient = new Klient(klientId);

            if (klientId ==1)
            {
                klient.Email = "marcin@dev-hobby.pl";
                klient.Imie = "Marcin";
                klient.Nazwisko = "Kowal";
                
            }
            return klient;
        }


        public List<Klient> Pobierz()
        {
            return new List<Klient>();
        }

        public bool Zapisz()
        {

            return true;
        }

    }

}
