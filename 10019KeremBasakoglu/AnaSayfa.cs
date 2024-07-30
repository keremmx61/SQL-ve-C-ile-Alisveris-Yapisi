using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace _10019KeremBasakoglu
{
    public partial class AnaSayfa : Form
    {
        private SqlConnection connection;
        private string kullaniciAdi;
        private string kullaniciTipi;

        public AnaSayfa(string kullaniciAdi, string kullaniciTipi)
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            this.kullaniciAdi = kullaniciAdi;
            this.kullaniciTipi = kullaniciTipi;
        }

        private void InitializeDatabaseConnection()
        {
            string connectionString = @"Data Source=KEREM\SQLEXPRESS;Initial Catalog=ManavDB;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            if (kullaniciTipi == "Yönetici")
            {
                KB_lblYntcMstr.Text = $"{kullaniciAdi} (Yönetici)";
            }
            else
            {
                KB_lblYntcMstr.Text = kullaniciAdi;
            }

            KB_lblYntcMstr.ForeColor = Color.Red;

            if (kullaniciTipi == "Yönetici")
            {
                KB_btnUrunEkle.Visible = true;
                KB_btnUrunSilme.Visible = true;
                KB_btnSiparisListele.Visible = true;
                KB_btnSiparislerim.Visible = false;
                KB_btnSiparisVer.Visible = true;
                KB_chkBxMusteriSec.Visible = true;
            }
            else
            {
                KB_btnUrunEkle.Visible = false;
                KB_btnUrunSilme.Visible = false;
                KB_btnSiparislerim.Visible = true;
                KB_btnSiparisListele.Visible = false;
                KB_btnSiparisVer.Visible = true;
                KB_chkBxMusteriSec.Visible = false;
                KB_lblSecimMstr.Visible = false;
            }

            KB_datagrSepet.Columns.Add("Urun", "Ürün");
            KB_datagrSepet.Columns.Add("Kategorisi", "Kategori");
            KB_datagrSepet.Columns.Add("Fiyati", "Fiyat");
            KB_datagrSepet.Columns.Add("Adet", "Adet");

            KB_datagrSepet.Columns["Adet"].ReadOnly = false;

            KB_lblToplamTutar.Text = "Toplam Tutar: 0 ₺";

            if (kullaniciTipi == "Yönetici")
            {
                LoadMusteriler();
            }
        }

        private void LoadMusteriler()
        {
            try
            {
                string query = "SELECT KullaniciAdi FROM Kullanicilar WHERE KullaniciTipi = 'Müşteri'";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                KB_chkBxMusteriSec.Items.Clear();
                while (reader.Read())
                {
                    string musteri = reader["KullaniciAdi"].ToString();
                    KB_chkBxMusteriSec.Items.Add(musteri);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Müşterileri yüklerken bir hata oluştu: {ex.Message}");
                connection.Close();
            }
        }

        private void KB_btnKahvalti_Click(object sender, EventArgs e)
        {
            LoadProducts("Kahvaltilik");
        }

        private void KB_btnEt_Click(object sender, EventArgs e)
        {
            LoadProducts("EtUrunleri");
        }

        private void KB_btnCay_Click(object sender, EventArgs e)
        {
            LoadProducts("Caylar");
        }

        private void KB_btnBaharat_Click(object sender, EventArgs e)
        {
            LoadProducts("Baharatlar");
        }

        private void KB_btnMeze_Click(object sender, EventArgs e)
        {
            LoadProducts("Mezeler");
        }

        private void LoadProducts(string kategori)
        {
            try
            {
                string query = $"SELECT Urun, Kategorisi, Fiyati FROM {kategori}";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                KB_chkBxUrunler.Items.Clear();
                while (reader.Read())
                {
                    string urun = reader["Urun"].ToString();
                    KB_chkBxUrunler.Items.Add(urun);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veritabanı hatası: {ex.Message}");
                connection.Close();
            }
        }

        private void KB_btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (KB_chkBxUrunler.CheckedItems.Count == 0)
            {
                MessageBox.Show("Lütfen ürün seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var item in KB_chkBxUrunler.CheckedItems)
            {
                AddToCart(item.ToString());
            }
        }

        private void AddToCart(string urun)
        {
            try
            {
                string query = $"SELECT Urun, Kategorisi, Fiyati FROM (SELECT Urun, Kategorisi, Fiyati FROM Kahvaltilik UNION ALL SELECT Urun, Kategorisi, Fiyati FROM EtUrunleri UNION ALL SELECT Urun, Kategorisi, Fiyati FROM Caylar UNION ALL SELECT Urun, Kategorisi, Fiyati FROM Baharatlar UNION ALL SELECT Urun, Kategorisi, Fiyati FROM Mezeler) AS AllProducts WHERE Urun = @urun";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@urun", urun);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string[] row = { reader["Urun"].ToString(), reader["Kategorisi"].ToString(), reader["Fiyati"].ToString(), "1" }; // Varsayılan adet olarak "1" ekledik
                    KB_datagrSepet.Rows.Add(row);
                }
                connection.Close();

                UpdateTotalPrice();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veritabanı hatası: {ex.Message}");
                connection.Close();
            }
        }

        private void KB_btnCogalt_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in KB_datagrSepet.SelectedRows)
            {
                int currentAdet = int.Parse(row.Cells["Adet"].Value.ToString());
                row.Cells["Adet"].Value = (currentAdet + 1).ToString();
                KB_txtBxSayi.Text = row.Cells["Adet"].Value.ToString();
            }

            UpdateTotalPrice();
        }

        private void KB_btnAzalt_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in KB_datagrSepet.SelectedRows)
            {
                int currentAdet = int.Parse(row.Cells["Adet"].Value.ToString());
                if (currentAdet > 1)
                {
                    row.Cells["Adet"].Value = (currentAdet - 1).ToString();
                    KB_txtBxSayi.Text = row.Cells["Adet"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Ürün adeti en az 1 olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            UpdateTotalPrice();
        }

        private void KB_btnSepetTmz_Click(object sender, EventArgs e)
        {
            KB_datagrSepet.Rows.Clear();
            UpdateTotalPrice();
        }

        private void KB_btnTemizle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < KB_chkBxUrunler.Items.Count; i++)
            {
                KB_chkBxUrunler.SetItemChecked(i, false);
            }
        }

        private void KB_btnSiparisVer_Click(object sender, EventArgs e)
        {
            if (KB_chkBxUrunler.CheckedItems.Count == 0)
            {
                MessageBox.Show("Lütfen ürün seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedMusteri = kullaniciTipi == "Yönetici" ? KB_chkBxMusteriSec.SelectedItem?.ToString() : kullaniciAdi;

            if (selectedMusteri == null)
            {
                MessageBox.Show("Bir müşteri seçmelisiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                connection.Open();

                foreach (DataGridViewRow row in KB_datagrSepet.Rows)
                {
                    if (row.IsNewRow) continue;

                    string urun = row.Cells["Urun"].Value.ToString();
                    string kategori = row.Cells["Kategorisi"].Value.ToString();
                    decimal fiyat = decimal.Parse(row.Cells["Fiyati"].Value.ToString());
                    int adet = int.Parse(row.Cells["Adet"].Value.ToString());
                    decimal tutar = fiyat * adet;
                    DateTime alinanTarih = DateTime.Now;

                    string query = "INSERT INTO MusteriTablo (MusteriAdi, AlinanUrun, Adedi, AlinanTarih, Tutar) VALUES (@MusteriAdi, @AlinanUrun, @Adedi, @AlinanTarih, @Tutar)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MusteriAdi", selectedMusteri);
                    command.Parameters.AddWithValue("@AlinanUrun", urun);
                    command.Parameters.AddWithValue("@Adedi", adet);
                    command.Parameters.AddWithValue("@AlinanTarih", alinanTarih);
                    command.Parameters.AddWithValue("@Tutar", tutar);

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Sipariş başarıyla verildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KB_datagrSepet.Rows.Clear();
                UpdateTotalPrice();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sipariş verme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }

        private void KB_btnUrunEkle_Click(object sender, EventArgs e)
        {
            UrunEkleme urunekleme = new UrunEkleme();
            urunekleme.Show();
            this.Hide();
        }

        private void KB_btnSiparislerim_Click(object sender, EventArgs e)
        {
            this.Hide();
            Siparislerim siparislerimForm = new Siparislerim(kullaniciAdi);
            siparislerimForm.Show();
        }

        private void KB_btnSiparisListele_Click(object sender, EventArgs e)
        {
            SiparisListele siparislistele = new SiparisListele();
            siparislistele.Show();
            this.Hide();
        }

        private void KB_btnUrunSilme_Click(object sender, EventArgs e)
        {
            UrunSilme urunsilme = new UrunSilme();
            urunsilme.Show();
            this.Hide();
        }

        private void UpdateTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (DataGridViewRow row in KB_datagrSepet.Rows)
            {
                if (row.IsNewRow) continue;

                decimal fiyat = decimal.Parse(row.Cells["Fiyati"].Value.ToString());
                int adet = int.Parse(row.Cells["Adet"].Value.ToString());
                totalPrice += fiyat * adet;
            }
            KB_lblToplamTutar.Text = $"Toplam Tutar: {totalPrice} ₺";
        }

        private void KB_btnAnaGrs_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void KB_chkBxMusteriSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            KB_datagrSepet.Rows.Clear();
            UpdateTotalPrice(); // toplam fiyatı güncelleme yapan metoddur.
        }
    }
}
