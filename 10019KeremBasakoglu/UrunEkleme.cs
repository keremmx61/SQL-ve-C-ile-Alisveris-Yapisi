using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10019KeremBasakoglu
{
    public partial class UrunEkleme : Form
    {
        private SqlConnection connection;

        public UrunEkleme()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }

        private void InitializeDatabaseConnection()
        {
            string connectionString = @"Data Source=KEREM\SQLEXPRESS;Initial Catalog=ManavDB;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void UrunEkleme_Load(object sender, EventArgs e)
        {
            KB_cmbBxKategori.Items.AddRange(new string[] { "Kahvaltilik", "EtUrunleri", "Caylar", "Baharatlar", "Mezeler" });
        }

        private void KB_txtBxUrunAdi_TextChanged(object sender, EventArgs e)
        {
        }

        private void KB_cmbBxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void KB_txtBxFiyat_TextChanged(object sender, EventArgs e)
        {
        }

        private void KB_btnOnayla_Click(object sender, EventArgs e)
        {
            string urunAdi = KB_txtBxUrunAdi.Text;
            string kategori = KB_cmbBxKategori.SelectedItem?.ToString();
            decimal fiyat;

            if (string.IsNullOrEmpty(urunAdi) || string.IsNullOrEmpty(kategori) || !decimal.TryParse(KB_txtBxFiyat.Text, out fiyat))
            {
                MessageBox.Show("Lütfen tüm alanları doğru doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string query = $"INSERT INTO {kategori} (Urun, Kategorisi, Fiyati) VALUES (@Urun, @Kategorisi, @Fiyati)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Urun", urunAdi);
                command.Parameters.AddWithValue("@Kategorisi", kategori);
                command.Parameters.AddWithValue("@Fiyati", fiyat);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Ürün başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KB_txtBxUrunAdi.Clear();
                KB_cmbBxKategori.SelectedIndex = -1;
                KB_txtBxFiyat.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veritabanı hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }

        private void KB_btnGeri_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfaForm = new AnaSayfa("", "");
            anaSayfaForm.Show();
            this.Close();
        }
    }
}
