using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Giris_ekranı : Form
    {
        public Giris_ekranı()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 90;
        }

        private void lblGiris_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Visible = true;
        }

        


        #region txt
        
        #endregion

        private void txt_Kullanici_Enter(object sender, EventArgs e)
        {
            if (txt_Kullanici.Text== "Kulanici Adı")
            {
                txt_Kullanici.Text = "";
            }
        }

        private void txt_Kullanici_Leave(object sender, EventArgs e)
        {
            if (txt_Kullanici.Text == "")
            {
                txt_Kullanici.Text = "Kulanici Adı";
            }
        }

        private void txt_Parola_Enter(object sender, EventArgs e)//tıklayınca parola yazısı gidiyo
        {
            txt_Parola.isPassword = true;
            if (txt_Parola.Text == "Parola")
            {
                txt_Parola.Text = "";
            }
        }

        private void txt_Parola_Leave(object sender, EventArgs e)
        {
            if (txt_Parola.Text == "")
            {
                txt_Parola.Text = "Parola";
            }
        }

        
        private void bunifuImageButton4_Click(object sender, EventArgs e)//X tuşuna basınca programı kapatıyo
        {
            Application.Exit();
        }

        //mouse tıklayıp gezdirince program taşınıyo
        bool move;
        int mouse_x;
        int mouse_y;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Visible = false;
            if (move==true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }
        
        Mudur Mudur = new Mudur();
        vardiya vardiya = new vardiya();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=.;Initial Catalog=personel_sistemi;Integrated Security=True";
            SqlConnection baglanti = new SqlConnection(conString);
            string sorgu1 = "SELECT * FROM mudur_tablo where eposta=@eposta AND TC=@TC";
            string sorgu2 = "SELECT * FROM personel_tablo where eposta=@eposta AND TC=@TC";


            string kulanici = txt_Kullanici.Text;
            string sifre = txt_Parola.Text;
            
            

           
            if (Checkbox_yonetici.Checked == true)
            {
                SqlCommand komut1 = new SqlCommand(sorgu1, baglanti);
                komut1.Parameters.AddWithValue("@eposta", txt_Kullanici.Text);
                komut1.Parameters.AddWithValue("@TC", txt_Parola.Text);

                SqlDataReader data;
                baglanti.Open();
                data = komut1.ExecuteReader();
                if (data.Read())
                {
                    Mudur.ShowDialog();
                }
                else { MessageBox.Show("Kullanıcı Adı veya Şifre HATALI"); }
                baglanti.Close();
            }
            else
            {
                SqlCommand komut2 = new SqlCommand(sorgu2, baglanti);
                komut2.Parameters.AddWithValue("@eposta", txt_Kullanici.Text);
                komut2.Parameters.AddWithValue("@TC", txt_Parola.Text);
                SqlDataReader data;
                baglanti.Open();
                data = komut2.ExecuteReader();
                if (data.Read())
                {
                    vardiya.ShowDialog();
                }
                else { MessageBox.Show("Kullanıcı Adı veya Şifre HATALI"); }
                baglanti.Close();
            }
            
            

            
        }
        //sosyal medya adresleri
        private void img_twiter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/HelheimYaz0");
        }

        private void img_facebook_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yakında...");
        }

        private void img_instagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/helheimyazilim/");
        }
    }
}
