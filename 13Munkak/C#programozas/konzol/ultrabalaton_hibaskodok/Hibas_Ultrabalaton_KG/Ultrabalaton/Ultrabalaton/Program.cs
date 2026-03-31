using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultrabalaton
{
    class Program
    {
        struct versenyzoStruktura
        {
            public string nev;
            public int rajtszam; 
            public string kategoria;
            public string versenyido; //int[]
            public int tavSzazalek;
            public int ora;
            public int perc;
            public int masodperc;
        }
        static List<versenyzoStruktura> adatok = new List<versenyzoStruktura>();
        static void Main(string[] args)
        {
            StreamReader olvasocsatorna = new StreamReader("ub2017egyeni.txt");
            string elsosor = olvasocsatorna.ReadLine();
            string sor;

            string[] darabol;
            while(!olvasocsatorna.EndOfStream)
            {
                sor = olvasocsatorna.ReadLine();
                darabol = sor.Split(';');


                versenyzoStruktura versenyzo = new versenyzoStruktura();

                versenyzo.nev = darabol[0];
                versenyzo.rajtszam = int.Parse(darabol[1]);
                versenyzo.kategoria = darabol[2];
                //versenyzo.versenyido = darabol[3];
                versenyzo.tavSzazalek = int.Parse(darabol[4]);

                string[] idoDarabol = darabol[3].Split(':');
                versenyzo.ora = int.Parse(idoDarabol[0]);
                versenyzo.perc = int.Parse(idoDarabol[1]);
                versenyzo.masodperc = int.Parse(idoDarabol[2]);

                adatok.Add(versenyzo);
            }
            olvasocsatorna.Close();
            //32 pont

            //3. Feladat: Mennyi versenyző van összesen
            Feladat03();

            //4. Feladat: Mennyi női versenyző van összesen
            Feladat04();


            //5. Feladat: Indult-e a keresett versenyző a versenyen
            Feladat05();

            //6. Feladat: Versenyidő órában
            Feladat06();
            //7. Feladat: Férfiak átlag versenyideje
            Feladat07();
            //8. Feladat: Legjobbak mindkét kategóriából
            //Feladat08();
            Console.ReadKey();

        }

        private static void Feladat08()//1,0,0,1,0,0,0
        {
            string LegjobbFerfiVersenyzo;
            int LegjobbFerfiRajtszam;
            int LegjobbFerfiOra;
            int LegjobbFerfiPerc;
            int LegjobbFerfiMasodperc;
            string LegjobbNoiVersenyzo;
            int LegjobbNoiRajtszam;
            int LegjobbNoiOra;
            int LegjobbNoiPerc;
            int LegjobbNoiMasodperc;
            int min = 0;
            int versenyido = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                versenyido = int.Parse(adatok[i].versenyido);
                if (adatok[i].kategoria == "Ferfi")
                {
                    if (min < versenyido)
                    {
                        min = versenyido;
                        LegjobbFerfiOra = adatok[i].ora;
                        LegjobbFerfiPerc = adatok[i].perc;
                        LegjobbFerfiMasodperc = adatok[i].masodperc;
                        LegjobbFerfiVersenyzo = adatok[i].nev;
                        LegjobbFerfiRajtszam = adatok[i].rajtszam;
                    }
                }
                else if (adatok[i].kategoria == "Noi")
                {
                    if (min < versenyido)
                    {
                        min = versenyido;
                        LegjobbNoiOra = adatok[i].ora;
                        LegjobbNoiPerc = adatok[i].perc;
                        LegjobbNoiMasodperc = adatok[i].masodperc;
                        LegjobbNoiVersenyzo = adatok[i].nev;
                        LegjobbNoiRajtszam = adatok[i].rajtszam;
                    }
                }
            }
            Console.WriteLine("8. Feladat: A verseny győztesei: ");
            Console.WriteLine("Nők: {0} ({1}) - {2}:{3}:{5}", LegjobbNoiVersenyzo, LegjobbNoiRajtszam, LegjobbNoiOra, LegjobbNoiPerc, LegjobbNoiMasodperc);
            Console.WriteLine("Férfiak: {0} ({1}) - {2}:{3}:{5}", LegjobbFerfiVersenyzo, LegjobbFerfiRajtszam, LegjobbFerfiOra, LegjobbFerfiPerc, LegjobbFerfiMasodperc);

        }

        private static void Feladat07()//1,1,1,1,1,0,1
        {
            double osszesen = 0;
            double mennyi = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].kategoria == "Ferfi" && adatok[i].tavSzazalek == 100)
                {
                    osszesen = osszesen + adatok[i].ora + adatok[i].perc/60 + adatok[i].masodperc/3600;
                    mennyi++;
                }
            }
            double atlag = osszesen / mennyi;
            Console.WriteLine("7. Feladat: Átlagos idő: {0} óra", atlag); 

        }

        private static void Feladat06()//1,2,1
        {
            int idoOraban = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                idoOraban= adatok[i].ora + adatok[i].perc/60 + adatok[i].masodperc/3600;
            }
        }

        private static void Feladat05()
        {
            Console.Write("\n5. Feladat: Kérem a sportoló nevét: ");
            string bekertVersenyzo = Console.ReadLine(); //1,1,0,1,1,1
            int keresettTavszazalek = 0;
            bool vane = false;
            bool teljesitette = false;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].nev == bekertVersenyzo) //while
                {
                    vane = true;
                    keresettTavszazalek = adatok[i].tavSzazalek;
                    if (adatok[i].tavSzazalek == 100)
                    {
                        teljesitette = true;
                    }
                    break;
                }
            }
            if (vane == true)
            {
                Console.WriteLine("Indult egyéniben a sportoló? Igen");
                if (teljesitette == true)
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
        }

        private static void Feladat04()//1,1,1,1,1
        {
            int mennyiCelbaertNoi = 0; 
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].kategoria == "Noi" && adatok[i].tavSzazalek == 100) 
                {
                    mennyiCelbaertNoi++;
                }
            }
            Console.WriteLine("4. Feladat: Célba érkező női indulók: {0} fő", mennyiCelbaertNoi);
        }

        private static void Feladat03() //1,1
        {
            Console.WriteLine("3. Feladat: Egyéni indulók: {0} fő", adatok.Count);
        }
    }               //2,1,1,1,0,1,1,1,1
}
