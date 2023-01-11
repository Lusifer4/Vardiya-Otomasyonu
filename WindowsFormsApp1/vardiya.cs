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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class vardiya : Form
    {
        public vardiya()
        {
            InitializeComponent();
        }


        // sql bağlantısı
        static string conString = "Data Source=.;Initial Catalog=personel_sistemi;Integrated Security=True";
        SqlConnection connection = new SqlConnection(conString);

        private void bunifuImageButton4_Click(object sender, EventArgs e)//çarpı butonu
        {
            Application.Exit();
        }

        private void image_geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataTable tablo = new DataTable();
        private void vardiya_Load(object sender, EventArgs e)
        {
    
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
        { // mouse tıklayıp gezdirince program taşınıyo
            move = false;
        }

        private void btn_vardiaOlustur_Click(object sender, EventArgs e)
        {
            // Butona tıklandığında verileri çekip datagridview'e aktarıyoruz.
            this.kampus_giris3TableAdapter.Fill(this.personel_sistemiDataSet1.kampus_giris3);
             this.kampus_giris2TableAdapter.Fill(this.personel_sistemiDataSet1.kampus_giris2);
            this.kampus_girisTableAdapter1.Fill(this.personel_sistemiDataSet1.kampus_giris);
            this.kampus_ici2TableAdapter.Fill(this.personel_sistemiDataSet1.kampus_ici2);
            this.kampus_iciTableAdapter1.Fill(this.personel_sistemiDataSet1.kampus_ici);

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

    /*    private void btncikti_Click(object sender, EventArgs e)
        {


        }
    */
        private void data_ici_pazartesi_8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
