using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//38 pont ---> 40 pontból
//1. Feladat
namespace cbradio
{
    class Program
    {
        static void Main(string[] args)
        {
            cbradio();
            Console.ReadLine();
        }
        private static void cbradio() 
        {
            feladat2();
            feladat3();
            Console.WriteLine("\n");
            feladat4();
            Console.WriteLine("\n");
            feladat5();
            Console.WriteLine("\n");
            feladat7();
            feladat8();
            Console.WriteLine("\n");
            feladat9();
        }

        struct CBRadioStruktura
        {
            public int Ora;
            public int Perc;
            public int AdasDb;
            public string Nev;
        }
        static List<CBRadioStruktura> adatok = new List<CBRadioStruktura>();

        private static void feladat2() 
        {
            StreamReader olvasocsatorna = new StreamReader("cb.txt");
            string elsosor = olvasocsatorna.ReadLine();
            string sor;

            string[] darabol;

            while (!olvasocsatorna.EndOfStream) 
            {
                sor = olvasocsatorna.ReadLine();
                darabol = sor.Split(';');

                CBRadioStruktura radio = new CBRadioStruktura();

                radio.Ora = int.Parse(darabol[0]);
                radio.Perc = int.Parse(darabol[1]);
                radio.AdasDb = int.Parse(darabol[2]);
                radio.Nev = darabol[3];

                adatok.Add(radio);
            }
        }

        private static void feladat3() 
        {
            int bejegyzesek_szama = 0;
            for (int i = 0; i < adatok.Count(); i++)
            {
                bejegyzesek_szama++;
            }

            Console.WriteLine("3. Feladat: Bejegyzések száma: {0} db", bejegyzesek_szama);
        }

        private static void feladat4() 
        {
            int index = 0;
            bool egyperc_negyadas = false;
            while (adatok[index].AdasDb != 4) 
            {
                index++;
                if (adatok[index].AdasDb == 4) 
                {
                    egyperc_negyadas = true;
                }
            }

            if (egyperc_negyadas)
            {
                Console.WriteLine("4. Feladat: Volt négy adást indító sofőr.");
            }
            else 
            {
                Console.WriteLine("4. Feladat: Nem volt négy adást indító sofőr.");
            }
        }

        private static void feladat5() 
        {
            Console.Write("5. Feladat: Kérek egy nevet: ");
            string sofor_nev = Console.ReadLine();
            bool van_ilyen_nevu = false;
            int adas_hasznalatanak_szama = 0;

            for (int i = 0; i < adatok.Count(); i++)
            {
                if (adatok[i].Nev.ToLower() == sofor_nev.ToLower())
                {
                    van_ilyen_nevu = true;
                    adas_hasznalatanak_szama += adatok[i].AdasDb;
                }
            }
            if (van_ilyen_nevu)
            {
                Console.WriteLine($"\t{sofor_nev} {adas_hasznalatanak_szama}x használta a CB-rádiót.");
            }
            else 
            {
                Console.WriteLine("\tNincs ilyen nevű sofőr!");
            }
        }

        //6. Feladat
        static int AtszamolPercre(int ora, int perc)
        {
            return (ora * 60) + perc;
        }

        private static void feladat7() 
        {
            StreamWriter irocsatorna = new StreamWriter("cb2.txt");
            irocsatorna.WriteLine("Kezdes;Nev;AdasDb");

            int kezdes_percben;
            string uj_sor;
            for (int i = 0; i < adatok.Count(); i++)
            {
                kezdes_percben = AtszamolPercre(adatok[i].Ora, adatok[i].Perc);
                uj_sor = $"{kezdes_percben};{adatok[i].Nev};{adatok[i].AdasDb}";
                irocsatorna.WriteLine(uj_sor);
            }

            irocsatorna.Close();
        }

        //------------ HASH SET-tel kellene megcsinálni ------------
        private static void feladat8() 
        {
            List<string> nevek = new List<string>();
            int soforok_szama = 0;
            bool uj_nev;

            for (int i = 0; i < adatok.Count(); i++)
            {
                uj_nev = true;

                for (int j = 0; j < nevek.Count(); j++)
                {
                    if (adatok[i].Nev == nevek[j]) 
                    {
                        uj_nev = false;
                    }
                }

                if (uj_nev) 
                {
                    nevek.Add(adatok[i].Nev);
                    soforok_szama++;
                }
            }
            Console.WriteLine($"8. Feladat: Sofőrök száma: {soforok_szama} fő");
        }

        private static void feladat9() 
        {
            List<string> nevek = new List<string>();
            List<int> ossz_adasok = new List<int>();
            bool uj_nev;

            for (int i = 0; i < adatok.Count(); i++)
            {
                uj_nev = true;

                for (int j = 0; j < nevek.Count(); j++)
                {
                    if (adatok[i].Nev == nevek[j])
                    {
                        uj_nev = false;
                        ossz_adasok[j] += adatok[i].AdasDb;
                    }
                }

                if (uj_nev)
                {
                    nevek.Add(adatok[i].Nev);
                    ossz_adasok.Add(adatok[i].AdasDb);
                }
            }

            int max_index = 0;

            for (int i = 0; i < ossz_adasok.Count(); i++)
            {
                if (ossz_adasok[i] > ossz_adasok[max_index]) 
                {
                    max_index = i;
                }
            }
            Console.WriteLine($"9. Feladat: Legtöbb adást indító sofőr\n\t" +
                $"Név: {nevek[max_index]}\n\t" +
                $"Adások száma: {ossz_adasok[max_index]} alkalom");
        }
    }
}