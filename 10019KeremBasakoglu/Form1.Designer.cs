namespace _10019KeremBasakoglu
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
            this.KB_cmbBx = new System.Windows.Forms.ComboBox();
            this.KB_btnGiris = new System.Windows.Forms.Button();
            this.KB_lblSifre = new System.Windows.Forms.Label();
            this.KB_lblKllncAdi = new System.Windows.Forms.Label();
            this.KB_txtBxSifre = new System.Windows.Forms.TextBox();
            this.KB_txtBxAd = new System.Windows.Forms.TextBox();
            this.KB_lblTipi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KB_cmbBx
            // 
            this.KB_cmbBx.FormattingEnabled = true;
            this.KB_cmbBx.Location = new System.Drawing.Point(204, 12);
            this.KB_cmbBx.Name = "KB_cmbBx";
            this.KB_cmbBx.Size = new System.Drawing.Size(120, 21);
            this.KB_cmbBx.TabIndex = 11;
            this.KB_cmbBx.SelectedIndexChanged += new System.EventHandler(this.KB_cmbBx_SelectedIndexChanged);
            // 
            // KB_btnGiris
            // 
            this.KB_btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.KB_btnGiris.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KB_btnGiris.ForeColor = System.Drawing.Color.Black;
            this.KB_btnGiris.Location = new System.Drawing.Point(158, 125);
            this.KB_btnGiris.Name = "KB_btnGiris";
            this.KB_btnGiris.Size = new System.Drawing.Size(93, 29);
            this.KB_btnGiris.TabIndex = 10;
            this.KB_btnGiris.Text = "Giriş Yap";
            this.KB_btnGiris.UseVisualStyleBackColor = false;
            this.KB_btnGiris.Click += new System.EventHandler(this.KB_btnGiris_Click);
            // 
            // KB_lblSifre
            // 
            this.KB_lblSifre.AutoSize = true;
            this.KB_lblSifre.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KB_lblSifre.ForeColor = System.Drawing.Color.Black;
            this.KB_lblSifre.Location = new System.Drawing.Point(75, 93);
            this.KB_lblSifre.Name = "KB_lblSifre";
            this.KB_lblSifre.Size = new System.Drawing.Size(46, 16);
            this.KB_lblSifre.TabIndex = 9;
            this.KB_lblSifre.Text = "Parola";
            // 
            // KB_lblKllncAdi
            // 
            this.KB_lblKllncAdi.AutoSize = true;
            this.KB_lblKllncAdi.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KB_lblKllncAdi.ForeColor = System.Drawing.Color.Black;
            this.KB_lblKllncAdi.Location = new System.Drawing.Point(42, 62);
            this.KB_lblKllncAdi.Name = "KB_lblKllncAdi";
            this.KB_lblKllncAdi.Size = new System.Drawing.Size(85, 16);
            this.KB_lblKllncAdi.TabIndex = 8;
            this.KB_lblKllncAdi.Text = "Kullanıcı Adı";
            // 
            // KB_txtBxSifre
            // 
            this.KB_txtBxSifre.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KB_txtBxSifre.Location = new System.Drawing.Point(133, 90);
            this.KB_txtBxSifre.Name = "KB_txtBxSifre";
            this.KB_txtBxSifre.Size = new System.Drawing.Size(139, 23);
            this.KB_txtBxSifre.TabIndex = 7;
            // 
            // KB_txtBxAd
            // 
            this.KB_txtBxAd.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KB_txtBxAd.Location = new System.Drawing.Point(133, 59);
            this.KB_txtBxAd.Name = "KB_txtBxAd";
            this.KB_txtBxAd.Size = new System.Drawing.Size(139, 23);
            this.KB_txtBxAd.TabIndex = 6;
            // 
            // KB_lblTipi
            // 
            this.KB_lblTipi.AutoSize = true;
            this.KB_lblTipi.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KB_lblTipi.ForeColor = System.Drawing.Color.Red;
            this.KB_lblTipi.Location = new System.Drawing.Point(3, 13);
            this.KB_lblTipi.Name = "KB_lblTipi";
            this.KB_lblTipi.Size = new System.Drawing.Size(195, 17);
            this.KB_lblTipi.TabIndex = 12;
            this.KB_lblTipi.Text = "Lütfen Kullanıcı Tipini Seçiniz!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(337, 166);
            this.Controls.Add(this.KB_lblTipi);
            this.Controls.Add(this.KB_cmbBx);
            this.Controls.Add(this.KB_btnGiris);
            this.Controls.Add(this.KB_lblSifre);
            this.Controls.Add(this.KB_lblKllncAdi);
            this.Controls.Add(this.KB_txtBxSifre);
            this.Controls.Add(this.KB_txtBxAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox KB_cmbBx;
        private System.Windows.Forms.Button KB_btnGiris;
        private System.Windows.Forms.Label KB_lblSifre;
        private System.Windows.Forms.Label KB_lblKllncAdi;
        private System.Windows.Forms.TextBox KB_txtBxSifre;
        private System.Windows.Forms.TextBox KB_txtBxAd;
        private System.Windows.Forms.Label KB_lblTipi;
    }
}

