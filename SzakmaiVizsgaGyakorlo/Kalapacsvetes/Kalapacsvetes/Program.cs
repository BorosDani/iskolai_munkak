using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kalapacsvetes
{
    class Program
    {
        static List<Sportolo> adatok = new List<Sportolo>();
        static void Main(string[] args)
        {
            beolvas();
            feladat5();
            feladat6();
            Console.ReadLine();
        }


        private static void beolvas() 
        {
            StreamReader olvasocsatorna = new StreamReader("kalapacsvetes.txt");
            string sor = olvasocsatorna.ReadLine();

            while (!olvasocsatorna.EndOfStream)
            {
                sor = olvasocsatorna.ReadLine();
                Sportolo adat = new Sportolo(sor);
                adatok.Add(adat);
            }

            olvasocsatorna.Close();

            Console.WriteLine($"4. feladat: {adatok.Count()} dobás eredménye található.");
        }


        private static void feladat5() 
        {
            double atlagEredmeny = 0;
            int magyarokSzama = 0;
            foreach (var adat in adatok)
            {
                if (adat.orszagKod == "HUN") 
                {
                    atlagEredmeny += adat.eredmeny;
                    magyarokSzama++;
                }
            }

            /*MÁSIK MEGOLDÁS (jobb)
             * 
            double magyarAtlag = 
                (from adat in adatok 
                 where adat.orszagKod == "HUN" 
                 select adat.eredmeny).Average();
            */

            Console.WriteLine($"5. feladat: A magyar sportolók átlagosan {Math.Round(atlagEredmeny / magyarokSzama, 2)} métert dobtak.");
        }


        private static void feladat6()
        {
            Console.WriteLine("6. feladat: Adjon meg egy évszámot:");
            int keresettEvszam = Convert.ToInt32(Console.ReadLine());
            int dobasokSzamaAzEvben = 0;
            List<string> versenyzok = new List<string>();

            foreach (var adat in adatok)
            {
                if (Convert.ToInt32(adat.datum.Split('.')[0]) == keresettEvszam)
                {
                    dobasokSzamaAzEvben++;
                    versenyzok.Add(adat.sportolo);
                }
            }

            if (dobasokSzamaAzEvben > 0)
            {
                Console.WriteLine($"\t{dobasokSzamaAzEvben} darab dobás került be ebben az évben.");
                foreach (var adat in versenyzok)
                {
                    Console.WriteLine("\t" + adat);
                }
            }

            else
            {
                Console.WriteLine("\tEgy dobás sem került be bben az évben.");
            }
        }


        private static void feladat7()
        {
            Console.WriteLine("7. feladat: Statisztika");

            var statisztika = adatok.GroupBy(a => a.orszagKod);

            foreach (var csoport in statisztika)
            {
                Console.WriteLine($"\t{csoport.Key} - {csoport.Count()} dobás");
            }
        }


        private static void feladat8()
        {
            StreamWriter irocsatorna = new StreamWriter("magyarok.txt");

            foreach (var adat in adatok)
            {
                if (adat.orszagKod == "HUN")
                {
                    irocsatorna.WriteLine($"{adat.helyezes};{adat.eredmeny};{adat.sportolo};{adat.orszagKod};{adat.helyszin};{adat.datum}");
                }
            }

            irocsatorna.Close();
        }
    }
}
