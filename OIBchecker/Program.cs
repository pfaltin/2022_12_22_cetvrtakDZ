namespace OIBchecker
{
    internal class Program
    {
        static void Main(string[] args)

        {
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
                    um = mo*2
        4. dobiveni umnožak cjelobrojno (s ostatkom) podijeli se brojem 11; ovaj ostatak matematički nikako ne može biti 0 jer je rezultat prethodnog koraka uvijek paran broj 
                ko = um /11
        5. slijedeća znamenka zbroji se s ostatkom u prethodnom koraku
        6. ponavljaju se koraci 2, 3, 4 i 5 dok se ne potroše sve znamenke
        7. razlika izmeñu broja 11 i ostatka u zadnjem koraku je kontrolna znamenka; ako je ostatak 1 kontrolna znamenka je 0 (11-1=10, a 10 ima dvije znamenke)



 * 
 */
            string oibZaKontrolu = "69435151530";
            OIBKontrola(oibZaKontrolu);

            bool OIBKontrola( string oib)
            {
                decimal medjuostatak;
                decimal umnozak, kolicnik, ;
                char znamenka;
                int vrije_chr, medjuzbroj;
                
                if ( oib.Length != 11)
                { return false; }
                else
                {
                    /*
                    znamenka = (oib[1]);
                    Console.WriteLine(znamenka-48);
                    vrije_chr = znamenka - 48; 
                    Console.WriteLine(" sds" + vrije_chr);
                    */
                    for (int i = 0; i <= 11; i++)
                    {
                        vrije_chr = (oib[1]) - 48;
                        medjuostatak = (vrije_chr + 10) / 10; // korak 1. i 2.
                        if (medjuostatak == 0) medjuostatak = 10; 
                        umnozak = medjuostatak * 2; // korak 3.
                        kolicnik = umnozak / 11; //4
                        medjuzbroj = (int)(11 % kolicnik);



                    }









                }
                return false;
            }
        }
    }
    
}