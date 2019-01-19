using System;
using System.Collections.Generic;
using System.Text;

namespace Kaczorek.BL
{
    #region konstruktory
    public class Zamowienie : KlasaBazowa
    {
        public Zamowienie()
        {

        }

        public Zamowienie(int zamowienieId)
        {
            this.ZamowienieId = zamowienieId;
        }

        #endregion

        #region wlasciowsci
        public int ZamowienieId { get; private set; }
        public DateTimeOffset? DataZamowienia { get; set; }
        public List<PozycjaZamowienia> pozycjaZamowienias { get; set; }
        public int KlientId { get; set; }
        public int AdresDostawyId { get; set; }
        #endregion

        #region Metody
        public override bool Zwaliduj()
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
        #endregion

        public override string ToString()
        {
            return DataZamowienia.Value.Date + " ("  + ZamowienieId + ")";
        }

    }
}
