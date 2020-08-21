using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esdeger_Direnc_Hesaplama_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double rt;
            double r1 = Convert.ToDouble(textBoxR1.Text);
            double r2 = Convert.ToDouble(textBoxR2.Text);

            if (radioButtonSeri.Checked)
            {
                rt = r1 + r2;
            }
            else
            {
                rt = (r1 * r2) / (r1 + r2);
            }
            label3.Text = rt + "\t ohm";
        }

        private void textBoxR1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // TextBox'a karakter girişi engellendi."
        }

        private void textBoxR2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // TextBox'a karakter girişi engellendi."
        }
    }
}
