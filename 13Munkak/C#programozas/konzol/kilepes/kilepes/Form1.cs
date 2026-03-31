using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kilepes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            ControlBox = false;
        }

        private void kilepes_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            Text = "Belépett";
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            Text = "Kilépett";
        }
    }
}
