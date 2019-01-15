using System;
using System.Collections.Generic;
using System.Text;

namespace Kaczorek.BL
{
    public class PozycjaZamowienia
    {
        public PozycjaZamowienia()
        {

        }

        public PozycjaZamowienia(int pozycjaZamowieniaId)
        {
            this.PozycjaZamowieniaId = pozycjaZamowieniaId;
        }

        public int PozycjaZamowieniaId { get; private set; }
        public int Ilosc { get; set; }
        public int ProduktId { get; set; }
        public decimal? CenaZakupu { get; set; }


        public bool Zwaliduj()
        {
            var poprawne = true;

            if (Ilosc <= 0)
            {
                return false;
            }

            if (ProduktId <= 0)
            {
                return false;
            }

            if (CenaZakupu == null)
            {
                return false;
            }

            return poprawne;

        }



        public bool Zapisz()
        {

            return true;
        }

        public PozycjaZamowienia Pobierz(int pozycjaZamowieniaId)
        {
            return new PozycjaZamowienia();
        }
    }
}

