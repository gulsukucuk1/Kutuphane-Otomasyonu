using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KutuphaneYonetim
{
    public partial class Form1 : Form
    {
        string connectionString =
            "Server=DESKTOP-RATSIB3\\SQLEXPRESS;Database=KutuphaneDB;Trusted_Connection=True;";

        SqlConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        // FORM AÇILINCA
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();

                KitaplariGetir();
                UyeleriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantı hatası:\n" + ex.Message);
            }
        }

        void KitaplariGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Kitaplar", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvKitaplar.DataSource = dt;
        }

        void UyeleriGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Uyeler", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvUyeler.DataSource = dt;
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Kitaplar (KitapAdi, Yazar, Yayinevi, Stok) VALUES (@ad, @yazar, @yayinevi, @stok)",
                    conn
                );

                cmd.Parameters.AddWithValue("@ad", txtKitapAdi.Text);
                cmd.Parameters.AddWithValue("@yazar", txtYazar.Text);
                cmd.Parameters.AddWithValue("@yayinevi", txtYayinevi.Text);
                cmd.Parameters.AddWithValue("@stok", Convert.ToInt32(txtStok.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Kitap eklendi.");

                KitaplariGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap ekleme hatası:\n" + ex.Message);
            }
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Uyeler (AdSoyad, Telefon, Email) VALUES (@ad, @tel, @mail)",
                    conn
                );

                cmd.Parameters.AddWithValue("@ad", txtAdSoyad.Text);
                cmd.Parameters.AddWithValue("@tel", txtTelefon.Text);
                cmd.Parameters.AddWithValue("@mail", txtEmail.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Üye eklendi.");

                UyeleriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Üye ekleme hatası:\n" + ex.Message);
            }
        }

        private void dgvKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKitaplar.Rows[e.RowIndex];
                txtKitapAdi.Text = row.Cells["KitapAdi"].Value?.ToString();
                txtYazar.Text = row.Cells["Yazar"].Value?.ToString();
                txtYayinevi.Text = row.Cells["Yayinevi"].Value?.ToString();
                txtStok.Text = row.Cells["Stok"].Value?.ToString();
            }
        }

        private void dgvUyeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUyeler.Rows[e.RowIndex];
                txtAdSoyad.Text = row.Cells["AdSoyad"].Value?.ToString();
                txtTelefon.Text = row.Cells["Telefon"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }
    }
}
