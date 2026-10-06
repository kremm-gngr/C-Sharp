using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._10._26_3_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sistemKontrol_Click(object sender, EventArgs e)
        {
            if (chckBx_lamba.Checked==true)
            {
                lstBx_sistemRaporu.Items.Add("lambalar açık");
            }
            else
            {
                lstBx_sistemRaporu.Items.Add("lambalar kapalı");
            }
            if (chckBx_kombi.Checked==true)
            {
                lstBx_sistemRaporu.Items.Add("kombi açık");
            }
            else
            {
                lstBx_sistemRaporu.Items.Add("kombi kapalı");
            }
        }
    }
}
