using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphaneOtomasyonu.Formlar
{
    public partial class kitapListele : Form
    {
        public kitapListele()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void kitapListele_Load(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("Server='localhost';Database='kutuphane';Uid='root';Pwd='233789975668mM_'");
            connect.Open();
            string komut2 = "select * from kitaplar";
           
            MySqlDataAdapter da = new MySqlDataAdapter(komut2, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("Server='localhost';Database='kutuphane';Uid='root';Pwd='233789975668mM_'");
            connect.Open();
            string seto = " ";
            string komut = "update kitaplar set ";
            if (txtKitapAdi.Text != "")
            {
                seto += "KitapAdi='" + txtKitapAdi.Text + "' ";
            }
            if (txtYazar.Text != "")
            {
                seto += "Yazari='" + txtYazar.Text + "' ";
            }
            if (txtYayinevi.Text != "")
            {

                seto += "Yayınevi='" + txtYayinevi.Text + "' ";
            }
            if (txtSayfasayisi.Text != "")
            {
                seto += "SayfaSayisi='" + txtSayfasayisi.Text + "' ";
            }
            if (txtAciklama.Text != "")
            {
                seto += "Aciklama='" + txtAciklama.Text + "' ";
            }
            komut += seto + "where KitapID= "+txtKitapID.Text;
            MySqlCommand komut1 = new MySqlCommand(komut, connect);
            komut1.ExecuteNonQuery();

            connect.Close();
            string komut2 = "select * from kitaplar";
            connect.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(komut2, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("Server='localhost';Database='kutuphane';Uid='root';Pwd='233789975668mM_'");
            connect.Open();
            MySqlCommand komut = new MySqlCommand($"delete from kitaplar where KitapID={txtKitapID.Text}", connect);
            komut.ExecuteNonQuery();
            connect.Close();
            string komut2 = "select * from kitaplar";
            connect.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(komut2, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }
    }
}
