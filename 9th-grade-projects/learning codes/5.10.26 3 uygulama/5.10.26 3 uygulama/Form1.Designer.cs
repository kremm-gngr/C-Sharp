namespace _5._10._26_3_uygulama
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
            this.groupBox_rapor = new System.Windows.Forms.GroupBox();
            this.groupBox_kontrolPaneli = new System.Windows.Forms.GroupBox();
            this.lstBx_sistemRaporu = new System.Windows.Forms.ListBox();
            this.btn_sistemKontrol = new System.Windows.Forms.Button();
            this.chckBx_lamba = new System.Windows.Forms.CheckBox();
            this.chckBx_kombi = new System.Windows.Forms.CheckBox();
            this.groupBox_rapor.SuspendLayout();
            this.groupBox_kontrolPaneli.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_rapor
            // 
            this.groupBox_rapor.Controls.Add(this.lstBx_sistemRaporu);
            this.groupBox_rapor.Location = new System.Drawing.Point(293, 73);
            this.groupBox_rapor.Name = "groupBox_rapor";
            this.groupBox_rapor.Size = new System.Drawing.Size(372, 284);
            this.groupBox_rapor.TabIndex = 0;
            this.groupBox_rapor.TabStop = false;
            this.groupBox_rapor.Text = "Sistem Raporu";
            // 
            // groupBox_kontrolPaneli
            // 
            this.groupBox_kontrolPaneli.Controls.Add(this.btn_sistemKontrol);
            this.groupBox_kontrolPaneli.Controls.Add(this.chckBx_kombi);
            this.groupBox_kontrolPaneli.Controls.Add(this.chckBx_lamba);
            this.groupBox_kontrolPaneli.Location = new System.Drawing.Point(16, 78);
            this.groupBox_kontrolPaneli.Name = "groupBox_kontrolPaneli";
            this.groupBox_kontrolPaneli.Size = new System.Drawing.Size(250, 279);
            this.groupBox_kontrolPaneli.TabIndex = 1;
            this.groupBox_kontrolPaneli.TabStop = false;
            this.groupBox_kontrolPaneli.Text = "kontrol paneli";
            // 
            // lstBx_sistemRaporu
            // 
            this.lstBx_sistemRaporu.FormattingEnabled = true;
            this.lstBx_sistemRaporu.Location = new System.Drawing.Point(22, 34);
            this.lstBx_sistemRaporu.Name = "lstBx_sistemRaporu";
            this.lstBx_sistemRaporu.Size = new System.Drawing.Size(334, 225);
            this.lstBx_sistemRaporu.TabIndex = 0;
            // 
            // btn_sistemKontrol
            // 
            this.btn_sistemKontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sistemKontrol.Location = new System.Drawing.Point(17, 159);
            this.btn_sistemKontrol.Name = "btn_sistemKontrol";
            this.btn_sistemKontrol.Size = new System.Drawing.Size(216, 60);
            this.btn_sistemKontrol.TabIndex = 2;
            this.btn_sistemKontrol.Text = "Sistemi kontrol et";
            this.btn_sistemKontrol.UseVisualStyleBackColor = true;
            this.btn_sistemKontrol.Click += new System.EventHandler(this.btn_sistemKontrol_Click);
            // 
            // chckBx_lamba
            // 
            this.chckBx_lamba.AutoSize = true;
            this.chckBx_lamba.Location = new System.Drawing.Point(16, 42);
            this.chckBx_lamba.Name = "chckBx_lamba";
            this.chckBx_lamba.Size = new System.Drawing.Size(104, 17);
            this.chckBx_lamba.TabIndex = 0;
            this.chckBx_lamba.Text = "Lamba Aç/Kapa";
            this.chckBx_lamba.UseVisualStyleBackColor = true;
            // 
            // chckBx_kombi
            // 
            this.chckBx_kombi.AutoSize = true;
            this.chckBx_kombi.Location = new System.Drawing.Point(17, 87);
            this.chckBx_kombi.Name = "chckBx_kombi";
            this.chckBx_kombi.Size = new System.Drawing.Size(100, 17);
            this.chckBx_kombi.TabIndex = 1;
            this.chckBx_kombi.Text = "Kombi Aç/kapa";
            this.chckBx_kombi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.groupBox_kontrolPaneli);
            this.Controls.Add(this.groupBox_rapor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_rapor.ResumeLayout(false);
            this.groupBox_kontrolPaneli.ResumeLayout(false);
            this.groupBox_kontrolPaneli.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_rapor;
        private System.Windows.Forms.GroupBox groupBox_kontrolPaneli;
        private System.Windows.Forms.ListBox lstBx_sistemRaporu;
        private System.Windows.Forms.Button btn_sistemKontrol;
        private System.Windows.Forms.CheckBox chckBx_kombi;
        private System.Windows.Forms.CheckBox chckBx_lamba;
    }
}

