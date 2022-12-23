using Banka.Data.Interfejsi;

namespace Banka.Data.Klase
{
    public class ZiroRacun : IRacunBanke
    {

        // Atributi i svojstva
        private decimal _stanje_na_racunu = 0.00M;
        public decimal Saldo 
        {
            get
            {
                return _stanje_na_racunu;
            }
        }

        // Dodatne metode
        public string IspisiSaldo()
        {
            return String.Format(
                "Informacije o stanju žiro računa: {0:C}",
                _stanje_na_racunu
            );
        }

        public void Uplata(decimal iznos)
        {
            _stanje_na_racunu += iznos;
            // Ovo gore je skraćeno od 
            // _stanje_na_racunu = _stanje_na_racunu + iznos;
        }

        public void Isplata(decimal iznos)
        {
            if (_stanje_na_racunu >= iznos)
            {
                _stanje_na_racunu -= iznos;
            }
            else
            {
                Console.WriteLine("Nemate dovoljno sredstava na računu!");
            }
        }

    }
}
