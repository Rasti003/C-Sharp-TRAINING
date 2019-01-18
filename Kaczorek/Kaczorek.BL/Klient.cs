
using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class Klient
    {
        #region konstruktory
        public Klient(): this(0) 
        {

        }

        public Klient(int klientId)
        {
            this.KlientId = klientId;
            this.ListaAdresow = new List<Adres>();
        }
        #endregion

        #region wlasciwosci
        public static int licznik { get; set; }

        private string _nazwisko;

        public string Nazwisko
        {
            get
            {
                return _nazwisko;
            }
            set
            {
                _nazwisko = value;
            }

        }

        public string Imie { get; set; }

        public string Email { get; set; }

        public int KlientId { get; private set; }

        public string ImieNazwisko
        {
            get
            {
                string imieNazwisko = Imie;
                if (!string.IsNullOrWhiteSpace(Nazwisko))
                {
                    if (!string.IsNullOrWhiteSpace(imieNazwisko))
                    {
                        imieNazwisko += ", ";
                    }
                    imieNazwisko += Nazwisko;
                }
                return imieNazwisko;
            }
        }

        public List<Adres> ListaAdresow  { get; set; }
        #endregion

        #region metody
        public bool Zwaliduj()
        {
            var poprawne = true;

            if (string.IsNullOrWhiteSpace(Nazwisko))
                poprawne = false;
            if (string.IsNullOrWhiteSpace(Email))
                poprawne = false;


            return poprawne;

        }

        public bool Zapisz()
        {
        
        return true;
        }

        public Klient Pobierz (int klientId)
        {
            return new Klient();
        }
        public List<Klient> Pobierz()
        {
            return new List<Klient>();
        }
        #endregion
    }
}
