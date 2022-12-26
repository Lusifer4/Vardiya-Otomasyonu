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
    }
}
