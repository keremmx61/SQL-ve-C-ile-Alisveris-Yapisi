using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _10019KeremBasakoglu
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        private string username;
        private string userType;

        public Form1()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }

        private void InitializeDatabaseConnection()
        {
            string connectionString = @"Data Source=KEREM\SQLEXPRESS;Initial Catalog=ManavDB;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KB_cmbBx.Items.Add("Yönetici");
            KB_cmbBx.Items.Add("Müşteri");

            KB_txtBxSifre.UseSystemPasswordChar = true;
        }

        private void KB_btnGiris_Click(object sender, EventArgs e)
        {
            username = KB_txtBxAd.Text;
            string password = KB_txtBxSifre.Text;
            userType = KB_cmbBx.SelectedItem?.ToString();

            if (ValidateUser(username, password, userType))
            {
                MessageBox.Show("Başarıyla giriş yapıldı!", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AnaSayfa anaSayfa = new AnaSayfa(username, userType);
                anaSayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı, şifre veya kullanıcı tipi yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateUser(string username, string password, string userType)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM Kullanicilar WHERE KullaniciAdi = @username AND Sifre = @password AND KullaniciTipi = @userType";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@userType", userType);

                connection.Open();
                int userCount = (int)command.ExecuteScalar();
                connection.Close();

                return userCount > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veritabanı hatası: {ex.Message}");
                connection.Close();
                return false;
            }
        }

        private void KB_cmbBx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}