using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05._10._26_1_uyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_karsilastir_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            sayi1 = Convert.ToInt32(txt_sayi1.Text);
            sayi2 = Convert.ToInt32(txt_sayi2.Text);
            if (sayi1 > sayi2)
            {
                lbl_sonuc.Text = Convert.ToString(sayi1) + " BÜYÜKTÜR";
            }
            else if (sayi2 > sayi1)
            {
                lbl_sonuc.Text = Convert.ToString(sayi2) + " BÜYÜKTÜR";
            }
        }
    }
}
