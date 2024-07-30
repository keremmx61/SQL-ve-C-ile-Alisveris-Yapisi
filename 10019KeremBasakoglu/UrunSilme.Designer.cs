namespace _10019KeremBasakoglu
{
    partial class UrunSilme
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
            this.KB_btnSil = new System.Windows.Forms.Button();
            this.KB_btnGeri = new System.Windows.Forms.Button();
            this.KB_cmbBxKtgr = new System.Windows.Forms.ComboBox();
            this.KB_lbl = new System.Windows.Forms.Label();
            this.KB_datagridSilSiparis = new System.Windows.Forms.DataGridView();
            this.KB_btnGoster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.KB_datagridSilSiparis)).BeginInit();
            this.SuspendLayout();
            // 
            // KB_btnSil
            // 
            this.KB_btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.KB_btnSil.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KB_btnSil.Location = new System.Drawing.Point(11, 186);
            this.KB_btnSil.Name = "KB_btnSil";
            this.KB_btnSil.Size = new System.Drawing.Size(121, 41);
            this.KB_btnSil.TabIndex = 23;
            this.KB_btnSil.Text = "Silme İşlemini Onayla";
            this.KB_btnSil.UseVisualStyleBackColor = false;
            this.KB_btnSil.Click += new System.EventHandler(this.KB_btnSil_Click);
            // 
            // KB_btnGeri
            // 
            this.KB_btnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.KB_btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KB_btnGeri.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KB_btnGeri.ForeColor = System.Drawing.Color.Black;
            this.KB_btnGeri.Location = new System.Drawing.Point(11, 12);
            this.KB_btnGeri.Name = "KB_btnGeri";
            this.KB_btnGeri.Size = new System.Drawing.Size(120, 33);
            this.KB_btnGeri.TabIndex = 22;
            this.KB_btnGeri.Text = "Ana Sayfaya Dön";
            this.KB_btnGeri.UseVisualStyleBackColor = false;
            this.KB_btnGeri.Click += new System.EventHandler(this.KB_btnGeri_Click);
            // 
            // KB_cmbBxKtgr
            // 
            this.KB_cmbBxKtgr.FormattingEnabled = true;
            this.KB_cmbBxKtgr.Location = new System.Drawing.Point(357, 48);
            this.KB_cmbBxKtgr.Name = "KB_cmbBxKtgr";
            this.KB_cmbBxKtgr.Size = new System.Drawing.Size(121, 21);
            this.KB_cmbBxKtgr.TabIndex = 19;
            // 
            // KB_lbl
            // 
            this.KB_lbl.AutoSize = true;
            this.KB_lbl.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KB_lbl.Location = new System.Drawing.Point(207, 50);
            this.KB_lbl.Name = "KB_lbl";
            this.KB_lbl.Size = new System.Drawing.Size(123, 16);
            this.KB_lbl.TabIndex = 18;
            this.KB_lbl.Text = "Ürünün Kategorisi:";
            // 
            // KB_datagridSilSiparis
            // 
            this.KB_datagridSilSiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KB_datagridSilSiparis.Location = new System.Drawing.Point(154, 75);
            this.KB_datagridSilSiparis.Name = "KB_datagridSilSiparis";
            this.KB_datagridSilSiparis.Size = new System.Drawing.Size(522, 288);
            this.KB_datagridSilSiparis.TabIndex = 24;
            // 
            // KB_btnGoster
            // 
            this.KB_btnGoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.KB_btnGoster.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KB_btnGoster.Location = new System.Drawing.Point(507, 43);
            this.KB_btnGoster.Name = "KB_btnGoster";
            this.KB_btnGoster.Size = new System.Drawing.Size(121, 30);
            this.KB_btnGoster.TabIndex = 25;
            this.KB_btnGoster.Text = "Ürünleri Göster";
            this.KB_btnGoster.UseVisualStyleBackColor = false;
            this.KB_btnGoster.Click += new System.EventHandler(this.KB_btnGoster_Click);
            // 
            // UrunSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(695, 375);
            this.Controls.Add(this.KB_btnGoster);
            this.Controls.Add(this.KB_datagridSilSiparis);
            this.Controls.Add(this.KB_btnSil);
            this.Controls.Add(this.KB_btnGeri);
            this.Controls.Add(this.KB_cmbBxKtgr);
            this.Controls.Add(this.KB_lbl);
            this.Name = "UrunSilme";
            this.Text = "UrunSilme";
            this.Load += new System.EventHandler(this.UrunSilme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KB_datagridSilSiparis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KB_btnSil;
        private System.Windows.Forms.Button KB_btnGeri;
        private System.Windows.Forms.ComboBox KB_cmbBxKtgr;
        private System.Windows.Forms.Label KB_lbl;
        private System.Windows.Forms.DataGridView KB_datagridSilSiparis;
        private System.Windows.Forms.Button KB_btnGoster;
    }
}