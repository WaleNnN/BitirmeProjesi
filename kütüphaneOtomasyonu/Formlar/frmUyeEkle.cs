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
using System.Runtime.Remoting.Contexts;

namespace kütüphaneOtomasyonu.Formlar
{
    public partial class frmUyeEkle : Form
    {
        public frmUyeEkle()
        {
            InitializeComponent();
        }

     
        frmUyeListele frmlistele = new frmUyeListele();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("Server='localhost';Database='kutuphane';Uid='root';Pwd='233789975668mM_'");
            string sorgu = $"INSERT INTO uyeler (UyeID, AdiSoyadi, Telefon, Adres, email, KayitTarihi) " +
                   $"VALUES ('{txtUyeID.Text}', '{txtAdiSoyadi.Text}', '{txtTelefon.Text}', '{txtAdres.Text}', '{txtEmail.Text}', NOW())";

            MySqlCommand komut = new MySqlCommand(sorgu, connect);
            connect.Open();
            komut.ExecuteNonQuery(); // ExecuteReader yerine ExecuteNonQuery kullanılır
            MessageBox.Show("Üye başarı ile eklendi");


        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
