using System;
using System.Collections.Generic;
using System.Text;

namespace Kaczorek.BL
{
    public class AdresRepository
    {
        public Adres Pobierz (int adresId) {
            Adres adres = new Adres(adresId);

            if (adresId == 1)
            {
                adres.AdresTyp = 1;
                adres.Ulica = "Gościnna";
                adres.Miasto = "Katowice";
                adres.Kraj = "Polska";
                adres.KodPocztowy = "40-467";
                }
            return adres;
        }
        
        public IEnumerable<Adres> PobierzPoKlientId(int klientID)
        {

            var listaAdresow = new List<Adres>();
            Adres adres = new Adres(1)
            {
                AdresTyp = 1,
                Ulica = "Adama",
                Miasto = "Opole",
                Kraj = "Polska",
                KodPocztowy = "11-100"
            };

            adres = new Adres(2)
            {
                AdresTyp = 3,
                Ulica = "Mila",
                Miasto = "Katowice",
                Kraj ="Polska",
                KodPocztowy = "44-400"
            };

            listaAdresow.Add(adres);

            return listaAdresow;
        }

        public bool Zapisz(Adres adres)
        {
            return true;
        }
    }
}
