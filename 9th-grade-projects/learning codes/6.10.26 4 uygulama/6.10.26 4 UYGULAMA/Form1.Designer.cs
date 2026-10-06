namespace _6._10._26_4_UYGULAMA
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
            this.rdb_toplama = new System.Windows.Forms.RadioButton();
            this.rdb_cikarma = new System.Windows.Forms.RadioButton();
            this.rdb_carpma = new System.Windows.Forms.RadioButton();
            this.rdb_bolme = new System.Windows.Forms.RadioButton();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sayi1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sayi2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdb_toplama
            // 
            this.rdb_toplama.AutoSize = true;
            this.rdb_toplama.Location = new System.Drawing.Point(27, 34);
            this.rdb_toplama.Name = "rdb_toplama";
            this.rdb_toplama.Size = new System.Drawing.Size(76, 17);
            this.rdb_toplama.TabIndex = 0;
            this.rdb_toplama.TabStop = true;
            this.rdb_toplama.Text = "TOPLAMA";
            this.rdb_toplama.UseVisualStyleBackColor = true;
            // 
            // rdb_cikarma
            // 
            this.rdb_cikarma.AutoSize = true;
            this.rdb_cikarma.Location = new System.Drawing.Point(27, 83);
            this.rdb_cikarma.Name = "rdb_cikarma";
            this.rdb_cikarma.Size = new System.Drawing.Size(73, 17);
            this.rdb_cikarma.TabIndex = 1;
            this.rdb_cikarma.TabStop = true;
            this.rdb_cikarma.Text = "ÇIKARMA";
            this.rdb_cikarma.UseVisualStyleBackColor = true;
            // 
            // rdb_carpma
            // 
            this.rdb_carpma.AutoSize = true;
            this.rdb_carpma.Location = new System.Drawing.Point(235, 34);
            this.rdb_carpma.Name = "rdb_carpma";
            this.rdb_carpma.Size = new System.Drawing.Size(70, 17);
            this.rdb_carpma.TabIndex = 2;
            this.rdb_carpma.TabStop = true;
            this.rdb_carpma.Text = "ÇARPMA";
            this.rdb_carpma.UseVisualStyleBackColor = true;
            // 
            // rdb_bolme
            // 
            this.rdb_bolme.AutoSize = true;
            this.rdb_bolme.Location = new System.Drawing.Point(235, 83);
            this.rdb_bolme.Name = "rdb_bolme";
            this.rdb_bolme.Size = new System.Drawing.Size(62, 17);
            this.rdb_bolme.TabIndex = 3;
            this.rdb_bolme.TabStop = true;
            this.rdb_bolme.Text = "BÖLME";
            this.rdb_bolme.UseVisualStyleBackColor = true;
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(61, 252);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(236, 44);
            this.btn_hesapla.TabIndex = 4;
            this.btn_hesapla.Text = "HESAPLAMA";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "1.SAYI GİRİNİZ:";
            // 
            // txt_sayi1
            // 
            this.txt_sayi1.Location = new System.Drawing.Point(138, 141);
            this.txt_sayi1.Name = "txt_sayi1";
            this.txt_sayi1.Size = new System.Drawing.Size(171, 20);
            this.txt_sayi1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "2.SAYI GİRİNİZ:";
            // 
            // txt_sayi2
            // 
            this.txt_sayi2.Location = new System.Drawing.Point(138, 203);
            this.txt_sayi2.Name = "txt_sayi2";
            this.txt_sayi2.Size = new System.Drawing.Size(171, 20);
            this.txt_sayi2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "SONUÇ:";
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(232, 379);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(16, 13);
            this.lbl_sonuc.TabIndex = 10;
            this.lbl_sonuc.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 450);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_sayi2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_sayi1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.rdb_bolme);
            this.Controls.Add(this.rdb_carpma);
            this.Controls.Add(this.rdb_cikarma);
            this.Controls.Add(this.rdb_toplama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb_toplama;
        private System.Windows.Forms.RadioButton rdb_cikarma;
        private System.Windows.Forms.RadioButton rdb_carpma;
        private System.Windows.Forms.RadioButton rdb_bolme;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sayi1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sayi2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_sonuc;
    }
}

