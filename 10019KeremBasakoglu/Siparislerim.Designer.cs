namespace _10019KeremBasakoglu
{
    partial class Siparislerim
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
            this.KB_btnSprsGoster = new System.Windows.Forms.Button();
            this.KB_datagrdSprs = new System.Windows.Forms.DataGridView();
            this.KB_btnAnaSayfa = new System.Windows.Forms.Button();
            this.KB_lblSiparislerim = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.KB_datagrdSprs)).BeginInit();
            this.SuspendLayout();
            // 
            // KB_btnSprsGoster
            // 
            this.KB_btnSprsGoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.KB_btnSprsGoster.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KB_btnSprsGoster.ForeColor = System.Drawing.Color.Black;
            this.KB_btnSprsGoster.Location = new System.Drawing.Point(496, 169);
            this.KB_btnSprsGoster.Name = "KB_btnSprsGoster";
            this.KB_btnSprsGoster.Size = new System.Drawing.Size(164, 44);
            this.KB_btnSprsGoster.TabIndex = 57;
            this.KB_btnSprsGoster.Text = "Siparişlerimi Göster";
            this.KB_btnSprsGoster.UseVisualStyleBackColor = false;
            this.KB_btnSprsGoster.Click += new System.EventHandler(this.KB_btnSprsGoster_Click_1);
            // 
            // KB_datagrdSprs
            // 
            this.KB_datagrdSprs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KB_datagrdSprs.Location = new System.Drawing.Point(12, 64);
            this.KB_datagrdSprs.Name = "KB_datagrdSprs";
            this.KB_datagrdSprs.Size = new System.Drawing.Size(478, 415);
            this.KB_datagrdSprs.TabIndex = 56;
            // 
            // KB_btnAnaSayfa
            // 
            this.KB_btnAnaSayfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.KB_btnAnaSayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KB_btnAnaSayfa.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KB_btnAnaSayfa.ForeColor = System.Drawing.Color.Black;
            this.KB_btnAnaSayfa.Location = new System.Drawing.Point(518, 12);
            this.KB_btnAnaSayfa.Name = "KB_btnAnaSayfa";
            this.KB_btnAnaSayfa.Size = new System.Drawing.Size(142, 35);
            this.KB_btnAnaSayfa.TabIndex = 55;
            this.KB_btnAnaSayfa.Text = "Ana Sayfaya Dön";
            this.KB_btnAnaSayfa.UseVisualStyleBackColor = false;
            this.KB_btnAnaSayfa.Click += new System.EventHandler(this.KB_btnAnaSayfa_Click);
            // 
            // KB_lblSiparislerim
            // 
            this.KB_lblSiparislerim.AutoSize = true;
            this.KB_lblSiparislerim.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KB_lblSiparislerim.ForeColor = System.Drawing.Color.Black;
            this.KB_lblSiparislerim.Location = new System.Drawing.Point(125, 13);
            this.KB_lblSiparislerim.Name = "KB_lblSiparislerim";
            this.KB_lblSiparislerim.Size = new System.Drawing.Size(273, 34);
            this.KB_lblSiparislerim.TabIndex = 54;
            this.KB_lblSiparislerim.Text = "Geçmiş Siparişlerim";
            // 
            // Siparislerim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(666, 482);
            this.Controls.Add(this.KB_btnSprsGoster);
            this.Controls.Add(this.KB_datagrdSprs);
            this.Controls.Add(this.KB_btnAnaSayfa);
            this.Controls.Add(this.KB_lblSiparislerim);
            this.Name = "Siparislerim";
            this.Text = "Siparislerim";
            this.Load += new System.EventHandler(this.Siparislerim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KB_datagrdSprs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button KB_btnSprsGoster;
        public System.Windows.Forms.DataGridView KB_datagrdSprs;
        public System.Windows.Forms.Button KB_btnAnaSayfa;
        public System.Windows.Forms.Label KB_lblSiparislerim;
    }
}