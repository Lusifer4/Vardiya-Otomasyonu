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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApp1
{
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }
        yeni_kullanici yeni = new yeni_kullanici();
        DataSet daset = new DataSet();
        private void btn_Personel_Click(object sender, EventArgs e)//personel ekle
        {
            yeni.ShowDialog();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)//geri tuşu
        {
            this.Close();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)//çarpı
        {
            Application.Exit();
        }

        private void Personel_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personel_sistemiDataSet1.personel_tablo' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personel_tabloTableAdapter.Fill(this.personel_sistemiDataSet1.personel_tablo);
            

        }
        static string conString = "Data Source=.;Initial Catalog=personel_sistemi;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);

        private void personel_DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)//tablodan texboxlara aktarma
        {
            txt_sicil.Text = personel_DataGrid.CurrentRow.Cells[0].Value.ToString();
            txt_TC.Text = personel_DataGrid.CurrentRow.Cells[1].Value.ToString();
            txt_Ad.Text = personel_DataGrid.CurrentRow.Cells[2].Value.ToString();
            txt_Soyad.Text = personel_DataGrid.CurrentRow.Cells[3].Value.ToString();
            box_cinsiyet.Text = personel_DataGrid.CurrentRow.Cells[4].Value.ToString();
            box_level.Text = personel_DataGrid.CurrentRow.Cells[5].Value.ToString();
            box_görevi.Text = personel_DataGrid.CurrentRow.Cells[6].Value.ToString();
            txt_Tel.Text = personel_DataGrid.CurrentRow.Cells[7].Value.ToString();
            txt_Eposta.Text = personel_DataGrid.CurrentRow.Cells[8].Value.ToString();
            txt_Adres.Text = personel_DataGrid.CurrentRow.Cells[9].Value.ToString();         
        }

        private void txt_ara_Enter(object sender, EventArgs e)
        {
            if (txt_ara.Text== "TC ile arama yap")
            {
                txt_ara.Text = "";
            }
        }

        private void txt_ara_Leave(object sender, EventArgs e)
        {
            if (txt_ara.Text == "")
            {
                txt_ara.Text = "TC ile arama yap";
            }
        }
       

        private void txt_ara_OnValueChanged(object sender, EventArgs e)//tc ile arama yapıyor
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select*from personel_tablo where TC like '%" + txt_ara.Text + "%'", baglanti);
            adtr.Fill(tablo);
            personel_DataGrid.DataSource = tablo;
            baglanti.Close();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)//güncelle
        {
            if (box_level.Text == "Müdür")
            {
                try
                {
                    baglanti.Open();
                    string update = "update mudur_tablo set TC=@TC,ad=@ad,soyad=@soyad,cinsiyet=@cinsiyet,level=@level,tel=@tel,eposta=@eposta,adres=@adres where TC=@TC";
                    SqlCommand komut = new SqlCommand(update, baglanti);
                    komut.Parameters.AddWithValue("TC", Convert.ToString(txt_TC.Text));
                    komut.Parameters.AddWithValue("ad", Convert.ToString(txt_Ad.Text));
                    komut.Parameters.AddWithValue("soyad", Convert.ToString(txt_Soyad.Text));
                    komut.Parameters.AddWithValue("cinsiyet", Convert.ToString(box_cinsiyet.Text));
                    komut.Parameters.AddWithValue("level", Convert.ToString(box_level.Text));
                    
                    komut.Parameters.AddWithValue("tel", Convert.ToString(txt_Tel.Text));
                    komut.Parameters.AddWithValue("eposta", Convert.ToString(txt_Eposta.Text));
                    komut.Parameters.AddWithValue("adres", Convert.ToString(txt_Adres.Text));
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Bilgiler Güncellendi");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bilgiler Güncellenirken hata oldu " + ex);
                }
                finally
                {
                    baglanti.Close();
                    verileri_göster();
                }
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string update = "update personel_tablo set TC=@TC,ad=@ad,soyad=@soyad,cinsiyet=@cinsiyet,level=@level,gorevi=@gorevi,tel=@tel,eposta=@eposta,adres=@adres where TC=@TC";
                    SqlCommand komut = new SqlCommand(update, baglanti);
                    komut.Parameters.AddWithValue("TC", Convert.ToString(txt_TC.Text));
                    komut.Parameters.AddWithValue("ad", Convert.ToString(txt_Ad.Text));
                    komut.Parameters.AddWithValue("soyad", Convert.ToString(txt_Soyad.Text));
                    komut.Parameters.AddWithValue("cinsiyet", Convert.ToString(box_cinsiyet.Text));
                    komut.Parameters.AddWithValue("level", Convert.ToString(box_level.Text));
                    komut.Parameters.AddWithValue("gorevi", Convert.ToString(box_görevi.Text));
                    komut.Parameters.AddWithValue("tel", Convert.ToString(txt_Tel.Text));
                    komut.Parameters.AddWithValue("eposta", Convert.ToString(txt_Eposta.Text));
                    komut.Parameters.AddWithValue("adres", Convert.ToString(txt_Adres.Text));
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Bilgiler Güncellendi");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bilgiler Güncellenirken hata oldu " + ex);
                }
                finally
                {
                    baglanti.Close();
                    verileri_göster();
                }
            }


        }

        private void btn_Sil_Click(object sender, EventArgs e)//sil 
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from personel_tablo where TC='" + personel_DataGrid.CurrentRow.Cells[1].Value.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();

                
                MessageBox.Show("bir kişi daha işinden oldu");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı silerken hata alındı! " + ex);
            }
            finally
            {
                baglanti.Close();
                verileri_göster();
            }

        }
       
        bool move;
        int mouse_x;
        int mouse_y;
        private void Personel_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Personel_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void Personel_MouseUp(object sender, MouseEventArgs e)
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

        public void formHarfGirisSorgusu(KeyPressEventArgs e)
        {
            //MessageBox.Show("wads");

            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        public void formRakamGirisSorgusu(KeyPressEventArgs e)
        {
            //MessageBox.Show("wads");
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);


        }

        private void txt_TC_KeyPress(object sender, KeyPressEventArgs e)
        {
            formRakamGirisSorgusu(e);
        }

        private void txt_Tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            formRakamGirisSorgusu(e);
        }

        private void txt_Ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            formHarfGirisSorgusu(e);
        }

        private void txt_Soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            formHarfGirisSorgusu(e);
        }

        private void verileri_göster()
        {
            string yenile = "Select * from personel_tablo";
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(yenile,baglanti);
            SqlCommandBuilder komut = new SqlCommandBuilder(da);
            DataSet dset = new DataSet();
            da.Fill(dset, "personel_tablo");
            personel_DataGrid.DataSource = dset.Tables[0];
            baglanti.Close();
        }
    }
}
