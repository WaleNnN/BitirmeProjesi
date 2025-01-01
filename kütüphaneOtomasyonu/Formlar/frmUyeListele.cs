using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace kütüphaneOtomasyonu.Formlar
{
    public partial class frmUyeListele : Form
    {
        public frmUyeListele()
        {
            InitializeComponent();
        }

        private void frmUyeListele_Load(object sender, EventArgs e)
        {
            
                MySqlConnection connect = new MySqlConnection("Server='localhost';Database='kutuphane';Uid='root';Pwd='233789975668mM_'");
                string komut = "select * from Uyeler";
            connect.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(komut, connect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connect.Close();
        }

       
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("Server='localhost';Database='kutuphane';Uid='root';Pwd='233789975668mM_'");
            connect.Open();
            MySqlCommand komut = new MySqlCommand("Update Uyeler set AdiSoyadi='" + txtAdiSoyadi.Text + "',Telefon='" + txtTelefon.Text + "',Adres='" + txtAdres.Text + "',email='" + txtEmail.Text + "' where UyeID='"+txtUyeID.Text+"'", connect);
            komut.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Güncelleme Başarılı");
            string komut2 = "select * from Uyeler";
            connect.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(komut2, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("Server='localhost';Database='kutuphane';Uid='root';Pwd='233789975668mM_'");
            connect.Open();
            MySqlCommand komut=new MySqlCommand($"delete from uyeler where UyeId={txtUyeID.Text}",connect);
            komut.ExecuteNonQuery();
            connect.Close();
            string komut2 = "select * from Uyeler";
            connect.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(komut2, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtAdSoyadAra_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("Server='localhost';Database='kutuphane';Uid='root';Pwd='233789975668mM_'");
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new  MySqlDataAdapter("Select * from Uyeler where AdiSoyadi like '%"+txtAdSoyadAra.Text+"%'" ,connect);       
            da.Fill(dt);
            dataGridView1.DataSource= dt;
        }
    }
}
