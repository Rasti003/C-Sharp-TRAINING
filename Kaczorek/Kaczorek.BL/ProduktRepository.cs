using System;
using System.Collections.Generic;
using System.Text;

namespace Kaczorek.BL
{
    public class ProduktRepository
    {

        public Produkt Pobierz(int produktId)
        {
            Produkt produkt = new Produkt(produktId);
            

            if(produktId== 5)
            {
                produkt.NazwaProduktu = "Klocki";
                produkt.Opis = "Klocki dla dzieci";
                produkt.AktalnaCena = 89.99M;
            }

            return produkt;
        }


        public List<Produkt> Pobierz()
        {
            return new List<Produkt>();
        }

        public bool Zapisz( Produkt produkt)
        {
            var sukces = true;
            if (produkt.MaZmiany && produkt.DanePrawidlowe)
            {
                if (produkt.JestNowy)
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
    }
}
