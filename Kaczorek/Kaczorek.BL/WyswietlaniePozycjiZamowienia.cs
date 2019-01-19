namespace Kaczorek.BL
{
    public class WyswietlaniePozycjiZamowienia
    {
        
        public int PozycjaZamowieniaId { get; private set; }
        public int Ilosc { get; set; }
        public string NazwaProduktu { get; set; }
        public decimal? CenaZakupu { get; set; }
    }
}