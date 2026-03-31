using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hopp_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hopp_btn_MouseClick(object sender, MouseEventArgs e)
        {
            if (Convert.ToInt32(xKoordTxt.Text) > this.ClientSize.Width - hopp_btn.Width || Convert.ToInt32(yKoordTxt.Text) > this.ClientSize.Height - hopp_btn.Height)
            {
                hopp_btn.Location = new Point(this.ClientSize.Width - hopp_btn.Width, this.ClientSize.Height - hopp_btn.Height); //Tovább gondolt
                xKoordTxt.Text = Convert.ToString(this.ClientSize.Width - hopp_btn.Width); //Tovább gondolt
                yKoordTxt.Text = Convert.ToString(this.ClientSize.Height - hopp_btn.Height); //Tovább gondolt
                MessageBox.Show("Nincs a gomb a látóhatáron belül!", "Határon kívűl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                hopp_btn.Location = new Point(Convert.ToInt32(xKoordTxt.Text), Convert.ToInt32(yKoordTxt.Text));
            }
        }
    }
}
