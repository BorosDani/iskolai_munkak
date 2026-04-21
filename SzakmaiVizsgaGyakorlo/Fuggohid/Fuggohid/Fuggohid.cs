using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuggohid
{
    class Fuggohid
    {
        public int helyezes;
        public string nev;
        public string hely;
        public string orszag;
        public int hossz;
        public int ev;

        public Fuggohid(string sor)
        {
            string[] darabol = sor.Split('\t');

            this.helyezes = Convert.ToInt32(darabol[0]);
            this.nev = darabol[1];
            this.hely = darabol[2];
            this.orszag = darabol[3];
            this.hossz = Convert.ToInt32(darabol[4]);
            this.ev = Convert.ToInt32(darabol[5]);

            
        }
    }
}
