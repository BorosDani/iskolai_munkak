using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gyakorlo_bevezeto_feladatok
{
    public partial class Form1 : Form
    {
        static Point ugras_btn_x;
        static bool megnyomott = false;
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            ugras_btn_x = ugras_btn.Location;
        }

        private void Eltunes_btn_MouseEnter(object sender, EventArgs e)
        {
            Eltunes_btn.Visible = false;
        }

        private void Eltunes_btn_MouseLeave(object sender, EventArgs e) 
        {
            Eltunes_btn.Visible = true;
        }



        private void lathatatlan_btn_MouseClick(object sender, MouseEventArgs e)
        {
            if (!inaktiv_btn.Visible)
            {
                inaktiv_btn.Visible = true;
            }
            else 
            {
                inaktiv_btn.Visible = false;
            }
        }

        private void inaktiv_btn_MouseClick(object sender, MouseEventArgs e)
        {
            if (!lathatatlan_btn.Enabled)
            {
                lathatatlan_btn.Enabled = true;
            }
            else 
            {
                lathatatlan_btn.Enabled = false;
            }
        }



        private void ugras_btn_MouseClick(object sender, MouseEventArgs e)
        {
            if (!megnyomott)
            {
                megnyomott = true;
                ugras_btn.Location = new Point(0, 0);
            }
            else 
            {
                megnyomott = false;
                ugras_btn.Location = new Point(ugras_btn_x.X, ugras_btn_x.Y);
                MessageBox.Show("Sikerült!", "Ügyes vagy", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void xy_MouseMove(object sender, MouseEventArgs e)
        {
            xy.Text = $"X: {e.X}, Y: {e.Y}";
        }



        private void kilepes_btn_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }
    }
}
