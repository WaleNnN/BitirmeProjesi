using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace kütüphaneOtomasyonu.Formlar
{
    public partial class yenikullanıcı_ekranı : Form
    {
        public yenikullanıcı_ekranı()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MySQL bağlantısı
            MySqlConnection connect = new MySqlConnection("Server='localhost';Database='kutuphane';Uid='root';Pwd='233789975668mM_'");

            // SQL sorgusu
            string sorgu = $"INSERT INTO uyeler (UyeID, AdiSoyadi, Telefon, Adres, email, KayitTarihi, KullaniciAdi, Sifre) " +
                $"VALUES ('{txtUyeID.Text}', '{txtadsoyad.Text}', '{txtel.Text}', '{txtadres.Text}', '{txtemail.Text}', NOW(), '{txtkuladi.Text}', '{txtsifre.Text}')";

            try
            {
                // Komut oluşturma
                MySqlCommand komut = new MySqlCommand(sorgu, connect);

                // Bağlantıyı açma
                connect.Open();

                // Sorguyu çalıştırma
                komut.ExecuteNonQuery();

                // Başarılı mesajı
                MessageBox.Show("Üye başarı ile eklendi");
            }
            catch 
            {
                // Hata mesajı
                MessageBox.Show($"Hata üye eklenemedi");
            }
            finally
            {
                // Bağlantıyı kapatma
                connect.Close();
            }
        }
    }
}
