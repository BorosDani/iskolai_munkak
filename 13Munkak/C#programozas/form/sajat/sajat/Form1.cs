using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sajat
{
    public partial class Form1 : Form
    {
        static int pontok_szama = 0;
        static Random rnd_pizicio = new Random();

        static int rnd_x;
        static int rnd_y;

        static bool megnyomott = false;
        public Form1()
        {
            InitializeComponent();
            pont_lbl.Text = $"Pont: {pontok_szama}";
            pont_poz_Lbl.Text = $"Pont pozíciója: {point_btn.Location}";
            karakter_position_Lbl.Text = $"Karakter pozíciója: {karakter_btn.Location}";

            rnd_x = rnd_pizicio.Next(100, 300);
            rnd_y = rnd_pizicio.Next(100, 300);
            point_btn.Location = new Point(rnd_x, rnd_y);
        }

        private void karakter_btn_OnKeyUp(object sender, KeyEventArgs e)
        {
            if (karakter_btn.Visible)
            {
                if (this.ClientSize.Width - karakter_btn.Width > karakter_btn.Location.X && this.ClientSize.Height - karakter_btn.Height > karakter_btn.Location.Y && karakter_btn.Location.X > 0 && karakter_btn.Location.Y > 0)
                {
                    if (e.KeyCode == Keys.Right)
                    {
                        karakter_btn.Location = new Point(karakter_btn.Location.X + 30, karakter_btn.Location.Y);
                    }
                    if (e.KeyCode == Keys.Left)
                    {
                        karakter_btn.Location = new Point(karakter_btn.Location.X - 30, karakter_btn.Location.Y);
                    }
                    if (e.KeyCode == Keys.Up)
                    {
                        karakter_btn.Location = new Point(karakter_btn.Location.X, karakter_btn.Location.Y - 30);
                    }
                    if (e.KeyCode == Keys.Down)
                    {
                        karakter_btn.Location = new Point(karakter_btn.Location.X, karakter_btn.Location.Y + 30);
                    }
                }


                if (this.ClientSize.Width - karakter_btn.Width < karakter_btn.Location.X)
                {
                    karakter_btn.Location = new Point(karakter_btn.Location.X - 30, karakter_btn.Location.Y);
                }
                else if (karakter_btn.Location.X < 0)
                {
                    karakter_btn.Location = new Point(karakter_btn.Location.X + 30, karakter_btn.Location.Y);
                }


                if (this.ClientSize.Height - karakter_btn.Height < karakter_btn.Location.Y)
                {
                    karakter_btn.Location = new Point(karakter_btn.Location.X, karakter_btn.Location.Y - 30);
                }
                else if (karakter_btn.Location.Y < 0)
                {
                    karakter_btn.Location = new Point(karakter_btn.Location.X, karakter_btn.Location.Y + 30);
                }
            }
        }
        private void point_btn_Move(object sender, EventArgs e)
        {
            pont_poz_Lbl.Text = $"Pont pozíciója: {point_btn.Location}";
        }

        private void karakter_btn_Move(object sender, EventArgs e)
        {
            karakter_position_Lbl.Text = $"Karakter pozíciója: {karakter_btn.Location}";
            /*
            if (karakter_btn.Location.Y == point_btn.Location.Y && karakter_btn.Location.X == point_btn.Location.X || karakter_btn.Location.Y == point_btn.Location.Y && karakter_btn.Location.X == point_btn.Location.X - 30)
            {
                pontok_szama++;
                pont_lbl.Text = $"Pont: {pontok_szama}";
                point_btn.Location = new Point(rnd_x, rnd_y);
            }
            */
            if (karakter_btn.Location.Y - point_btn.Location.Y <= 15 && karakter_btn.Location.Y - point_btn.Location.Y >= -15 && karakter_btn.Location.X - point_btn.Location.X <= 15 && karakter_btn.Location.X - point_btn.Location.X >= -15)
            {
                pontok_szama++;
                pont_lbl.Text = $"Pont: {pontok_szama}";

                rnd_x = rnd_pizicio.Next(100, 300);
                rnd_y = rnd_pizicio.Next(100, 300);
                point_btn.Location = new Point(rnd_x, rnd_y);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && !megnyomott)
            {
                kilepes_btn.Visible = true;
                reset_btn.Visible = true;
                megnyomott = true;
                karakter_btn.Visible = false;
                point_btn.Visible = false;
                pont_lbl.Visible = false;

                info_lbl.Visible = true;
                info_lbl.Location = new Point(150, 80);
                info_lbl.Text = "Nyomj ESC-t a játék folytatásához";
            }
            else if(e.KeyCode == Keys.Escape && megnyomott)
            {
                kilepes_btn.Visible = false;
                reset_btn.Visible = false;
                karakter_position_Lbl.Visible = false;
                pont_poz_Lbl.Visible = false;
                megnyomott = false;
                karakter_btn.Visible = true;
                point_btn.Visible = true;
                pont_lbl.Visible = true;
                info_lbl.Visible = true;

                info_lbl.Text = "( i ) információ";
                info_lbl.Location = new Point(399, 31);
            }

            if (e.KeyCode == Keys.I && !megnyomott) 
            {
                kilepes_btn.Visible = false;
                reset_btn.Visible = false;
                megnyomott = true;
                karakter_btn.Visible = false;
                point_btn.Visible = false;
                pont_lbl.Visible = false;

                info_lbl.Text = "- A játéknak a lényege arról szól hogy pontot kell szerezned a karaktereddel." +
                    "\n- A pontok a kis szürke kockák." +
                    "\n- Jobb felső sarokban láthatod a pontjaid számát." +
                    "\n- Az ESC gombbal továbbá kitudsz lépni a játékból." +
                    "\n\n\n\n\n\n\n\n\n\n\n\nNYOMJ ESC-t A FOLYTATÁSHOZ";
                info_lbl.Location = new Point(100, 100);
            }

            if (e.KeyCode == Keys.K && !megnyomott) 
            {
                kilepes_btn.Visible = false;
                megnyomott = true;
                karakter_position_Lbl.Visible = true;
                pont_poz_Lbl.Visible = true;
            }
        }

        private void kilepes_btn_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void reset_btn_MouseClick(object sender, MouseEventArgs e)
        {
            pontok_szama = 0;
            pont_lbl.Text = $"Pont: {pontok_szama}";
            rnd_x = rnd_pizicio.Next(100, 300);
            rnd_y = rnd_pizicio.Next(100, 300);
            point_btn.Location = new Point(rnd_x, rnd_y);
            karakter_btn.Location = new Point(10, 10);

            kilepes_btn.Visible = false;
            reset_btn.Visible = false;
            megnyomott = true;
            karakter_btn.Visible = true;
            point_btn.Visible = true;
            pont_lbl.Visible = true;

            info_lbl.Visible = false;
        }
    }
}
