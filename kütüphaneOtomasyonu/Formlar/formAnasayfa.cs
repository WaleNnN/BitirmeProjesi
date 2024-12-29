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
{// githuba proje göndermek için kullandım 
    public partial class formAnasayfa : Form
    {
        public formAnasayfa()
        {
            InitializeComponent();
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            frmUyeEkle frmUyeEkle = new frmUyeEkle();
            frmUyeEkle.ShowDialog();
            
        }

        private void btnUyeListele_Click(object sender, EventArgs e)
        {
            frmUyeListele frmUyeListele = new frmUyeListele();  
            frmUyeListele.ShowDialog();
        }

       

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            frmKitapEkle kitapEkle = new frmKitapEkle();
            kitapEkle.ShowDialog();
        }

        private void btnKitapListele_Click(object sender, EventArgs e)
        {
            kitapListele kitapListele = new kitapListele(); 
            kitapListele.ShowDialog();
        }

        private void btnEmanetKitaplar_Click(object sender, EventArgs e)
        {
            emanetKitaplar emanetKitaplar = new emanetKitaplar();
            emanetKitaplar.ShowDialog();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnİadeKitaplar_Click(object sender, EventArgs e)
        {
            iadeKitaplar iade = new iadeKitaplar();
            iade.ShowDialog();
        }
    }
}
