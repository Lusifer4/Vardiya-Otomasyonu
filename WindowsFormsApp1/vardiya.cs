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
            
           // tablo.Columns.Add("ID", typeof(string));
           // tablo.Columns.Add("GİDER", typeof(string));
            //tablo.Columns.Add("TUTAR", typeof(string));
           // data_pazartesi_0.DataSource = tablo;


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

        private void btn_vardiaOlustur_Click(object sender, EventArgs e)
        {
            /**/

            // TODO: Bu kod satırı 'personel_sistemiDataSet.kampus_ici' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kampus_iciTableAdapter.Fill(this.personel_sistemiDataSet.kampus_ici);
            // TODO: Bu kod satırı 'personel_sistemiDataSet.kampus_giris' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.

            // TODO: Bu kod satırı 'personel_sistemiDataSet.kampus_giris' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //   this.kampus_girisTableAdapter.Fill(this.personel_sistemiDataSet.kampus_giris);
            // TODO: Bu kod satırı 'personel_sistemiDataSet.kampus_ici' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.



            /*   string yenile = "Select * from kampus_giris ";
               baglanti.Open();
               SqlDataAdapter da = new SqlDataAdapter(yenile, baglanti);
               SqlCommandBuilder komut = new SqlCommandBuilder(da);*/


            /*DataSet dset = new DataSet();
            da.Fill(dset, "kampus_giris");
            data_pazartesi_0.DataSource = dset.Tables[0];*/




            /*
            List<string> veriler = new List<string>();
            while (komut.Read())
            {
                veriler.Add(komut["sütun_adi"].ToString());
            }*/



            /*
           connection.Open();
            string sql = "Select * from kampus_giris ";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            List<string> veriler = new List<string>();
            while (reader.Read())
            {
                veriler.Add(reader["08:00-16:00"].ToString());    
                veriler.Add(reader["16:00-24:00"].ToString());
                veriler.Add(reader["00:00-08:00"].ToString());
                // data_pazartesi_0.DataSource = veriler.ToArray();

            }
        

            int currentIndex = 0;

            while (currentIndex < veriler.Count)
            {
                string currentValue = veriler[currentIndex];
                int index = currentIndex + 1;

                // Do something with the current value and the index
                // ...

                currentIndex++;


       



                MessageBox.Show(currentValue);
                //data_pazartesi_0.DataSource = tablo;
                // Console.WriteLine(currentValue);

                /*  for (int i = 0; i < currentValue.Count; i += 3)
                  {
                      Console.Write(currentValue[i] + " ");
                      Console.Write(currentValue[i + 1] + " ");
                      Console.Write(currentValue[i + 2] + " ");
                      Console.WriteLine();
                  }*/
            /*  for (int i = 0; i < veriler.Count; i += 3)
              {
                  Console.Write(currentValue[i] + " ");
                  Console.Write(currentValue[i + 1] + " ");
                  Console.Write(currentValue[i + 2] + " ");
                  Console.WriteLine();
              }

          }*/


            // sql ile veritabanındaki kampus_giris adlı tabloyu çekip datagridview'e aktarma
            /*  string sql = "Select * from kampus_giris ";
              SqlDataAdapter da = new SqlDataAdapter(sql, connection);
              DataTable dt = new DataTable();
              da.Fill(dt);
              data_pazartesi_0.DataSource = dt;*/



            // sql ile veritabanındaki kampus_giris adlı tabloyu çekiyoruz ve gelen veri aynı satırda olmamasını kontrol ediyoru ve data_pazartesi_0 adlı datagridview'e aktarıyoruz

            string sql = "Select * from kampus_giris ";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            data_pazartesi_0.DataSource = dt;

            connection.Close();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncikti_Click(object sender, EventArgs e)
        {

            //  datagridview'leri excel halinde çıktı alıyoruz

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
              excel.Visible = true;
              excel.Application.Workbooks.Add(Type.Missing);
              for (int i = 1; i < data_ici_pazartesi_8.Columns.Count + 1; i++)
              {
                  excel.Cells[1, i] = data_ici_pazartesi_8.Columns[i - 1].HeaderText;
              }
              for (int i = 0; i < data_ici_pazartesi_8.Rows.Count - 1; i++)
              {
                  for (int j = 0; j < data_ici_pazartesi_8.Columns.Count; j++)
                  {
                      excel.Cells[i + 2, j + 1] = data_ici_pazartesi_8.Rows[i].Cells[j].Value.ToString();
                  }
              }
              excel.Columns.AutoFit();
              excel.Visible = true;
              excel.UserControl = true;

              Microsoft.Office.Interop.Excel.Application excel2 = new Microsoft.Office.Interop.Excel.Application();
              excel2.Visible = true;
              excel2.Application.Workbooks.Add(Type.Missing);
              for (int i = 1; i < data_pazartesi_0.Columns.Count + 1; i++)
              {
                  excel2.Cells[1, i] = data_pazartesi_0.Columns[i - 1].HeaderText;
              }
              for (int i = 0; i < data_pazartesi_0.Rows.Count - 1; i++)
              {
                  for (int j = 0; j < data_pazartesi_0.Columns.Count; j++)
                  {
                      excel2.Cells[i + 2, j + 1] = data_pazartesi_0.Rows[i].Cells[j].Value.ToString();
                  }
              }
              excel2.Columns.AutoFit();
              excel2.Visible = true;
              excel2.UserControl = true;

        }
    }
}
