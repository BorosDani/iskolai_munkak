using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ugralo_form
{
    public partial class Form1 : Form
    {
        static int x = Screen.PrimaryScreen.Bounds.Width; //Képernyő szélesség
        static int y = Screen.PrimaryScreen.Bounds.Height; //Képernyő magasság
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Location = new Point(x - x, y - y);
            //Location = new Point(0, 0);
        }

        private void jobbfelso_btn_Click(object sender, EventArgs e)
        {
            Location = new Point(x - Width, y - y);
            //Location = new Point(kep_szelesseg - Width, 0);
        }

        private void balalso_btn_Click(object sender, EventArgs e)
        {
            Location = new Point(x - x, y - Height);
            //Location = new Point(0, kep_magassag - Height);
        }

        private void jobbalso_btn_Click(object sender, EventArgs e)
        {
            Location = new Point(x - Width, y - Height);
        }

        private void kozepso_btn_Click(object sender, EventArgs e)
        {
            Location = new Point((x - Width) / 2, (y - Height) / 2);
        }
    }
}
