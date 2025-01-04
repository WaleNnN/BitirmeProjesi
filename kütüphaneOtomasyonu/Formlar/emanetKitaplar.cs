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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kütüphaneOtomasyonu.Formlar
{
    public partial class emanetKitaplar : Form
    {
        public emanetKitaplar()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connect = new MySqlConnection("Server='localhost';Database='kutuphane';Uid='root';Pwd='233789975668mM_'");
                MySqlCommand komut = new MySqlCommand($"insert into EmanetKitaplar values({uyeIDtext.Text},{kitapIdtext.Text},now())", connect);
                connect.Open();
                komut.ExecuteNonQuery();
                connect.Close();


                string komut2 = "select * from EmanetKitaplar";
                connect.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(komut2, connect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connect.Close();
            }
            catch
            {
                MessageBox.Show("Aynı kişiye aynı kitap ödünç verilemez.");
            }

        }

        private void emanetKitaplar_Load(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("Server='localhost';Database='kutuphane';Uid='root';Pwd='233789975668mM_'");
            string komut2 = "select * from EmanetKitaplar";
            connect.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(komut2, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();

            string komut = "SELECT UyeID , AdiSoyadi from Uyeler;";
            connect.Open();
            MySqlDataAdapter da2 = new MySqlDataAdapter(komut, connect);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            connect.Close();

            string komut3 = "SELECT KitapID , KitapAdi from kitaplar;";
            connect.Open();
            MySqlDataAdapter da3 = new MySqlDataAdapter(komut3, connect);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView3.DataSource = dt3;
            connect.Close();
        }



        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Geçerli bir satır tıklandıysa
            {
                DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];
                uyeIDtext.Text = selectedRow.Cells["UyeID"].Value.ToString();
            }
        }

        private void dataGridView3_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Geçerli bir satır tıklandıysa
            {
                DataGridViewRow selectedRow = dataGridView3.Rows[e.RowIndex];
                kitapIdtext.Text = selectedRow.Cells["KitapID"].Value.ToString();
            }
        }

        private void uyeIDtext_TextChanged(object sender, EventArgs e)
        {
            uyeIDtext.Enabled = false;
        }

        private void kitapIdtext_TextChanged(object sender, EventArgs e)
        {
            kitapIdtext.Enabled = false;
        }


    }
}

