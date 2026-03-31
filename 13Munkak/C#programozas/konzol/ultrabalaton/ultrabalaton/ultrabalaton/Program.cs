using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
//1. Feladat
namespace ultrabalaton
{
    class Program
    {
        //2. Feladat
        struct BalatonStruktura
        {
            public string Versenyzo;
            public string Kategoria;
            public int Rajtszam;
            public string Versenyido;
            public int TavSzazalek;
        }
        static void Main(string[] args)
        {
            ultrabalaton();
            Console.ReadKey();
        }
        // 6. Feladathoz
        static double IdoOraban(string verseny_ido) 
        {
            string[] ido_reszek = verseny_ido.Split(':');
            double ora = double.Parse(ido_reszek[0]);
            double perc = double.Parse(ido_reszek[1]);
            double masodperc = double.Parse(ido_reszek[2]);

            return ora + (perc / 60) + (masodperc / 3600);
        }

        private static void ultrabalaton() 
        {
            StreamReader olvasocsatorna = new StreamReader(@"Z:\programozas\ultrabalaton\ub2017egyeni.txt");

            string elsosor = olvasocsatorna.ReadLine();
            string sor;

            List<BalatonStruktura> adatok = new List<BalatonStruktura>();
            string[] darabol;

            while (!olvasocsatorna.EndOfStream) 
            {
                sor = olvasocsatorna.ReadLine();
                darabol = sor.Split(';');

                BalatonStruktura balaton = new BalatonStruktura();

                balaton.Versenyzo = darabol[0];
                balaton.Rajtszam = int.Parse(darabol[1]);
                balaton.Kategoria = darabol[2];
                balaton.Versenyido = darabol[3];
                balaton.TavSzazalek = int.Parse(darabol[4]);

                adatok.Add(balaton);
            }
            Console.WriteLine("1-2 Feladat megtörtént!\n\n");

            //3. Feladat
            Console.WriteLine("3. Feladat: Egyéni indulók: {0} fő", adatok.Count());

            //4. Feladat
            int nok_szama = 0;
            for (int i = 0; i < adatok.Count(); i++)
            {
                if (adatok[i].Kategoria.ToLower() == "noi" && adatok[i].TavSzazalek == 100) 
                {
                    nok_szama++;
                }
            }
            Console.WriteLine("\n4. Feladat: Célba érkező női sportolók: {0} fő", nok_szama);

            //5. Feladat
            Console.Write("\n5. Feladat: Kérem a sportoló nevét: ");
            string versenyzo_nev = Console.ReadLine();
            bool indult = false;
            bool teljesitette = false;

            for (int i = 0; i < adatok.Count(); i++)
            {
                if (versenyzo_nev == adatok[i].Versenyzo) 
                {
                    indult = true;
                }
                if (versenyzo_nev == adatok[i].Versenyzo && adatok[i].TavSzazalek == 100) 
                {
                    teljesitette = true;
                }
            }

            if (indult)
            {
                Console.WriteLine("Indult egyéniben a sportoló? Igen");
                if (teljesitette)
                {
                    Console.WriteLine("Teljesítette a teljes távot? Igen");
                }
                else
                {
                    Console.WriteLine("Teljesítette a teljes távot? Nem");
                }
            }
            else 
            {
                Console.WriteLine("Indult egyéniben a sportoló? Nem");
            }

            //7. Feladat
            double osszes_ido = 0;
            int ferfiak_szama = 0;

            for (int i = 0; i < adatok.Count(); i++)
            {
                if (adatok[i].Kategoria.ToLower() == "ferfi" && adatok[i].TavSzazalek == 100) 
                {
                    osszes_ido += IdoOraban(adatok[i].Versenyido);
                    ferfiak_szama += 1;
                }
            }
            Console.WriteLine("\n7. Feladat: Átlagos idő: {0} óra", osszes_ido / ferfiak_szama);

            //8. Feladat
            double noi_legjobb_ido = double.MaxValue;
            double ferfi_legjobb_ido = double.MaxValue;
            double aktualis_ido;

            string noi_gyoztes = "";
            string ferfi_gyoztes = "";
            Console.WriteLine("\n8. Feladat: Verseny győztesei");

            for (int i = 0; i < adatok.Count(); i++)
            {
                if (adatok[i].TavSzazalek == 100) 
                {
                    aktualis_ido = IdoOraban(adatok[i].Versenyido);
                    if (adatok[i].Kategoria.ToLower() == "noi" && aktualis_ido < noi_legjobb_ido)
                    {
                        noi_legjobb_ido = aktualis_ido;
                        noi_gyoztes = $"{adatok[i].Versenyzo} ({adatok[i].Rajtszam}) - {adatok[i].Versenyido}";
                    }
                    if (adatok[i].Kategoria.ToLower() == "ferfi" && aktualis_ido < ferfi_legjobb_ido)
                    {
                        ferfi_legjobb_ido = aktualis_ido;
                        ferfi_gyoztes = $"{adatok[i].Versenyzo} ({adatok[i].Rajtszam}) - {adatok[i].Versenyido}";
                    }
                }
            }

            Console.WriteLine("\tNők: {0}\n\tFérfiak: {1}", noi_gyoztes, ferfi_gyoztes);
        }
        // Elért pontszám:
        // 38/40
    }
}
