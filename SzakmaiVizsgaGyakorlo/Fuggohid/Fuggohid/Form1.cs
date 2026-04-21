using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Fuggohid
{
    public partial class Form1 : Form
    {
        List<Fuggohid> adatok = new List<Fuggohid>();
        public Form1()
        {
            InitializeComponent();
        }

        private void kilepesBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void keresesTSM_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(adatok);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }


        private void fajlTSM_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    StreamReader olvasocsatorna = new StreamReader(ofd.FileName);
                    olvasocsatorna.ReadLine();
                    string sor;

                    while (!olvasocsatorna.EndOfStream) 
                    {
                        sor = olvasocsatorna.ReadLine();
                        Fuggohid adat = new Fuggohid(sor);
                        adatok.Add(adat);
                    }

                    olvasocsatorna.Close();
                }

                foreach (var adat in adatok)
                {
                    nevLB.Items.Add(adat.nev);
                }
            }

            catch(Exception kivetel)
            {
                MessageBox.Show("Hiba történt");
            }
        }

        private void nevLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            helyTxt.Text = adatok[nevLB.SelectedIndex].hely;
            orszagTxt.Text = adatok[nevLB.SelectedIndex].orszag;
            hosszTxt.Text = adatok[nevLB.SelectedIndex].hossz.ToString();
            evTxt.Text = adatok[nevLB.SelectedIndex].ev.ToString();
        }

        private void kettoElottRB_CheckedChanged(object sender, EventArgs e)
        {
            int kettoElotti = 0;
            if (kettoElottRB.Checked == true) 
            {
                nevLB.Items.Clear();
                foreach (var adat in adatok)
                {
                    if (adat.ev < 2000) 
                    {
                        nevLB.Items.Add(adat.nev);
                        kettoElotti++;
                    }
                }

                darabTxt.Text = kettoElotti.ToString();
            }
        }

        private void kettobenRB_CheckedChanged(object sender, EventArgs e)
        {
            int kettoUtani = 0;
            if (kettobenRB.Checked == true)
            {
                nevLB.Items.Clear();
                foreach (var adat in adatok)
                {
                    if (adat.ev >= 2000)
                    {
                        nevLB.Items.Add(adat.nev);
                        kettoUtani++;
                    }
                }

                darabTxt.Text = kettoUtani.ToString();
            }
        }
    }
}
