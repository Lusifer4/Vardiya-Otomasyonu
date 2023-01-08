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
    public partial class Mudur : Form
    {
        public Mudur()
        {
            InitializeComponent();
        }
        Personel per = new Personel();
        vardiya vardiya = new vardiya();
        Gecmis gecmis = new Gecmis();
        private void bunifuImageButton1_Click(object sender, EventArgs e)//çarpı
        {
            Application.Exit();
        }
        
        private void btn_Personelekle_Click(object sender, EventArgs e)//Personel butonu
        {
            
            per.ShowDialog();
        }

        private void image_geri_Click(object sender, EventArgs e)//geri tuşu
        {
            this.Close();
        }

        
        //mausele hereketleri
        bool move;
        int mouse_x;
        int mouse_y;
        private void Mudur_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Mudur_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void Mudur_MouseUp(object sender, MouseEventArgs e)
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

        
        private void btn_Vardiyadegis_Click(object sender, EventArgs e)//vardiya değiştir butonu
        {
            vardiya.ShowDialog();
        }


        
        private void btn_Gecmis_Click(object sender, EventArgs e)//vardiya geçmişi butonu
        {
            gecmis.ShowDialog();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
