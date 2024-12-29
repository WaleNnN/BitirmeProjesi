using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphaneOtomasyonu.Formlar
{
    public partial class frmKitapEkle : Form
    {
        public frmKitapEkle()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("Server='localhost';Database='kutuphane';Uid='root';Pwd='233789975668mM_'");
            connect.Open();
            MySqlCommand komut = new MySqlCommand($"insert into kitaplar values({txtKitapID.Text},'{txtKitapAdi.Text}','{txtYazar.Text}','{txtYayinevi.Text}','{txtSayfasayisi.Text}','{txtAciklama.Text}',now())", connect);
            komut.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Kitap ekleme başarılı");
            
        }
    }
}
