using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._10._26_2_UYGULAMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_enbuyuk_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sayi3;
            sayi1 = Convert.ToInt32(txtbx_sayi1.Text);
            sayi2 = Convert.ToInt32(txtbx_sayi2.Text);
            sayi3 = Convert.ToInt32(txtbx_sayi3.Text);
            if (sayi1>sayi2 && sayi1>sayi3)
            {
                lbl_sonuc.Text = sayi1.ToString() + " EN BÜYÜKTÜR";
            }
            else if (sayi2>sayi3 && sayi2>sayi1)
            {
                lbl_sonuc.Text = sayi2.ToString() + " EN BÜYÜKTÜR";
            }
            else if (sayi3>sayi1 && sayi3>sayi2)
            {
                lbl_sonuc.Text = sayi3.ToString() + " EN BÜYÜKTÜR";
            }
        }

        private void btn_enkucuk_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sayi3;
            sayi1 = Convert.ToInt32(txtbx_sayi1.Text);
            sayi2 = Convert.ToInt32(txtbx_sayi2.Text);
            sayi3 = Convert.ToInt32(txtbx_sayi3.Text);
            if (sayi1 < sayi2 && sayi1 < sayi3)
            {
                lbl_sonuc.Text = sayi1.ToString() + " EN KÜÇÜKTÜR";
            }
            else if (sayi2 < sayi3 && sayi2 < sayi1)
            {
                lbl_sonuc.Text = sayi2.ToString() + " EN KÜÇÜKTÜR";
            }
            else if (sayi3 < sayi1 && sayi3 < sayi2)
            {
                lbl_sonuc.Text = sayi3.ToString() + " EN KÜÇÜKTÜR";
            }
        }
    }
}
