namespace _6._10._26_2_UYGULAMA
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_sayi2 = new System.Windows.Forms.TextBox();
            this.txtbx_sayi1 = new System.Windows.Forms.TextBox();
            this.txtbx_sayi3 = new System.Windows.Forms.TextBox();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.btn_enkucuk = new System.Windows.Forms.Button();
            this.btn_enbuyuk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.SAYI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2.SAYI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "3.SAYI:";
            // 
            // txtbx_sayi2
            // 
            this.txtbx_sayi2.Location = new System.Drawing.Point(114, 82);
            this.txtbx_sayi2.Name = "txtbx_sayi2";
            this.txtbx_sayi2.Size = new System.Drawing.Size(100, 20);
            this.txtbx_sayi2.TabIndex = 3;
            // 
            // txtbx_sayi1
            // 
            this.txtbx_sayi1.Location = new System.Drawing.Point(114, 21);
            this.txtbx_sayi1.Name = "txtbx_sayi1";
            this.txtbx_sayi1.Size = new System.Drawing.Size(100, 20);
            this.txtbx_sayi1.TabIndex = 4;
            // 
            // txtbx_sayi3
            // 
            this.txtbx_sayi3.Location = new System.Drawing.Point(114, 144);
            this.txtbx_sayi3.Name = "txtbx_sayi3";
            this.txtbx_sayi3.Size = new System.Drawing.Size(100, 20);
            this.txtbx_sayi3.TabIndex = 5;
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(65, 231);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(84, 13);
            this.lbl_sonuc.TabIndex = 6;
            this.lbl_sonuc.Text = "BEKLENİYOR...";
            // 
            // btn_enkucuk
            // 
            this.btn_enkucuk.Location = new System.Drawing.Point(292, 103);
            this.btn_enkucuk.Name = "btn_enkucuk";
            this.btn_enkucuk.Size = new System.Drawing.Size(119, 61);
            this.btn_enkucuk.TabIndex = 7;
            this.btn_enkucuk.Text = "EN KÜÇÜK";
            this.btn_enkucuk.UseVisualStyleBackColor = true;
            this.btn_enkucuk.Click += new System.EventHandler(this.btn_enkucuk_Click);
            // 
            // btn_enbuyuk
            // 
            this.btn_enbuyuk.Location = new System.Drawing.Point(292, 24);
            this.btn_enbuyuk.Name = "btn_enbuyuk";
            this.btn_enbuyuk.Size = new System.Drawing.Size(119, 57);
            this.btn_enbuyuk.TabIndex = 8;
            this.btn_enbuyuk.Text = "EN BÜYÜK";
            this.btn_enbuyuk.UseVisualStyleBackColor = true;
            this.btn_enbuyuk.Click += new System.EventHandler(this.btn_enbuyuk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.btn_enbuyuk);
            this.Controls.Add(this.btn_enkucuk);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.txtbx_sayi3);
            this.Controls.Add(this.txtbx_sayi1);
            this.Controls.Add(this.txtbx_sayi2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_sayi2;
        private System.Windows.Forms.TextBox txtbx_sayi1;
        private System.Windows.Forms.TextBox txtbx_sayi3;
        private System.Windows.Forms.Label lbl_sonuc;
        private System.Windows.Forms.Button btn_enkucuk;
        private System.Windows.Forms.Button btn_enbuyuk;
    }
}

