using Banka.Data.Klase;
using System.Numerics;
using System.Security.Cryptography;

namespace Banka.Konzola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Mićo
            Osoba mico = new Osoba();
            mico.OIB = "12345677474";
            mico.ImePrezime = "Mićo Programerić";
            mico.Adresa = "Stara Cesta bb";
            mico.ZiroRacun = new ZiroRacun();
            mico.TekuciRacun = new TekuciRacun();

            Console.WriteLine("\n=====================================\n");
            Console.WriteLine("Korisnik: " + mico.ImePrezime + " ("+mico.OIB+")");
            Console.WriteLine("Adresa: " + mico.Adresa);
            Console.WriteLine("\n=====================================\n");

            Console.WriteLine("Žiro račun: ");

            Console.WriteLine(mico.ZiroRacun.IspisiSaldo());

            mico.ZiroRacun.Uplata(400);
            Console.WriteLine(mico.ZiroRacun.IspisiSaldo());

            mico.ZiroRacun.Uplata(534.60M);
            Console.WriteLine(mico.ZiroRacun.IspisiSaldo());

            mico.ZiroRacun.Isplata(1000);
            Console.WriteLine(mico.ZiroRacun.IspisiSaldo());

            Console.WriteLine();
            Console.WriteLine("Tekući račun:");
            Console.WriteLine();

            mico.TekuciRacun.Uplata(678.50M);
            Console.WriteLine(mico.TekuciRacun.IspisiSaldo());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // Ana
            Osoba ana = new Osoba();
            ana.OIB = "987654234";
            ana.ImePrezime = "Ana Dizajnerić";
            ana.Adresa = "Čandekova 4";
            ana.TekuciRacun = new TekuciRacun(true, 4560.00M);

            Console.WriteLine("\n=====================================\n");
            Console.WriteLine("Korisnik: " + ana.ImePrezime + " (" + ana.OIB + ")");
            Console.WriteLine("Adresa: " + ana.Adresa);
            Console.WriteLine("\n=====================================\n");

            Console.WriteLine("Tekući račun");

            ana.TekuciRacun.Uplata(240);
            Console.WriteLine(ana.TekuciRacun.IspisiSaldo());

            ana.TekuciRacun.Isplata(1200);
            Console.WriteLine(ana.TekuciRacun.IspisiSaldo());

            Console.WriteLine("\n=============GOTOVO=============\n");
            Console.ReadKey();

            //Napraviti validaciju OIB svojstva klase Osoba
            //Ažurirati metode koje prikazuju podatke o stanju računa ako je minus odobren
            //Prikazati stvarni iznos računa i obavijest o dozvoljenom minusu(ako je minus odobren) kada se iznos uplaćuje ili isplaćuje
            //Testirati rad aplikacije




        }
    }
}