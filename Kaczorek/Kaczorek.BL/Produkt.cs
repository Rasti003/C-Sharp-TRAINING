using System;
using System.Collections.Generic;
using System.Text;

namespace Kaczorek.BL
{
    public class Produkt : KlasaBazowa 
    {
        public Produkt()
        {

        }

        public Produkt(int produktId)
        {
            this.ProduktId = produktId;
        }
        public int ProduktId { get; private set; }
        public Decimal? AktalnaCena { get; set; }
        public string Opis { get; set; }
        private string _NazwaProduktu;

        public string NazwaProduktu
        {
            get { return _NazwaProduktu; }
            set { _NazwaProduktu = value; }
        }



        public override bool Zwaliduj()
        {
            var poprawne = true;

            if (string.IsNullOrWhiteSpace(NazwaProduktu))
                poprawne = false;
            if (AktalnaCena == null)
            {
                return false;
            }

            return poprawne;

        }

        public bool Zapisz()
        {

            return true;
        }

        public Produkt Pobierz(int produktId)
        {
            return new Produkt();
        }


        public List<Produkt> Pobierz()
        {
            return new List<Produkt>();
        }
        public override string ToString()
        {
            return NazwaProduktu;
        }

   
    }
}
