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
    public partial class Gecmis : Form
    {
        public Gecmis()
        {
            InitializeComponent();
        }

        private void image_geri_Click(object sender, EventArgs e)//geri tuşu
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)//çarpı tuşu
        {
            Application.Exit();
        }


    }
}
