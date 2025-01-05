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
using System.Runtime.Remoting.Contexts;
using System.Xml.Linq;
using System.IO;

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

   
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
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

      

        private void txtAdSoyadAra_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("Server='localhost';Database='kutuphane';Uid='root';Pwd='233789975668mM_'");
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new  MySqlDataAdapter("Select * from Uyeler where AdiSoyadi like '%"+txtAdSoyadAra.Text+"%'" ,connect);       
            da.Fill(dt);
            dataGridView1.DataSource= dt;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Geçerli bir satır tıklandıysa
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                txtUyeID.Text = selectedRow.Cells["UyeID"].Value.ToString();
                txtAdiSoyadi.Text = selectedRow.Cells["AdiSoyadi"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["email"].Value.ToString();
                txtTelefon.Text = selectedRow.Cells["Telefon"].Value.ToString();
                txtAdres.Text = selectedRow.Cells["Adres"].Value.ToString();
            }
        }

        private void txtUyeID_Click(object sender, EventArgs e)
        {
            txtUyeID.Text = "";
            txtAdiSoyadi.Text = "";
            txtTelefon.Text = "";
            txtAdres.Text = "";
            txtEmail.Text = "";
        }
    }
    }

