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
    public partial class Siparislerim : Form
    {
        private SqlConnection connection;
        private string kullaniciAdi;

        public Siparislerim(string kullaniciAdi)
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            this.kullaniciAdi = kullaniciAdi;
        }

        private void InitializeDatabaseConnection()
        {
            string connectionString = @"Data Source=KEREM\SQLEXPRESS;Initial Catalog=ManavDB;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void Siparislerim_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            KB_datagrdSprs.Columns.Add("MusteriAdi", "Müşteri Adı");
            KB_datagrdSprs.Columns.Add("AlinanUrun", "Alınan Ürün");
            KB_datagrdSprs.Columns.Add("Adedi", "Adedi");
            KB_datagrdSprs.Columns.Add("AlinanTarih", "Alınan Tarih");
            KB_datagrdSprs.Columns.Add("Tutar", "Tutar");
        }

        private void KB_btnAnaSayfa_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaSayfa anaSayfaForm = new AnaSayfa(kullaniciAdi, "");
            anaSayfaForm.Show();
        }

        private void KB_btnSprsGoster_Click_1(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT MusteriAdi, AlinanUrun, Adedi, AlinanTarih, Tutar " +
                               "FROM MusteriTablo " +
                               "WHERE MusteriAdi = @kullaniciAdi";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                KB_datagrdSprs.Rows.Clear();

                while (reader.Read())
                {
                    string musteri = reader["MusteriAdi"].ToString();
                    string urun = reader["AlinanUrun"].ToString();
                    int adedi = Convert.ToInt32(reader["Adedi"]);
                    DateTime tarih = Convert.ToDateTime(reader["AlinanTarih"]);
                    decimal tutar = Convert.ToDecimal(reader["Tutar"]);

                    KB_datagrdSprs.Rows.Add(musteri, urun, adedi, tarih.ToString("yyyy-MM-dd"), tutar);
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veritabanı hatası: {ex.Message}");
                connection.Close();
            }
        }
    }
}