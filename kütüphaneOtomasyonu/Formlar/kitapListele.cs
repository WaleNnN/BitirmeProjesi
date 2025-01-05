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
            MySqlCommand komut = new MySqlCommand("Update kitaplar set KitapAdi='"+txtKitapAdi.Text+"',Yazari='"+txtYazar.Text+"',Yayınevi='"+txtYayinevi.Text+"',Sayfasayisi='"+txtSayfasayisi.Text+"',Aciklama='"+txtAciklama.Text+"' Where KitapID='"+txtKitapID.Text+"'",connect);
            komut.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Güncelleme Başarılı");
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

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtKitapID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtKitapAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtYazar.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtYayinevi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtSayfasayisi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtAciklama.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("Server='localhost';Database='kutuphane';Uid='root';Pwd='233789975668mM_'");
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from kitaplar where KitapAdi like '%" + txtkitapara.Text + "%'", connect);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
