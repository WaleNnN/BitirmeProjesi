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
            string seto = " ";
            string komut = "update uyeler set ";
            if (txtAdiSoyadi.Text != "")
            {
                seto += "AdiSoyadi='"+ txtAdiSoyadi.Text+"' ";
            }
            if (txtTelefon.Text != "")
            {
                seto += "Telefon='" + txtTelefon.Text + "' ";
            }
            if (txtAdres.Text != "")
            {

                seto += "Adres='" + txtAdres.Text + "' ";
            }
            if (txtEmail.Text != "")
            {
                seto += "email='" + txtEmail.Text + "' ";
            }
            komut += seto +"where UyeId= "+txtUyeID.Text;
            MySqlCommand komut1=new MySqlCommand(komut,connect);
            komut1.ExecuteNonQuery();

            connect.Close();
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
    }
}
