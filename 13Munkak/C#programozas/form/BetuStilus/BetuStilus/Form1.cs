using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetuStilus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            cimke_lbl.ForeColor = Color.Red;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            cimke_lbl.ForeColor = Color.FromArgb(0,0,255);
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            cimke_lbl.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            float betumeret = 10;

            cimke_lbl.Font = new Font(cimke_lbl.Font.Name, betumeret, cimke_lbl.Font.Style);
        }

        private void tizenegy_rb_CheckedChanged(object sender, EventArgs e)
        {
            float betumeret = 11;

            cimke_lbl.Font = new Font(cimke_lbl.Font.Name, betumeret, cimke_lbl.Font.Style);
        }

        private void tizenketto_rb_CheckedChanged(object sender, EventArgs e)
        {
            float betumeret = 12;

            cimke_lbl.Font = new Font(cimke_lbl.Font.Name, betumeret, cimke_lbl.Font.Style);
        }

        private void tizennegy_rb_CheckedChanged(object sender, EventArgs e)
        {
            float betumeret = 14;

            cimke_lbl.Font = new Font(cimke_lbl.Font.Name, betumeret, cimke_lbl.Font.Style);
        }

        private void tizenhat_rb_CheckedChanged(object sender, EventArgs e)
        {
            float betumeret = 16;

            cimke_lbl.Font = new Font(cimke_lbl.Font.Name, betumeret, cimke_lbl.Font.Style);
        }

        private void tizennyolc_rb_CheckedChanged(object sender, EventArgs e)
        {
            float betumeret = 18;

            cimke_lbl.Font = new Font(cimke_lbl.Font.Name, betumeret, cimke_lbl.Font.Style);
        }



        private void felkover_cb_CheckedChanged(object sender, EventArgs e)
        {
            
            if (!felkover_cb.Checked)
            {
                cimke_lbl.Font = new Font(cimke_lbl.Font, cimke_lbl.Font.Style ^ FontStyle.Bold);
            }

            else 
            {
                cimke_lbl.Font = new Font(cimke_lbl.Font, cimke_lbl.Font.Style | FontStyle.Bold);
            }
        }

        private void dolt_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (!dolt_cb.Checked)
            {
                cimke_lbl.Font = new Font(cimke_lbl.Font, cimke_lbl.Font.Style ^ FontStyle.Italic);
            }

            else 
            {
                cimke_lbl.Font = new Font(cimke_lbl.Font, cimke_lbl.Font.Style | FontStyle.Italic);
            }
        }

        private void alahuzott_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (!alahuzott_cb.Checked)
            {
                cimke_lbl.Font = new Font(cimke_lbl.Font, cimke_lbl.Font.Style ^ FontStyle.Underline);
            }

            else 
            {
                cimke_lbl.Font = new Font(cimke_lbl.Font, cimke_lbl.Font.Style | FontStyle.Underline);
            }
        }

        private void athuzott_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (!athuzott_cb.Checked)
            {
                cimke_lbl.Font = new Font(cimke_lbl.Font, cimke_lbl.Font.Style ^ FontStyle.Strikeout);
            }

            else 
            {
                cimke_lbl.Font = new Font(cimke_lbl.Font, cimke_lbl.Font.Style | FontStyle.Strikeout);
            }
        }
    }
}
