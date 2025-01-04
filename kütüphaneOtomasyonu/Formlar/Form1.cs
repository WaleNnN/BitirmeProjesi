using kütüphaneOtomasyonu.Formlar;
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
using MySql.Data;

namespace kütüphaneOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kuladi = textBox1.Text;
            string sifre = textBox2.Text;
            if(kuladi == "1" &&  sifre == "1")
            {
                formAnasayfa frmanasayfa = new formAnasayfa();
                frmanasayfa.Show();
                this.Hide();
            }
            ////////////////////////////////
            

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            yenikullanıcı_ekranı yeni = new yenikullanıcı_ekranı();
            yeni.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=kutuphane;Uid=root;Pwd=233789975668mM_";
            MySqlConnection connect = new MySqlConnection(connectionString);

               // Kullanıcı adı ve şifreyi kontrol eden sorgu
                string sorgu = $"SELECT KullaniciAdi, AdiSoyadi, Telefon, Adres, email FROM Uyeler WHERE KullaniciAdi = '{textBox1.Text}' AND Sifre = '{textBox2.Text}'";

                MySqlCommand komut = new MySqlCommand(sorgu, connect);

                connect.Open();
                MySqlDataReader reader = komut.ExecuteReader();

                if (reader.Read())
                {
                    // Kullanıcı bilgilerini al
                    string kullaniciAdi = reader["KullaniciAdi"].ToString();
                    string adiSoyadi = reader["AdiSoyadi"].ToString();
                    string telefon = reader["Telefon"].ToString();
                    string adres = reader["Adres"].ToString();
                    string emaill = reader["email"].ToString();

                    // Kullanıcı ekranına bilgileri gönder
                    kullanıcıekranı kul = new kullanıcıekranı();
                    kul.txtadisoyadi.Text = adiSoyadi;
                    kul.txttel.Text = telefon;
                    kul.txtadres.Text = adres;
                    kul.txtemail.Text = emaill;
                    kul.ShowDialog();
                  
                }
                else
                {
                    // Hatalı giriş
                    MessageBox.Show("Hatalı kullanıcı adı veya şifre.");
                }

                reader.Close();
            connect.Close();
        }
            
           
            
        }
    }
