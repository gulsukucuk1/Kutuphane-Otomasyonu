using System.Windows.Forms;

namespace KutuphaneYonetim
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Label lblKitapAdi;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.Label lblYayinevi;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUyeID;
        private System.Windows.Forms.Label lblKitapID;
        private System.Windows.Forms.Label lblIslemID;

        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtYayinevi;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUyeID;
        private System.Windows.Forms.TextBox txtKitapID;
        private System.Windows.Forms.TextBox txtIslemID;

        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Button btnKitapGuncelle;
        private System.Windows.Forms.Button btnKitapSil;
        private System.Windows.Forms.Button btnUyeEkle;
        private System.Windows.Forms.Button btnUyeGuncelle;
        private System.Windows.Forms.Button btnUyeSil;
        private System.Windows.Forms.Button btnOduncVer;
        private System.Windows.Forms.Button btnTeslimAl;

        private System.Windows.Forms.DataGridView dgvKitaplar;
        private System.Windows.Forms.DataGridView dgvUyeler;

        private void InitializeComponent()
        {
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtYayinevi = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUyeID = new System.Windows.Forms.TextBox();
            this.txtKitapID = new System.Windows.Forms.TextBox();
            this.txtIslemID = new System.Windows.Forms.TextBox();

            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.lblYazar = new System.Windows.Forms.Label();
            this.lblYayinevi = new System.Windows.Forms.Label();
            this.lblStok = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUyeID = new System.Windows.Forms.Label();
            this.lblKitapID = new System.Windows.Forms.Label();
            this.lblIslemID = new System.Windows.Forms.Label();

            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.btnKitapGuncelle = new System.Windows.Forms.Button();
            this.btnKitapSil = new System.Windows.Forms.Button();
            this.btnUyeEkle = new System.Windows.Forms.Button();
            this.btnUyeGuncelle = new System.Windows.Forms.Button();
            this.btnUyeSil = new System.Windows.Forms.Button();
            this.btnOduncVer = new System.Windows.Forms.Button();
            this.btnTeslimAl = new System.Windows.Forms.Button();

            this.dgvKitaplar = new System.Windows.Forms.DataGridView();
            this.dgvUyeler = new System.Windows.Forms.DataGridView();

            // Form elemanları yerleştirme ve özellikler
            this.SuspendLayout();

            // Kitap bölümü
            this.lblKitapAdi.Text = "Kitap Adı";
            this.lblKitapAdi.Location = new System.Drawing.Point(20, 20);
            this.txtKitapAdi.Location = new System.Drawing.Point(100, 20);

            this.lblYazar.Text = "Yazar";
            this.lblYazar.Location = new System.Drawing.Point(20, 50);
            this.txtYazar.Location = new System.Drawing.Point(100, 50);

            this.lblYayinevi.Text = "Yayınevi";
            this.lblYayinevi.Location = new System.Drawing.Point(20, 80);
            this.txtYayinevi.Location = new System.Drawing.Point(100, 80);

            this.lblStok.Text = "Stok";
            this.lblStok.Location = new System.Drawing.Point(20, 110);
            this.txtStok.Location = new System.Drawing.Point(100, 110);

            this.btnKitapEkle.Text = "Ekle";
            this.btnKitapEkle.Location = new System.Drawing.Point(20, 150);
            this.btnKitapGuncelle.Text = "Güncelle";
            this.btnKitapGuncelle.Location = new System.Drawing.Point(100, 150);
            this.btnKitapSil.Text = "Sil";
            this.btnKitapSil.Location = new System.Drawing.Point(200, 150);

            this.dgvKitaplar.Location = new System.Drawing.Point(20, 190);
            this.dgvKitaplar.Size = new System.Drawing.Size(400, 150);

            // Üye bölümü
            this.lblAdSoyad.Text = "Ad Soyad";
            this.lblAdSoyad.Location = new System.Drawing.Point(450, 20);
            this.txtAdSoyad.Location = new System.Drawing.Point(530, 20);

            this.lblTelefon.Text = "Telefon";
            this.lblTelefon.Location = new System.Drawing.Point(450, 50);
            this.txtTelefon.Location = new System.Drawing.Point(530, 50);

            this.lblEmail.Text = "Email";
            this.lblEmail.Location = new System.Drawing.Point(450, 80);
            this.txtEmail.Location = new System.Drawing.Point(530, 80);

            this.btnUyeEkle.Text = "Ekle";
            this.btnUyeEkle.Location = new System.Drawing.Point(450, 120);
            this.btnUyeGuncelle.Text = "Güncelle";
            this.btnUyeGuncelle.Location = new System.Drawing.Point(530, 120);
            this.btnUyeSil.Text = "Sil";
            this.btnUyeSil.Location = new System.Drawing.Point(630, 120);

            this.dgvUyeler.Location = new System.Drawing.Point(450, 160);
            this.dgvUyeler.Size = new System.Drawing.Size(400, 150);

            // Ödünç işlemleri
            this.lblUyeID.Text = "Üye ID";
            this.lblUyeID.Location = new System.Drawing.Point(20, 360);
            this.txtUyeID.Location = new System.Drawing.Point(100, 360);

            this.lblKitapID.Text = "Kitap ID";
            this.lblKitapID.Location = new System.Drawing.Point(20, 390);
            this.txtKitapID.Location = new System.Drawing.Point(100, 390);

            this.lblIslemID.Text = "İşlem ID";
            this.lblIslemID.Location = new System.Drawing.Point(20, 420);
            this.txtIslemID.Location = new System.Drawing.Point(100, 420);

            this.btnOduncVer.Text = "Ödünç Ver";
            this.btnOduncVer.Location = new System.Drawing.Point(250, 360);
            this.btnTeslimAl.Text = "Teslim Al";
            this.btnTeslimAl.Location = new System.Drawing.Point(350, 360);

            // Form ayarları
            this.ClientSize = new System.Drawing.Size(880, 480);
            this.Text = "Kütüphane Yönetim Sistemi";

            this.Controls.AddRange(new Control[] {
                txtKitapAdi, txtYazar, txtYayinevi, txtStok,
                lblKitapAdi, lblYazar, lblYayinevi, lblStok,
                btnKitapEkle, btnKitapGuncelle, btnKitapSil,
                dgvKitaplar,
                txtAdSoyad, txtTelefon, txtEmail,
                lblAdSoyad, lblTelefon, lblEmail,
                btnUyeEkle, btnUyeGuncelle, btnUyeSil,
                dgvUyeler,
                txtUyeID, txtKitapID, txtIslemID,
                lblUyeID, lblKitapID, lblIslemID,
                btnOduncVer, btnTeslimAl
            });

            this.ResumeLayout(false);
        }
    }
}
