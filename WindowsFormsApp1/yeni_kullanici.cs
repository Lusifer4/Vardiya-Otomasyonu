using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class yeni_kullanici : Form
    {
        public yeni_kullanici()
        {
            InitializeComponent();
        }

        private void yeni_kullanici_Load(object sender, EventArgs e)
        {
            string seciniz = "Seçiniz";
           if(box_cinsiyet.Text == "")
            {
                box_cinsiyet.Text = seciniz;
            }
            if (box_Görevi.Text=="")
            {
                box_Görevi.Text = seciniz;
            }
            if (box_Görevli.Text=="")
            {
                box_Görevli.Text = seciniz;
            }
        }

        static string conString = "Data Source=.;Initial Catalog=personel_sistemi;Integrated Security=True";

        SqlConnection baglanti = new SqlConnection(conString);

        private void bunifuImageButton4_Click(object sender, EventArgs e)//çarpı
        {
            Application.Exit();
        }

        private void txt_TC_Enter(object sender, EventArgs e)
        {
            if (txt_TC.Text == "Türkiye Cumhuriyeti Kimlik Numarası")
            {
                txt_TC.Text = "";
            }
        }

        private void txt_TC_Leave(object sender, EventArgs e)
        {
            if (txt_TC.Text == "")
            {
                txt_TC.Text = "Türkiye Cumhuriyeti Kimlik Numarası";
            }
        }

        private void txt_Ad_Enter(object sender, EventArgs e)
        {
            if (txt_Ad.Text == "Ad")
            {
                txt_Ad.Text = "";
            }
        }

        private void txt_Ad_Leave(object sender, EventArgs e)
        {
            if (txt_Ad.Text == "")
            {
                txt_Ad.Text = "Ad";
            }
        }

        private void txt_Soyad_Enter(object sender, EventArgs e)
        {
            if (txt_Soyad.Text == "Soyad")
            {
                txt_Soyad.Text = "";
            }

        }

        private void txt_Soyad_Leave(object sender, EventArgs e)
        {
            if (txt_Soyad.Text == "")
            {
                txt_Soyad.Text = "Soyad";
            }
        }

        private void txt_Tel_Enter(object sender, EventArgs e)
        {
            if (txt_Tel.Text == "Telefon Numarası")
            {
                txt_Tel.Text = "";
            }
        }

        private void txt_Tel_Leave(object sender, EventArgs e)
        {
            if (txt_Tel.Text == "")
            {
                txt_Tel.Text = "Telefon Numarası";
            }
        }

        private void txt_Eposta_Enter(object sender, EventArgs e)
        {
            if (txt_Eposta.Text == "E-Posta Adresi")
            {
                txt_Eposta.Text = "";
            }
        }

        private void txt_Eposta_Leave(object sender, EventArgs e)
        {
            if (txt_Eposta.Text == "")
            {
                txt_Eposta.Text = "E-Posta Adresi";
            }
        }

        private void txt_Adres_Enter(object sender, EventArgs e)
        {
            if(txt_Adres.Text == "Adres")
            {
                txt_Adres.Text = "";
            }
        }

        private void txt_Adres_Leave(object sender, EventArgs e)
        {
            if (txt_Adres.Text == "")
            {
                txt_Adres.Text = "Adres";
            }
        }
        //mouse tıklayıp gezdirince program taşınıyo

        bool move;
        int mouse_x;
        int mouse_y;
        private void yeni_kullanici_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void yeni_kullanici_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void yeni_kullanici_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void bunifuGradientPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        
        private void image_geri_Click(object sender, EventArgs e)//geri tuşu
        {
            this.Close();
           

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

            string sorgu = "insert into personel_tablo(TC,ad,soyad,cinsiyet,level,gorevi,eposta,adres,tel)values(@TC,@ad,@soyad,@cinsiyet,@level,@gorevi,@eposta,@adres,@tel)";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@TC", txt_TC.Text);
            komut.Parameters.AddWithValue("@ad", txt_Ad.Text);
            komut.Parameters.AddWithValue("@soyad",txt_Soyad.Text) ;
            komut.Parameters.AddWithValue("@cinsiyet",box_cinsiyet.Text);
            komut.Parameters.AddWithValue("@level", box_Görevli.Text);
            komut.Parameters.AddWithValue("@gorevi", box_Görevi.Text);
            komut.Parameters.AddWithValue("@tel", txt_Tel.Text);
            komut.Parameters.AddWithValue("@eposta",txt_Eposta.Text) ;
            komut.Parameters.AddWithValue("@adres", txt_Adres.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            
            MessageBox.Show("Kulanıcı Eklendi");
           

        }
    }
}
