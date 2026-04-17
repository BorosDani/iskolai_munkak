using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalapacsvetes
{
    public class Sportolo
    {
        public int helyezes;
        public double eredmeny;
        public string sportolo;
        public string orszagKod;
        public string helyszin;
        public string datum;

        public Sportolo(string sor)
        {
            string[] darabol;
            darabol = sor.Split(';');

            this.helyezes = Convert.ToInt32(darabol[0]);
            this.eredmeny = Convert.ToDouble(darabol[1]);
            this.sportolo = darabol[2];
            this.orszagKod = darabol[3];
            this.helyszin = darabol[4];
            this.datum = darabol[5];
        }
    }
}
