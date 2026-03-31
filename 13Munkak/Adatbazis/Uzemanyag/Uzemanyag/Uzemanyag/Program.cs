using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Feladat
namespace Uzemanyag
{
    class Program
    {
        static void Main(string[] args)
        {
            uzemanyag();
            Console.ReadLine();
        }
        //30
        private static void uzemanyag() 
        {
            feladat2();
            feladat3();
            Console.WriteLine("\n");
            feladat4();
            Console.WriteLine("\n");
            feladat5();
            Console.WriteLine("\n");
            feladat6();
            feladat7();
            Console.WriteLine("\n");
            feladat8();
            // 9, 10 FELADAT NINCS KÉSZ
            Console.WriteLine("\n");
            feladat10();
        }

        struct UzemanyagStruktura 
        {
            public string Datum;
            public int BenzinAtlag;
            public int GazolajAtlag;
        }

        static List<UzemanyagStruktura> adatok = new List<UzemanyagStruktura>();

        private static void feladat2() 
        {
            StreamReader olvasocsatorna = new StreamReader("uzemanyag.txt");
            string sor;
            string[] darabol;

            while (!olvasocsatorna.EndOfStream) 
            {
                sor = olvasocsatorna.ReadLine();
                darabol = sor.Split(';');

                UzemanyagStruktura uzemanyagadat = new UzemanyagStruktura();

                uzemanyagadat.Datum = darabol[0];
                uzemanyagadat.BenzinAtlag = int.Parse(darabol[1]);
                uzemanyagadat.GazolajAtlag = int.Parse(darabol[2]);

                adatok.Add(uzemanyagadat);
            }
        }

        private static void feladat3() 
        {
            Console.WriteLine($"3. Feladat: Változások száma: {adatok.Count()}");
        }

        static int legkisebb_kulonbseg = int.MaxValue;
        private static void feladat4() 
        {
            int kulonbseg = int.MaxValue;

            for (int i = 0; i < adatok.Count(); i++)
            {
                if (adatok[i].BenzinAtlag > adatok[i].GazolajAtlag)
                {
                    kulonbseg = adatok[i].BenzinAtlag - adatok[i].GazolajAtlag;
                }
                else if (adatok[i].GazolajAtlag > adatok[i].BenzinAtlag)
                {
                    kulonbseg = adatok[i].GazolajAtlag - adatok[i].BenzinAtlag;
                }
                else 
                {
                    kulonbseg = adatok[i].GazolajAtlag - adatok[i].BenzinAtlag;
                }

                if (kulonbseg < legkisebb_kulonbseg) 
                {
                    legkisebb_kulonbseg = kulonbseg;
                }
            }

            Console.WriteLine($"4. Feladat: A legkisebb különbség: {legkisebb_kulonbseg}");
        }

        private static void feladat5() 
        {
            int legkisebb_elofordulasa = 0;

            for (int i = 0; i < adatok.Count(); i++)
            {
                if (adatok[i].BenzinAtlag - adatok[i].GazolajAtlag == 0 || adatok[i].GazolajAtlag - adatok[i].BenzinAtlag == 0) 
                {
                    legkisebb_elofordulasa++;
                }
            }
            Console.WriteLine($"5. Feladat: A legkisebb különbség előfordulása: {legkisebb_elofordulasa}");
        }

        private static void feladat6() 
        {
            string[] datum_darabolas;
            bool szokoev_e = false;

            for (int i = 0; i < adatok.Count(); i++)
            {
                datum_darabolas = adatok[i].Datum.Split('.');
                for (int j = 0; j < datum_darabolas.Length; j++)
                {
                    if (int.Parse(datum_darabolas[0]) % 4 == 0 && adatok[i].BenzinAtlag - adatok[i].GazolajAtlag > 0 || adatok[i].GazolajAtlag - adatok[i].BenzinAtlag > 0) 
                    {
                        szokoev_e = true;
                    }
                }
            }

            if (szokoev_e) 
            {
                Console.WriteLine($"6. Feladat: Volt változás szökőnapon!");
            }
        }

        private static void feladat7() 
        {
            StreamWriter irocsatorna = new StreamWriter("euro.txt");

            double benzin_euro;
            double gazolaj_euro;

            for (int i = 0; i < adatok.Count(); i++)
            {
                benzin_euro = Math.Round(adatok[i].BenzinAtlag / 307.7, 2);
                gazolaj_euro = Math.Round(adatok[i].GazolajAtlag / 307.7, 2);

                irocsatorna.WriteLine($"{adatok[i].Datum};{benzin_euro};{gazolaj_euro}");
            }
        }

        private static void feladat8() 
        {
            Console.Write("8. Feladat: Kérem adja meg az évszámot [2011..2016]: ");
            int evszam_megadas = Convert.ToInt32(Console.ReadLine());

            while (evszam_megadas >= 2016 || evszam_megadas <= 2011)
            {
                Console.Write("8. Feladat: Kérem adja meg az évszámot [2011..2016]: ");
                evszam_megadas = Convert.ToInt32(Console.ReadLine());
            }
        }

        //9. Feladat NINCS KÉSZ
        static int ArvaltozasKozottElteltNapok(string aktualis_adatok) 
        {
            string[] datum_feldarabolas = adatok[0].Datum.Split('.');
            string jelenlegi_nap = datum_feldarabolas[0];
            int[] napokSzama = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int eltelt_napok_szama = 0;

            for (int i = 1; i < adatok.Count(); i++)
            {
                datum_feldarabolas = adatok[i].Datum.Split('.');
                for (int j = 0; j < datum_feldarabolas.Length; j++)
                {
                    if (int.Parse(datum_feldarabolas[2]) > int.Parse(jelenlegi_nap)) 
                    {
                        eltelt_napok_szama++;
                    }
                }
            }

            return eltelt_napok_szama;
        }

        //10. Feladat NINCS KÉSZ
        private static void feladat10() 
        {
            Console.WriteLine(ArvaltozasKozottElteltNapok(adatok[0].Datum));
        }
    }
}
