using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace footgolf
{
    class Program
    {
        static void Main(string[] args)
        {
            footgolf();
            Console.ReadLine();
        }

        private static void footgolf() 
        {
            feladat2();
            feladat3();
            Console.WriteLine("\n");
            feladat4();
            Console.WriteLine("\n");
            feladat6();
            feladat7();
            Console.WriteLine("\n");
            feladat8();
        }

        struct FootgolfStruktura 
        {
            public string Nev;
            public string Kategoria;
            public string EgyesuletNev;
            //public string Pontok; RÉGI
            public byte[] Pontszamok; //(Vagy így is lehet)
        }
        static List<FootgolfStruktura> adatok = new List<FootgolfStruktura>();

        private static void feladat2() 
        {
            StreamReader olvasocsatorna = new StreamReader("fob2016.txt");
            string sor;

            string[] darabol;

            while (!olvasocsatorna.EndOfStream) 
            {
                sor = olvasocsatorna.ReadLine();
                darabol = sor.Split(';');

                FootgolfStruktura golf = new FootgolfStruktura();

                golf.Nev = darabol[0];
                golf.Kategoria = darabol[1];
                golf.EgyesuletNev = darabol[2];
                /*RÉGI
                golf.Pontok = darabol[3] + ";" + darabol[4] + ";" + darabol[5] 
                    + ";" + darabol[6] + ";" + darabol[7] + ";" 
                    + darabol[8] + ";" + darabol[9] + ";" + darabol[10];
                */

                golf.Pontszamok = new byte[8];

                for (int i = 0; i < golf.Pontszamok.Length; i++)
                {
                    golf.Pontszamok[i] = byte.Parse(darabol[3 + i]);
                }

                adatok.Add(golf);
            }
            olvasocsatorna.Close();
        }

        private static void feladat3() 
        {
            Console.WriteLine($"3. Feladat: Versenyzők száma: {adatok.Count()}");
        }

        private static void feladat4() 
        {
            double noi_versenyzok_szama = 0;

            for (int i = 0; i < adatok.Count(); i++)
            {
                if (adatok[i].Kategoria == "Noi")
                {
                    noi_versenyzok_szama++;
                }
            }
            Console.WriteLine($"4. Feladat: A női versenyzők aránya: {Math.Round((noi_versenyzok_szama / adatok.Count()) * 100, 2)}%");
        }

        //5. Feladat
        static int Osszpontszam(byte[] osszegzettpontszamok)
        {
            byte[] egyeni_pontszamok = osszegzettpontszamok;

            int elso_legkisebb = egyeni_pontszamok[0];
            int masodik_legkisebb = int.MaxValue;
            int elso_legkisebb_i = 0;
            int masodik_legkisebb_i = -1;

            int osszeg = 0;

            for (int i = 1; i < egyeni_pontszamok.Length; i++)
            {
                if (egyeni_pontszamok[i] < elso_legkisebb)
                {
                    masodik_legkisebb = elso_legkisebb;
                    masodik_legkisebb_i = elso_legkisebb_i;

                    elso_legkisebb = egyeni_pontszamok[i];
                    elso_legkisebb_i = i;
                }
                else if (egyeni_pontszamok[i] < masodik_legkisebb)
                {
                    masodik_legkisebb = egyeni_pontszamok[i];
                    masodik_legkisebb_i = i;
                }
            }

            for (int i = 0; i < egyeni_pontszamok.Length; i++)
            {
                if (i == elso_legkisebb_i)
                {
                    if (elso_legkisebb != 0)
                    {
                        osszeg += 10;
                    }
                }
                else if (i == masodik_legkisebb_i)
                {
                    if (masodik_legkisebb != 0)
                    {
                        osszeg += 10;
                    }
                }
                else
                {
                    osszeg += egyeni_pontszamok[i];
                }
            }

            //string elso_masodik_legkisebb = $"{elso_legkisebb_i}, {elso_legkisebb}\t{masodik_legkisebb_i}, {masodik_legkisebb}\t{osszeg}"; Ellenőrzés
            return osszeg;
        }

        private static void feladat6() 
        {
            string nev = adatok[0].Nev;
            string egyesulet = adatok[0].EgyesuletNev;
            int legjobb_osszpont = Osszpontszam(adatok[0].Pontszamok);

            for (int i = 0; i < adatok.Count(); i++)
            {
                if (Osszpontszam(adatok[i].Pontszamok) > legjobb_osszpont && adatok[i].Kategoria == "Noi") 
                {
                    legjobb_osszpont = Osszpontszam(adatok[i].Pontszamok);
                    nev = adatok[i].Nev;
                    egyesulet = adatok[i].EgyesuletNev;
                }
            }

            Console.WriteLine($"6. Feladat: A bajnok női versenyző\n\tNév: {nev}\n\tEgyesület: {egyesulet}\n\tÖsszpont: {legjobb_osszpont}");
        }

        private static void feladat7() 
        {
            StreamWriter irocsatorna = new StreamWriter("osszpontFF.txt");

            for (int i = 0; i < adatok.Count(); i++)
            {
                if (adatok[i].Kategoria == "Felnott ferfi") 
                {
                    irocsatorna.WriteLine($"{adatok[i].Nev};{Osszpontszam(adatok[i].Pontszamok)}");
                }
            }

            irocsatorna .Close();
        }

        private static void feladat8() 
        {
            List<string> egyesuletek = new List<string>();
            List<int> tagok_szama = new List<int>();
            bool uj_egyesulet = false;

            for (int i = 0; i < adatok.Count(); i++)
            {
                uj_egyesulet = true;

                for (int j = 0; j < egyesuletek.Count(); j++)
                {
                    if (adatok[i].EgyesuletNev == egyesuletek[j] && adatok[i].EgyesuletNev != "n.a.") 
                    {
                        uj_egyesulet = false;
                        tagok_szama[j] += 1;
                    }
                }

                if (uj_egyesulet) 
                {
                    egyesuletek.Add(adatok[i].EgyesuletNev);
                    tagok_szama.Add(1);
                }
            }

            Console.WriteLine("8. Feladat: Egyesület statisztika");
            for (int i = 0; i < egyesuletek.Count(); i++)
            {
                if (tagok_szama[i] >= 3) 
                {
                    Console.WriteLine($"\t{egyesuletek[i]} - {tagok_szama[i]} fő");
                }
            }
        }
    }
}