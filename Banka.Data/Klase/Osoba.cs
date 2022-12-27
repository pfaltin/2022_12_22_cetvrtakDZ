using System.Diagnostics.SymbolStore;
using OIBcheck;



namespace Banka.Data.Klase
{
    public class Osoba
    {

        // field -> atributi, polja ili varijable klase


        // Properties -> svojstva klase 
        public string OIB { get; set; } // validacija OIBa - samo brojevi i max 11 znamenki
        public string ImePrezime { get; set; }
        public string Adresa { get; set; }
        public ZiroRacun? ZiroRacun { get; set; }
        public TekuciRacun? TekuciRacun { get; set; }


        public static bool OIBKontrola(string oib)
        {
            
            return false;
        }
    }
}
