using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._10._26_4_UYGULAMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {

            int sayi1 = Convert.ToInt32(txt_sayi1.Text);
            int sayi2 = Convert.ToInt32(txt_sayi2.Text);
            int sonuc;
            if (rdb_toplama.Checked == true) 
            {
                sonuc = (sayi1 + sayi2);
                lbl_sonuc.Text = Convert.ToString(sonuc);
            }
            else if (rdb_cikarma.Checked == true) 
            {
                sonuc = (sayi1 - sayi2);
                lbl_sonuc.Text = Convert.ToString(sonuc);
            }
            else if(rdb_carpma.Checked==true)
            {
                sonuc = (sayi1 * sayi2);
                lbl_sonuc.Text = Convert.ToString(sonuc);

            }
            else if (rdb_bolme.Checked==true)
            {
                sonuc = (sayi1 / sayi2);
                lbl_sonuc.Text = Convert.ToString(sonuc);
            }
           

        }
    }
}
