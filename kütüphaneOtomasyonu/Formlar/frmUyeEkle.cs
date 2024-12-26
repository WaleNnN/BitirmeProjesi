using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace kütüphaneOtomasyonu.Formlar
{
    public partial class frmUyeEkle : Form
    {
        public frmUyeEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }
        frmUyeListele frmlistele = new frmUyeListele();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connect = new MySqlConnection("Server='localhost';Database='kutuphane';Uid='root';Pwd='233789975668mM_'");
                MySqlCommand komut = new MySqlCommand($"insert into Uyeler(UyeID,AdiSoyadi,Telefon,Adres,email,Resim,OkunanKitapSayisi,KayitTarihi) values('{txtUyeID.Text}','{txtAdiSoyadi.Text}','{txtTelefon.Text}','{txtAdres.Text}','{txtEmail.Text}','{pictureBox1.ImageLocation}','{txtOkunanKitapSayisi.Text}',now());", connect);
                connect.Open();
                MySqlDataReader veri = komut.ExecuteReader();
                veri.Read();
                connect.Close();
                MessageBox.Show("Üye Başarı ile Eklendi");
            }
            catch{
                MessageBox.Show("Hata oluştu");
            }
            
           
            

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
