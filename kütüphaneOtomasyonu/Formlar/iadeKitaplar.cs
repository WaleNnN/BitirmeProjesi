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
    public partial class iadeKitaplar : Form
    {
        public iadeKitaplar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iadeKitaplar_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("Server='localhost';Database='kutuphane';Uid='root';Pwd='233789975668mM_'");
            connect.Open();
            MySqlCommand komut = new MySqlCommand($"delete from EmanetKitaplar where KitapID={iadeKitapID.Text} and UyeID={iadeuyeID.Text}", connect);
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("Server='localhost';Database='kutuphane';Uid='root';Pwd='233789975668mM_'");
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from emanetkitaplar where UyeID like '%" + txtUyeIDara.Text + "%'", connect);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Geçerli bir satır tıklandıysa
            {
                DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];
                iadeuyeID.Text = selectedRow.Cells["UyeID"].Value.ToString();
            }
        }

        private void dataGridView3_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Geçerli bir satır tıklandıysa
            {
                DataGridViewRow selectedRow = dataGridView3.Rows[e.RowIndex];
                iadeKitapID.Text = selectedRow.Cells["KitapID"].Value.ToString();
            }
        }

        private void iadeuyeID_TextChanged(object sender, EventArgs e)
        {
            iadeuyeID.Enabled = false;  
        }

        private void iadeKitapID_TextChanged(object sender, EventArgs e)
        {
            iadeKitapID.Enabled = false;
        }
    }
}
