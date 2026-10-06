using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._10._26_2_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string username, password;
            username = txt_username.Text;
            password = txt_password.Text;
            if (username == "Barbaros" && password == "1973")
            {
                lbl_mesaj.Text = "BAŞARILI GİRİŞ!";
            }
            else if (username != "Barbaros")
            {
                lbl_mesaj.Text = " HATALI İSİM!";
            }
            else if (password != "1973")
            {
                lbl_mesaj.Text = " HATALI ŞİFRE!";
            }
            
        }
    }
}
