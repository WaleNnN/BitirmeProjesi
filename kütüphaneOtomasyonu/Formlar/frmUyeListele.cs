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
            
                MySqlConnection connect = new MySqlConnection("Server=localhost;Database=kutuphane;Uid=root;Pwd='233789975668mM_'");
                string komut = "select * from Uyeler";
                MySqlDataAdapter da = new MySqlDataAdapter(komut, connect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
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
    }
}
