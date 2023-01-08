using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class vardiya : Form
    {
        public vardiya()
        {
            InitializeComponent();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)//çarpı butonu
        {
            Application.Exit();
        }

        private void image_geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vardiya_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personel_sistemiDataSet.kampus_ici' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kampus_iciTableAdapter.Fill(this.personel_sistemiDataSet.kampus_ici);
            // TODO: Bu kod satırı 'personel_sistemiDataSet.kampus_giris' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kampus_girisTableAdapter.Fill(this.personel_sistemiDataSet.kampus_giris);
            // TODO: Bu kod satırı 'personel_sistemiDataSet.kampus_giris' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kampus_girisTableAdapter.Fill(this.personel_sistemiDataSet.kampus_giris);
            // TODO: Bu kod satırı 'personel_sistemiDataSet.kampus_ici' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            

        }
        //mouse tıklayıp gezdirince program taşınıyo
        bool move;
        int mouse_x;
        int mouse_y;

        private void vardiya_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void vardiya_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void vardiya_MouseUp(object sender, MouseEventArgs e)
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
    }
}
