using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._10._26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_kontrol_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi=  Convert.ToInt32(txtbx_sayi.Text);
            if (sayi < 10 && sayi>=0) 
            {
                lbl_sonuc.Text = "1 basamaklı";
            }
            else if (sayi >= 10 && sayi < 100)
            {
                lbl_sonuc.Text = "2 basamaklı";
            }
            else if (sayi >= 100 && sayi <= 999) 
            {
                lbl_sonuc.Text = "3 basamaklı";
            }
            else if (sayi >=1000 && sayi <= 9999) 
            {
                lbl_sonuc.Text = "4 basamaklı";
            }

        }
    }
}
