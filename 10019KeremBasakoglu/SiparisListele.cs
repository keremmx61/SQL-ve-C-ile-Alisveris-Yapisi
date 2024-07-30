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
    public partial class SiparisListele : Form
    {
        private SqlConnection connection;

        public SiparisListele()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }

        private void InitializeDatabaseConnection()
        {
            // Veritabanı bağlantı stringi (kendi bağlantı stringinizi buraya yazın)
            string connectionString = @"Data Source=KEREM\SQLEXPRESS;Initial Catalog=ManavDB;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void SiparisListele_Load(object sender, EventArgs e)
        {
            // Müşteri isimlerini ComboBox'a ekle
            try
            {
                string query = "SELECT KullaniciAdi FROM Kullanicilar WHERE KullaniciTipi = 'Müşteri'";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                KB_cmbBxMusteriler.Items.Clear();
                while (reader.Read())
                {
                    string musteriAdi = reader["KullaniciAdi"].ToString();
                    if (!string.IsNullOrWhiteSpace(musteriAdi))  // Boş müşteri adlarını eklememek için
                    {
                        KB_cmbBxMusteriler.Items.Add(musteriAdi);
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veritabanı hatası: {ex.Message}");
                connection.Close();
            }

            // DataGridView'e sütunları ekle
            KB_datagridSiparis.Columns.Add("MusteriAdi", "Müşteri Adı");
            KB_datagridSiparis.Columns.Add("AlinanUrun", "Alınan Ürün");
            KB_datagridSiparis.Columns.Add("Adedi", "Adedi");
            KB_datagridSiparis.Columns.Add("AlinanTarih", "Alınan Tarih");
            KB_datagridSiparis.Columns.Add("Tutar", "Tutar");

            // DataGridView sütunlarını genişlet
            KB_datagridSiparis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void KB_btnSiparisleriGoster_Click(object sender, EventArgs e)
        {
            // Seçilen müşteri adını al
            string musteriAdi = KB_cmbBxMusteriler.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(musteriAdi))
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçilen müşterinin siparişlerini getir
            try
            {
                string query = "SELECT MusteriAdi, AlinanUrun, Adedi, AlinanTarih, Tutar FROM MusteriTablo WHERE MusteriAdi = @MusteriAdi";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MusteriAdi", musteriAdi);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                KB_datagridSiparis.Rows.Clear();
                while (reader.Read())
                {
                    string musteri = reader["MusteriAdi"].ToString();
                    string urun = reader["AlinanUrun"].ToString();
                    int adedi = int.Parse(reader["Adedi"].ToString());
                    DateTime tarih = DateTime.Parse(reader["AlinanTarih"].ToString());
                    decimal tutar = decimal.Parse(reader["Tutar"].ToString());

                    string[] row = { musteri, urun, adedi.ToString(), tarih.ToString("yyyy-MM-dd"), tutar.ToString("C") };
                    KB_datagridSiparis.Rows.Add(row);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veritabanı hatası: {ex.Message}");
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfaForm = new AnaSayfa("", "");
            anaSayfaForm.Show();
            this.Close();
        }
    }
}
