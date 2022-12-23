using Banka.Data.Interfejsi;

// Domaća zadaća
// Ažurirati metode koje prikazuju podatke o stanju računa ako je minus odobren
// Prikazati stvarni iznos računa i obavijest o dozvoljenom minusu (ako je minus odobren) kada se iznos uplaćuje ili isplaćuje

namespace Banka.Data.Klase
{
    public class TekuciRacun : IRacunBanke, ITekuciRacun
    {
        // Atributi i svojstva
        private decimal _stanje_na_racunu = 0.00M;
        private decimal _max_minus;
        public decimal Saldo
        {
            get
            {
                return _stanje_na_racunu;
            }
        }
        public bool DozvoljenMinus { get; set; } = false;
        public decimal MaxDozvoljenMinus { 
            get
            {
                return _max_minus;
            }
            set
            {
                if(value >= 0)
                {
                    _max_minus = value;
                } 
                else
                {
                    _max_minus = 0.00M;
                }
            }
        }

        // konstruktor
        public TekuciRacun() { }
        public TekuciRacun(bool dozvoli_minus, decimal max_dozvoljen_minus)
        {
            DozvoljenMinus = dozvoli_minus;
            MaxDozvoljenMinus = max_dozvoljen_minus;
        }

        // Dodatne metode
        public string IspisiSaldo()
        {
            return String.Format(
                "Informacije o stanju tekućeg računa: {0:C}",
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

            decimal provjeri_stanje = (DozvoljenMinus == true) ? _stanje_na_racunu + MaxDozvoljenMinus : _stanje_na_racunu;

            if (provjeri_stanje >= iznos)
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
