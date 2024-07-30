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
    public partial class UrunSilme : Form
    {
        private SqlConnection connection;

        public UrunSilme()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }

        private void InitializeDatabaseConnection()
        {
            
            string connectionString = @"Data Source=LAPTOP-5PBS2AD3\SQLEXPRESS;Initial Catalog=ManavDB;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void UrunSilme_Load(object sender, EventArgs e)
        {
            KB_cmbBxKtgr.Items.Add("Kahvaltilik");
            KB_cmbBxKtgr.Items.Add("EtUrunleri");
            KB_cmbBxKtgr.Items.Add("Caylar");
            KB_cmbBxKtgr.Items.Add("Baharatlar");
            KB_cmbBxKtgr.Items.Add("Mezeler");

            
            KB_datagridSilSiparis.Columns.Add("Urun", "Ürün");
            KB_datagridSilSiparis.Columns.Add("Kategorisi", "Kategori");
            KB_datagridSilSiparis.Columns.Add("Fiyati", "Fiyat");

            
            KB_datagridSilSiparis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void KB_btnGoster_Click(object sender, EventArgs e)
        {
            string kategori = KB_cmbBxKtgr.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(kategori))
            {
                MessageBox.Show("Lütfen bir kategori seçin.");
                return;
            }

            
            try
            {
                string query = $"SELECT Urun, Kategorisi, Fiyati FROM {kategori}";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                KB_datagridSilSiparis.Rows.Clear();

                if (!reader.HasRows)
                {
                    MessageBox.Show("Bu kategoride ürün bulunamadı.");
                }

                while (reader.Read())
                {
                    string urun = reader["Urun"].ToString();
                    string kategorisi = reader["Kategorisi"].ToString();
                    string fiyati = reader["Fiyati"].ToString();

                    KB_datagridSilSiparis.Rows.Add(urun, kategorisi, fiyati);
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veritabanı hatası: {ex.Message}\n{ex.StackTrace}");
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void KB_btnSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in KB_datagridSilSiparis.SelectedRows)
            {
                string urun = row.Cells["Urun"].Value.ToString();
                string kategori = KB_cmbBxKtgr.SelectedItem.ToString();

                DialogResult result = MessageBox.Show("Ürünü silmek istediğinize emin misiniz?", "Ürün Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string query = $"DELETE FROM {kategori} WHERE Urun = @Urun";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Urun", urun);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        KB_datagridSilSiparis.Rows.Remove(row);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ürün silme hatası: {ex.Message}\n{ex.StackTrace}");
                        if (connection.State == System.Data.ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
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
