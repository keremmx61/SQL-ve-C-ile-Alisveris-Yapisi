namespace _10019KeremBasakoglu
{
    partial class UrunEkleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.KB_btnEkle = new System.Windows.Forms.Button();
            this.KB_btnGeri = new System.Windows.Forms.Button();
            this.KB_txtBxFiyat = new System.Windows.Forms.TextBox();
            this.KB_lblFyt = new System.Windows.Forms.Label();
            this.KB_cmbBxKategori = new System.Windows.Forms.ComboBox();
            this.KB_lblKtgr = new System.Windows.Forms.Label();
            this.KB_txtBxUrunAdi = new System.Windows.Forms.TextBox();
            this.KB_lblUrunAdi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KB_btnEkle
            // 
            this.KB_btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.KB_btnEkle.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KB_btnEkle.ForeColor = System.Drawing.Color.Black;
            this.KB_btnEkle.Location = new System.Drawing.Point(159, 127);
            this.KB_btnEkle.Name = "KB_btnEkle";
            this.KB_btnEkle.Size = new System.Drawing.Size(139, 41);
            this.KB_btnEkle.TabIndex = 15;
            this.KB_btnEkle.Text = "Ekle";
            this.KB_btnEkle.UseVisualStyleBackColor = false;
            this.KB_btnEkle.Click += new System.EventHandler(this.KB_btnOnayla_Click);
            // 
            // KB_btnGeri
            // 
            this.KB_btnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.KB_btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KB_btnGeri.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KB_btnGeri.ForeColor = System.Drawing.Color.Black;
            this.KB_btnGeri.Location = new System.Drawing.Point(12, 127);
            this.KB_btnGeri.Name = "KB_btnGeri";
            this.KB_btnGeri.Size = new System.Drawing.Size(126, 41);
            this.KB_btnGeri.TabIndex = 14;
            this.KB_btnGeri.Text = "Ana Sayfaya Dön";
            this.KB_btnGeri.UseVisualStyleBackColor = false;
            this.KB_btnGeri.Click += new System.EventHandler(this.KB_btnGeri_Click);
            // 
            // KB_txtBxFiyat
            // 
            this.KB_txtBxFiyat.Location = new System.Drawing.Point(131, 79);
            this.KB_txtBxFiyat.Name = "KB_txtBxFiyat";
            this.KB_txtBxFiyat.Size = new System.Drawing.Size(154, 20);
            this.KB_txtBxFiyat.TabIndex = 13;
            this.KB_txtBxFiyat.TextChanged += new System.EventHandler(this.KB_txtBxFiyat_TextChanged);
            // 
            // KB_lblFyt
            // 
            this.KB_lblFyt.AutoSize = true;
            this.KB_lblFyt.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KB_lblFyt.Location = new System.Drawing.Point(37, 79);
            this.KB_lblFyt.Name = "KB_lblFyt";
            this.KB_lblFyt.Size = new System.Drawing.Size(75, 16);
            this.KB_lblFyt.TabIndex = 12;
            this.KB_lblFyt.Text = "Ürün Fiyatı";
            // 
            // KB_cmbBxKategori
            // 
            this.KB_cmbBxKategori.FormattingEnabled = true;
            this.KB_cmbBxKategori.Location = new System.Drawing.Point(131, 46);
            this.KB_cmbBxKategori.Name = "KB_cmbBxKategori";
            this.KB_cmbBxKategori.Size = new System.Drawing.Size(154, 21);
            this.KB_cmbBxKategori.TabIndex = 11;
            this.KB_cmbBxKategori.SelectedIndexChanged += new System.EventHandler(this.KB_cmbBxKategori_SelectedIndexChanged);
            // 
            // KB_lblKtgr
            // 
            this.KB_lblKtgr.AutoSize = true;
            this.KB_lblKtgr.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KB_lblKtgr.Location = new System.Drawing.Point(9, 48);
            this.KB_lblKtgr.Name = "KB_lblKtgr";
            this.KB_lblKtgr.Size = new System.Drawing.Size(103, 16);
            this.KB_lblKtgr.TabIndex = 10;
            this.KB_lblKtgr.Text = "Ürün Kategorisi";
            // 
            // KB_txtBxUrunAdi
            // 
            this.KB_txtBxUrunAdi.Location = new System.Drawing.Point(131, 12);
            this.KB_txtBxUrunAdi.Name = "KB_txtBxUrunAdi";
            this.KB_txtBxUrunAdi.Size = new System.Drawing.Size(154, 20);
            this.KB_txtBxUrunAdi.TabIndex = 9;
            this.KB_txtBxUrunAdi.TextChanged += new System.EventHandler(this.KB_txtBxUrunAdi_TextChanged);
            // 
            // KB_lblUrunAdi
            // 
            this.KB_lblUrunAdi.AutoSize = true;
            this.KB_lblUrunAdi.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KB_lblUrunAdi.Location = new System.Drawing.Point(50, 12);
            this.KB_lblUrunAdi.Name = "KB_lblUrunAdi";
            this.KB_lblUrunAdi.Size = new System.Drawing.Size(62, 16);
            this.KB_lblUrunAdi.TabIndex = 8;
            this.KB_lblUrunAdi.Text = "Ürün Adı";
            // 
            // UrunEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(320, 189);
            this.Controls.Add(this.KB_btnEkle);
            this.Controls.Add(this.KB_btnGeri);
            this.Controls.Add(this.KB_txtBxFiyat);
            this.Controls.Add(this.KB_lblFyt);
            this.Controls.Add(this.KB_cmbBxKategori);
            this.Controls.Add(this.KB_lblKtgr);
            this.Controls.Add(this.KB_txtBxUrunAdi);
            this.Controls.Add(this.KB_lblUrunAdi);
            this.Name = "UrunEkleme";
            this.Text = "UrunEkleme";
            this.Load += new System.EventHandler(this.UrunEkleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KB_btnEkle;
        private System.Windows.Forms.Button KB_btnGeri;
        private System.Windows.Forms.TextBox KB_txtBxFiyat;
        private System.Windows.Forms.Label KB_lblFyt;
        private System.Windows.Forms.ComboBox KB_cmbBxKategori;
        private System.Windows.Forms.Label KB_lblKtgr;
        private System.Windows.Forms.TextBox KB_txtBxUrunAdi;
        private System.Windows.Forms.Label KB_lblUrunAdi;
    }
}