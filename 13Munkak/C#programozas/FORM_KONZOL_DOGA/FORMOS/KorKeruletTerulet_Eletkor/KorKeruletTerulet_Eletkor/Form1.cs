using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorKeruletTerulet_Eletkor
{
    public partial class Form1 : Form
    {
        static double r;
        static double  kerulet;
        static double terulet;
        static int eletkor;
        public Form1()
        {
            InitializeComponent();
        }

        private void szamol_btn_MouseClick(object sender, MouseEventArgs e)
        {
            r = double.Parse(r_tb.Text);
            kerulet = Math.Round(2 * r * Math.PI, 2);
            terulet = Math.Round(r * r * Math.PI, 2);

            kerulet_tb.Text = Convert.ToString(kerulet);
            terulet_tb.Text = Convert.ToString(terulet);
        }

        private void bekuld_btn_MouseClick(object sender, MouseEventArgs e)
        {
            eletkor = int.Parse(eletkor_tb.Text);

            if (eletkor >= 18)
            {
                MessageBox.Show("Beléphetsz!", "Felnőtt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Nem léphetsz be!", "Fiatal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
