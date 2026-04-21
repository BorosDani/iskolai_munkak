using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuggohid
{
    public partial class Form2 : Form
    {
        List<Fuggohid> adatok = new List<Fuggohid>();
        public Form2(List<Fuggohid> lista)
        {
            InitializeComponent();
            for (int i = 0; i < lista.Count; i++)
            {
                adatok.Add(lista[i]);
            }

            var orszagok = adatok.GroupBy(a => a.orszag);
            foreach (var adat in orszagok)
            {
                orszagCB.Items.Add(adat.Key);
            }
        }

        private void bezarBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void keresesBtn_Click(object sender, EventArgs e)
        {
            nevLB.Items.Clear();

            if (egyKmHosszabbCBx.Checked == false)
            {
                for (int i = 0; i < adatok.Count; i++)
                {
                    if (adatok[i].orszag == orszagCB.SelectedItem.ToString())
                    {
                        nevLB.Items.Add(adatok[i].nev);
                    }
                }
            }

            else 
            {
                for (int i = 0; i < adatok.Count; i++)
                {
                    if (adatok[i].orszag == orszagCB.SelectedItem.ToString() && adatok[i].hossz > 1000)
                    {
                        nevLB.Items.Add(adatok[i].nev);
                    }
                }
            }
        }
    }
}
