using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._10._26_3_UYGULAMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tekAdet = 0, ciftAdet =0;
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt32(txtbx_sayi.Text);
            if (sayi %2 == 0)
            {
                lstbx_ciftler.Items.Add(sayi);
                ciftAdet += 1;
                lbl_ciftAdet.Text = ciftAdet.ToString();
            }
            else
            {
                lstbx_tekler.Items.Add(sayi);
                tekAdet += 1;
                lbl_tekAdet.Text = tekAdet.ToString();
            }
        }
    }
}
