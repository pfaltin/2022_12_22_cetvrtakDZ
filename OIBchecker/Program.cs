namespace OIBchecker
{
    internal class Program
    {
        static void Main(string[] args)

        {
/*
 KONTROLA OIB-a (ISO7064, MOD 11,10 – Hibridni sistem)
    1. OIB ima 11 z namenaka od koji je posljednja tj. 11. znamenka kontrolna znamenka dobivena je izračunom iz prethodnih 10 znamenaka po medjunarodnoj normi ISO 7064 (MOD 11, 10).
    2. Kontrolna znamenka prema navedenoj normi dobiva se slijedećim postupkom :
        1. prva znamenka zbroji se s brojem 10
                mo = z1 + 10
        2. dobiveni zbroj cjelobrojno (s ostatkom) podijeli se brojem 10; ako je dobiveni ostatak 0 zamijeni se brojem 10 (ovaj broj je tzv. medjuostatak)
                mo= mo / 10
                    if mo == 0 then mo = 10
        3. dobiveni medjuostatak pomnoži se brojem 2
                    um = mo*2
        4. dobiveni umnožak cjelobrojno (s ostatkom) podijeli se brojem 11; ovaj ostatak matematički nikako ne može biti 0 jer je rezultat prethodnog koraka uvijek paran broj 
                ko = um /11
        5. slijedeća znamenka zbroji se s ostatkom u prethodnom koraku
        6. ponavljaju se koraci 2, 3, 4 i 5 dok se ne potroše sve znamenke
        7. razlika izmedju broja 11 i ostatka u zadnjem koraku je kontrolna znamenka; ako je ostatak 1 kontrolna znamenka je 0 (11-1=10, a 10 ima dvije znamenke)
 */
            string oibZaKontrolu = "69435151530";
            System.Console.WriteLine("OIB : " + oibZaKontrolu);
            Console.WriteLine("OIB je ispravan: " + (OIBKontrola(oibZaKontrolu)));

             bool OIBKontrola( string oib)
            {
                 int ostatak = 0, umnozak = 0;
                //char znamenka;
                 int  vrije_chr, medjuzbroj=0;
                
                if ( oib.Length != 11)
                    { return false; }
                else
                {
                    vrije_chr = (oib[0]) - 48;
                    medjuzbroj = (vrije_chr + 10); // korak 1.
                    for (int i = 1; i <= 10; i++)
                    {
                        ostatak = medjuzbroj % 10; // korak  2.
                        if (ostatak == 0) ostatak = 10; 
                        umnozak = ostatak * 2; // korak 3.
                        ostatak = umnozak % 11; //4
                        
                        medjuzbroj = ostatak + (vrije_chr = (oib[i]) - 48);// korak 5
                    }
                    System.Console.WriteLine("kont : "+ umnozak +" ostatak : "+ ostatak);
                if ((oib[10]-48)== 11 - ostatak)
                    {
                        return true;
                    }
                    else if ((oib[10]-48)== 0 && ostatak ==1 )
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
    
}