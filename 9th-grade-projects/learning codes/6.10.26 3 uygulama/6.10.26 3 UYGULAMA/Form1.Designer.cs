namespace _6._10._26_3_UYGULAMA
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbx_sayi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.lstbx_tekler = new System.Windows.Forms.ListBox();
            this.lbl_ciftAdet = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_tekAdet = new System.Windows.Forms.Label();
            this.lstbx_ciftler = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbx_sayi
            // 
            this.txtbx_sayi.Location = new System.Drawing.Point(143, 39);
            this.txtbx_sayi.Name = "txtbx_sayi";
            this.txtbx_sayi.Size = new System.Drawing.Size(145, 20);
            this.txtbx_sayi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SAYI GİRİNİZ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "TEK ADET:";
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(74, 87);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(212, 52);
            this.btn_ekle.TabIndex = 3;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // lstbx_tekler
            // 
            this.lstbx_tekler.FormattingEnabled = true;
            this.lstbx_tekler.Location = new System.Drawing.Point(344, 44);
            this.lstbx_tekler.Name = "lstbx_tekler";
            this.lstbx_tekler.Size = new System.Drawing.Size(117, 160);
            this.lstbx_tekler.TabIndex = 4;
            // 
            // lbl_ciftAdet
            // 
            this.lbl_ciftAdet.AutoSize = true;
            this.lbl_ciftAdet.Location = new System.Drawing.Point(221, 192);
            this.lbl_ciftAdet.Name = "lbl_ciftAdet";
            this.lbl_ciftAdet.Size = new System.Drawing.Size(13, 13);
            this.lbl_ciftAdet.TabIndex = 5;
            this.lbl_ciftAdet.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ÇİFT ADET:";
            // 
            // lbl_tekAdet
            // 
            this.lbl_tekAdet.AutoSize = true;
            this.lbl_tekAdet.Location = new System.Drawing.Point(221, 155);
            this.lbl_tekAdet.Name = "lbl_tekAdet";
            this.lbl_tekAdet.Size = new System.Drawing.Size(13, 13);
            this.lbl_tekAdet.TabIndex = 7;
            this.lbl_tekAdet.Text = "0";
            // 
            // lstbx_ciftler
            // 
            this.lstbx_ciftler.FormattingEnabled = true;
            this.lstbx_ciftler.Location = new System.Drawing.Point(521, 44);
            this.lstbx_ciftler.Name = "lstbx_ciftler";
            this.lstbx_ciftler.Size = new System.Drawing.Size(127, 160);
            this.lstbx_ciftler.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(382, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "TEKLER";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(561, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "ÇİFTLER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstbx_ciftler);
            this.Controls.Add(this.lbl_tekAdet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_ciftAdet);
            this.Controls.Add(this.lstbx_tekler);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbx_sayi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_sayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.ListBox lstbx_tekler;
        private System.Windows.Forms.Label lbl_ciftAdet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_tekAdet;
        private System.Windows.Forms.ListBox lstbx_ciftler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

