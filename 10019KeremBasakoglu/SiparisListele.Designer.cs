namespace _10019KeremBasakoglu
{
    partial class SiparisListele
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
            this.KB_lblMusteriler = new System.Windows.Forms.Label();
            this.KB_cmbBxMusteriler = new System.Windows.Forms.ComboBox();
            this.KB_datagridSiparis = new System.Windows.Forms.DataGridView();
            this.KB_btnSiparisleriGoster = new System.Windows.Forms.Button();
            this.KB_btnAnSyf = new System.Windows.Forms.Button();
            this.KB_lblSiparis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.KB_datagridSiparis)).BeginInit();
            this.SuspendLayout();
            // 
            // KB_lblMusteriler
            // 
            this.KB_lblMusteriler.AutoSize = true;
            this.KB_lblMusteriler.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KB_lblMusteriler.ForeColor = System.Drawing.Color.Black;
            this.KB_lblMusteriler.Location = new System.Drawing.Point(216, 17);
            this.KB_lblMusteriler.Name = "KB_lblMusteriler";
            this.KB_lblMusteriler.Size = new System.Drawing.Size(106, 16);
            this.KB_lblMusteriler.TabIndex = 52;
            this.KB_lblMusteriler.Text = "Müşteri Seçiniz!";
            // 
            // KB_cmbBxMusteriler
            // 
            this.KB_cmbBxMusteriler.FormattingEnabled = true;
            this.KB_cmbBxMusteriler.Location = new System.Drawing.Point(328, 15);
            this.KB_cmbBxMusteriler.Name = "KB_cmbBxMusteriler";
            this.KB_cmbBxMusteriler.Size = new System.Drawing.Size(167, 21);
            this.KB_cmbBxMusteriler.TabIndex = 51;
            // 
            // KB_datagridSiparis
            // 
            this.KB_datagridSiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KB_datagridSiparis.Location = new System.Drawing.Point(103, 125);
            this.KB_datagridSiparis.Name = "KB_datagridSiparis";
            this.KB_datagridSiparis.Size = new System.Drawing.Size(494, 382);
            this.KB_datagridSiparis.TabIndex = 50;
            // 
            // KB_btnSiparisleriGoster
            // 
            this.KB_btnSiparisleriGoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.KB_btnSiparisleriGoster.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KB_btnSiparisleriGoster.ForeColor = System.Drawing.Color.Black;
            this.KB_btnSiparisleriGoster.Location = new System.Drawing.Point(344, 42);
            this.KB_btnSiparisleriGoster.Name = "KB_btnSiparisleriGoster";
            this.KB_btnSiparisleriGoster.Size = new System.Drawing.Size(136, 31);
            this.KB_btnSiparisleriGoster.TabIndex = 49;
            this.KB_btnSiparisleriGoster.Text = "Siparişleri Göster";
            this.KB_btnSiparisleriGoster.UseVisualStyleBackColor = false;
            this.KB_btnSiparisleriGoster.Click += new System.EventHandler(this.KB_btnSiparisleriGoster_Click);
            // 
            // KB_btnAnSyf
            // 
            this.KB_btnAnSyf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.KB_btnAnSyf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KB_btnAnSyf.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KB_btnAnSyf.Location = new System.Drawing.Point(12, 7);
            this.KB_btnAnSyf.Name = "KB_btnAnSyf";
            this.KB_btnAnSyf.Size = new System.Drawing.Size(121, 37);
            this.KB_btnAnSyf.TabIndex = 48;
            this.KB_btnAnSyf.Text = "Ana Sayfaya Dön";
            this.KB_btnAnSyf.UseVisualStyleBackColor = false;
            this.KB_btnAnSyf.Click += new System.EventHandler(this.button1_Click);
            // 
            // KB_lblSiparis
            // 
            this.KB_lblSiparis.AutoSize = true;
            this.KB_lblSiparis.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KB_lblSiparis.ForeColor = System.Drawing.Color.Black;
            this.KB_lblSiparis.Location = new System.Drawing.Point(99, 99);
            this.KB_lblSiparis.Name = "KB_lblSiparis";
            this.KB_lblSiparis.Size = new System.Drawing.Size(94, 23);
            this.KB_lblSiparis.TabIndex = 47;
            this.KB_lblSiparis.Text = "Siparişler";
            // 
            // SiparisListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(613, 519);
            this.Controls.Add(this.KB_lblMusteriler);
            this.Controls.Add(this.KB_cmbBxMusteriler);
            this.Controls.Add(this.KB_datagridSiparis);
            this.Controls.Add(this.KB_btnSiparisleriGoster);
            this.Controls.Add(this.KB_btnAnSyf);
            this.Controls.Add(this.KB_lblSiparis);
            this.Name = "SiparisListele";
            this.Text = "SiparisListele";
            this.Load += new System.EventHandler(this.SiparisListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KB_datagridSiparis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label KB_lblMusteriler;
        public System.Windows.Forms.ComboBox KB_cmbBxMusteriler;
        public System.Windows.Forms.DataGridView KB_datagridSiparis;
        public System.Windows.Forms.Button KB_btnSiparisleriGoster;
        public System.Windows.Forms.Button KB_btnAnSyf;
        public System.Windows.Forms.Label KB_lblSiparis;
    }
}