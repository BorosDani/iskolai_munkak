using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teglalap_terulete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void szamitas_btn_MouseClick(object sender, MouseEventArgs e)
        {
            double terulet = double.Parse(aOldalTxt.Text) * double.Parse(bOldalTxt.Text);
            double kerulet = (double.Parse(aOldalTxt.Text) * 2) + (double.Parse(bOldalTxt.Text) * 2);
            teruletLbl.Text = Convert.ToString(terulet);
            MessageBox.Show($"Kerület: {kerulet}", "Kerület számítás", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
