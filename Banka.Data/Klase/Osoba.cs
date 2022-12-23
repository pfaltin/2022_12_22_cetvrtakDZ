using System.Diagnostics.SymbolStore;

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



        /*
         * 
         * KONTROLA OIB-a (ISO7064, MOD 11,10 – Hibridni sistem)
            1. OIB ima 11 z namenaka od koji je posljednja tj. 11. znamenka kontrolna znamenka dobivena je izračunom iz prethodnih 10 znamenaka po meñunarodnoj normi ISO 7064 (MOD 11, 10).
            2. Kontrolna znamenka prema navedenoj normi dobiva se slijedećim postupkom :
	            1. prva znamenka zbroji se s brojem 10
                        mo = z1 + 10
	            2. dobiveni zbroj cjelobrojno (s ostatkom) podijeli se brojem 10; ako je dobiveni ostatak 0 zamijeni se brojem 10 (ovaj broj je tzv. meñuostatak)
                        mo= mo / 10
                            if mo == 0 then mo = 10
	            3. dobiveni meñuostatak pomnoži se brojem 2
                            mo = mo*2
	            4. dobiveni umnožak cjelobrojno (s ostatkom) podijeli se brojem 11; ovaj ostatak matematički nikako ne može biti 0 jer je rezultat prethodnog koraka uvijek paran broj 
                            
	            5. slijedeća znamenka zbroji se s ostatkom u prethodnom koraku
	            6. ponavljaju se koraci 2, 3, 4 i 5 dok se ne potroše sve znamenke
	            7. razlika izmeñu broja 11 i ostatka u zadnjem koraku je kontrolna znamenka; ako je ostatak 1 kontrolna znamenka je 0 (11-1=10, a 10 ima dvije znamenke)


                
         * 
         */
        public static bool OIBKontrola(string oib)
        {
            if (oib.Length!=11) 
                { return false; } 
            else
                {

                
                }
            return false;
        }
    }
}
