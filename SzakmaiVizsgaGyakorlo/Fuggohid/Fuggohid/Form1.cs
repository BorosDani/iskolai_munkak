using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO

namespace Fuggohid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            beolvas();
        }

        private static void beolvas() 
        {
        }

        private void kilepesBtn_Click(object sender, EventArgs e)
        {
            Close();
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

                    }

                    olvasocsatorna.Close();
                }
            }

            catch(Exception kivetel)
            {
                MessageBox.Show("Hiba történt");
            }
        }
    }
}
