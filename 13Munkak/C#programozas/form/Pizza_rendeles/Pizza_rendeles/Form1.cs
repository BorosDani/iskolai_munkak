using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_rendeles
{
    public partial class Form1 : Form
    {
        static int ossz_ar = 0;
        static string rendeles_reszlet;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int form_poz_x = (Screen.PrimaryScreen.Bounds.Width - Width) / 2;
            int form_poz_y = (Screen.PrimaryScreen.Bounds.Height - Height) / 2;
            Location = new Point(form_poz_x, form_poz_y);
        }

        private void PizzaRendeles_btn_MouseClick(object sender, MouseEventArgs e)
        {
            if (MeretKozepes_rbtn.Checked)
            {
                rendeles_reszlet += "- Közepes méretű (2500Ft)";
                ossz_ar += 2500;
            }
            else
            {
                rendeles_reszlet += "- Családi méretű (3000Ft)";
                ossz_ar += 3000;
            }


            if (FeltetKukorica_cb.Checked)
            {
                ossz_ar += 200;
                rendeles_reszlet += "\n\t- Kukorica feltét (+200Ft)";
            }
            if (FeltetOliva_cb.Checked)
            {
                ossz_ar += 150;
                rendeles_reszlet += "\n\t- Oliva bogyó feltét (+150Ft)";
            }
            if (FeltetGomba_cb.Checked)
            {
                ossz_ar += 100;
                rendeles_reszlet += "\n\t- Gomba feltét (+100Ft)";
            }
            if (FeltetExSajt_cb.Checked)
            {
                ossz_ar += 250;
                rendeles_reszlet += "\n\t- Extra sajt feltét (+250Ft)";
            }
            if (FeltetPepperoni_cb.Checked)
            {
                ossz_ar += 200;
                rendeles_reszlet += "\n\t- Pepperoni feltét (+200Ft)";
            }

            RendelesMegt_gb.Visible = true;
            PizzaTul_gb.Visible = false;

            RendelesMegt_gb.Location = new Point(PizzaTul_gb.Location.X, PizzaTul_gb.Location.Y);
            RendelesMegt_gb.Size = new Size(PizzaTul_gb.Width, PizzaTul_gb.Height);
            RMVissza_btn.Location = new Point(PizzaRendeles_btn.Location.X, PizzaRendeles_btn.Location.Y);
            RMrendeles_btn.Location = new Point(PizzaRendeles_btn.Location.X + 100, PizzaRendeles_btn.Location.Y);

            RendelesMegtekintes_lbl.Font = new Font(RendelesMegtekintes_lbl.Font, FontStyle.Regular);
            Ar_lbl.Text = $"Ára: {ossz_ar}Ft";
            RendelesMegtekintes_lbl.Text = "Rendelés megtekintése:\n\n" + rendeles_reszlet;
        }

        private void RMVissza_btn_MouseClick(object sender, MouseEventArgs e)
        {
            ossz_ar = 0;
            rendeles_reszlet = "";
            RendelesMegt_gb.Visible = false;
            PizzaTul_gb.Visible = true;
            RMrendeles_btn.Enabled = true;
        }

        private void RMrendeles_btn_MouseClick(object sender, MouseEventArgs e)
        {
            Ar_lbl.Visible = false;
            RendelesMegtekintes_lbl.Font = new Font(RendelesMegtekintes_lbl.Font, FontStyle.Bold);
            RendelesMegtekintes_lbl.Text = "Rendelését készítjük!";
            MessageBox.Show($"Megkaptuk rendelésed!\nÁra: {ossz_ar}", "Rendelés", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RMVissza_btn.Enabled = false;
            RMrendeles_btn.Enabled = false;
            Task.Delay(3000).Wait();
            RMVissza_btn.Enabled = true;

            RendelesMegtekintes_lbl.Text = "Rendelésed elkészült, futárunk úton van!";
        }
    }
}