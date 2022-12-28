using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        
        Mudur mudur = new Mudur();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            
            mudur.ShowDialog();
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
