namespace WindowsFormsApp1
{
    partial class yeni_kullanici
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yeni_kullanici));
            this.box_Görevi = new System.Windows.Forms.ComboBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txt_TC = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnkaydet = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_Ad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Soyad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Adres = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Eposta = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Tel = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.box_Görevli = new System.Windows.Forms.ComboBox();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.box_cinsiyet = new System.Windows.Forms.ComboBox();
            this.bunifuMaterialTextbox3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.image_geri = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_sicil = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_geri)).BeginInit();
            this.SuspendLayout();
            // 
            // box_Görevi
            // 
            this.box_Görevi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.box_Görevi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.box_Görevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.box_Görevi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.box_Görevi.IntegralHeight = false;
            this.box_Görevi.Items.AddRange(new object[] {
            "Bekçi",
            "Görevli",
            "Güvenlik Görevlisi",
            "Hizmetli",
            "Memur",
            "Teknik Personel"});
            this.box_Görevi.Location = new System.Drawing.Point(748, 442);
            this.box_Görevi.Name = "box_Görevi";
            this.box_Görevi.Size = new System.Drawing.Size(363, 24);
            this.box_Görevi.TabIndex = 6;
            this.box_Görevi.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txt_TC
            // 
            this.txt_TC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_TC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_TC.HintForeColor = System.Drawing.Color.Empty;
            this.txt_TC.HintText = "";
            this.txt_TC.isPassword = false;
            this.txt_TC.LineFocusedColor = System.Drawing.Color.Black;
            this.txt_TC.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_TC.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txt_TC.LineThickness = 3;
            this.txt_TC.Location = new System.Drawing.Point(748, 125);
            this.txt_TC.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TC.Name = "txt_TC";
            this.txt_TC.Size = new System.Drawing.Size(363, 38);
            this.txt_TC.TabIndex = 1;
            this.txt_TC.Text = "Türkiye Cumhuriyeti Kimlik Numarası";
            this.txt_TC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_TC.Enter += new System.EventHandler(this.txt_TC_Enter);
            this.txt_TC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TC_KeyPress);
            this.txt_TC.Leave += new System.EventHandler(this.txt_TC_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(547, 668);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox5);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton4);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Gray;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Gray;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Gray;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1164, 77);
            this.bunifuGradientPanel1.TabIndex = 3;
            this.bunifuGradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseDown);
            this.bunifuGradientPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseMove);
            this.bunifuGradientPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseUp);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(106, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(160, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(1131, 0);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(33, 33);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bunifuImageButton4.TabIndex = 13;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            this.bunifuImageButton4.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.ActiveBorderThickness = 1;
            this.btnkaydet.ActiveCornerRadius = 20;
            this.btnkaydet.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnkaydet.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnkaydet.ActiveLineColor = System.Drawing.Color.Black;
            this.btnkaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnkaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnkaydet.BackgroundImage")));
            this.btnkaydet.ButtonText = "Kaydet";
            this.btnkaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnkaydet.IdleBorderThickness = 1;
            this.btnkaydet.IdleCornerRadius = 30;
            this.btnkaydet.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnkaydet.IdleForecolor = System.Drawing.Color.Black;
            this.btnkaydet.IdleLineColor = System.Drawing.Color.Gray;
            this.btnkaydet.Location = new System.Drawing.Point(863, 682);
            this.btnkaydet.Margin = new System.Windows.Forms.Padding(5);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(248, 50);
            this.btnkaydet.TabIndex = 10;
            this.btnkaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnkaydet.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txt_Ad
            // 
            this.txt_Ad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_Ad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Ad.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Ad.HintText = "";
            this.txt_Ad.isPassword = false;
            this.txt_Ad.LineFocusedColor = System.Drawing.Color.Black;
            this.txt_Ad.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Ad.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txt_Ad.LineThickness = 3;
            this.txt_Ad.Location = new System.Drawing.Point(748, 180);
            this.txt_Ad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(363, 38);
            this.txt_Ad.TabIndex = 2;
            this.txt_Ad.Text = "Ad";
            this.txt_Ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Ad.Enter += new System.EventHandler(this.txt_Ad_Enter);
            this.txt_Ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Ad_KeyPress);
            this.txt_Ad.Leave += new System.EventHandler(this.txt_Ad_Leave);
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_Soyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Soyad.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Soyad.HintText = "";
            this.txt_Soyad.isPassword = false;
            this.txt_Soyad.LineFocusedColor = System.Drawing.Color.Black;
            this.txt_Soyad.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Soyad.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txt_Soyad.LineThickness = 3;
            this.txt_Soyad.Location = new System.Drawing.Point(748, 226);
            this.txt_Soyad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(363, 47);
            this.txt_Soyad.TabIndex = 3;
            this.txt_Soyad.Text = "Soyad";
            this.txt_Soyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Soyad.Enter += new System.EventHandler(this.txt_Soyad_Enter);
            this.txt_Soyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Soyad_KeyPress);
            this.txt_Soyad.Leave += new System.EventHandler(this.txt_Soyad_Leave);
            // 
            // txt_Adres
            // 
            this.txt_Adres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_Adres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Adres.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Adres.HintText = "";
            this.txt_Adres.isPassword = false;
            this.txt_Adres.LineFocusedColor = System.Drawing.Color.Black;
            this.txt_Adres.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Adres.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txt_Adres.LineThickness = 3;
            this.txt_Adres.Location = new System.Drawing.Point(748, 585);
            this.txt_Adres.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Adres.Name = "txt_Adres";
            this.txt_Adres.Size = new System.Drawing.Size(363, 88);
            this.txt_Adres.TabIndex = 9;
            this.txt_Adres.Text = "Adres";
            this.txt_Adres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Adres.Enter += new System.EventHandler(this.txt_Adres_Enter);
            this.txt_Adres.Leave += new System.EventHandler(this.txt_Adres_Leave);
            // 
            // txt_Eposta
            // 
            this.txt_Eposta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Eposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_Eposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Eposta.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Eposta.HintText = "";
            this.txt_Eposta.isPassword = false;
            this.txt_Eposta.LineFocusedColor = System.Drawing.Color.Black;
            this.txt_Eposta.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Eposta.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txt_Eposta.LineThickness = 3;
            this.txt_Eposta.Location = new System.Drawing.Point(748, 525);
            this.txt_Eposta.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Eposta.Name = "txt_Eposta";
            this.txt_Eposta.Size = new System.Drawing.Size(363, 38);
            this.txt_Eposta.TabIndex = 8;
            this.txt_Eposta.Text = "E-Posta Adresi";
            this.txt_Eposta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Eposta.Enter += new System.EventHandler(this.txt_Eposta_Enter);
            this.txt_Eposta.Leave += new System.EventHandler(this.txt_Eposta_Leave);
            // 
            // txt_Tel
            // 
            this.txt_Tel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_Tel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Tel.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Tel.HintText = "";
            this.txt_Tel.isPassword = false;
            this.txt_Tel.LineFocusedColor = System.Drawing.Color.Black;
            this.txt_Tel.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Tel.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txt_Tel.LineThickness = 3;
            this.txt_Tel.Location = new System.Drawing.Point(748, 479);
            this.txt_Tel.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(363, 38);
            this.txt_Tel.TabIndex = 7;
            this.txt_Tel.Text = "Telefon Numarası";
            this.txt_Tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Tel.Enter += new System.EventHandler(this.txt_Tel_Enter);
            this.txt_Tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Tel_KeyPress);
            this.txt_Tel.Leave += new System.EventHandler(this.txt_Tel_Leave);
            // 
            // box_Görevli
            // 
            this.box_Görevli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.box_Görevli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.box_Görevli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.box_Görevli.FormattingEnabled = true;
            this.box_Görevli.Items.AddRange(new object[] {
            "Müdür",
            "Memur",
            "Personel"});
            this.box_Görevli.Location = new System.Drawing.Point(748, 376);
            this.box_Görevli.Name = "box_Görevli";
            this.box_Görevli.Size = new System.Drawing.Size(363, 24);
            this.box_Görevli.TabIndex = 5;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bunifuMaterialTextbox1.Enabled = false;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(748, 350);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(363, 59);
            this.bunifuMaterialTextbox1.TabIndex = 0;
            this.bunifuMaterialTextbox1.Text = "Görevli";
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bunifuMaterialTextbox2.Enabled = false;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox2.HintText = "";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox2.LineThickness = 3;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(748, 417);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(363, 54);
            this.bunifuMaterialTextbox2.TabIndex = 0;
            this.bunifuMaterialTextbox2.Text = "Görevi";
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // box_cinsiyet
            // 
            this.box_cinsiyet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.box_cinsiyet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.box_cinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.box_cinsiyet.FormattingEnabled = true;
            this.box_cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.box_cinsiyet.Location = new System.Drawing.Point(748, 309);
            this.box_cinsiyet.Name = "box_cinsiyet";
            this.box_cinsiyet.Size = new System.Drawing.Size(363, 24);
            this.box_cinsiyet.TabIndex = 4;
            // 
            // bunifuMaterialTextbox3
            // 
            this.bunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bunifuMaterialTextbox3.Enabled = false;
            this.bunifuMaterialTextbox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextbox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox3.HintText = "";
            this.bunifuMaterialTextbox3.isPassword = false;
            this.bunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox3.LineThickness = 3;
            this.bunifuMaterialTextbox3.Location = new System.Drawing.Point(748, 281);
            this.bunifuMaterialTextbox3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox3.Name = "bunifuMaterialTextbox3";
            this.bunifuMaterialTextbox3.Size = new System.Drawing.Size(363, 62);
            this.bunifuMaterialTextbox3.TabIndex = 0;
            this.bunifuMaterialTextbox3.Text = "Cinsiyeti";
            this.bunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // image_geri
            // 
            this.image_geri.BackColor = System.Drawing.Color.Transparent;
            this.image_geri.Image = ((System.Drawing.Image)(resources.GetObject("image_geri.Image")));
            this.image_geri.ImageActive = null;
            this.image_geri.Location = new System.Drawing.Point(12, 682);
            this.image_geri.Name = "image_geri";
            this.image_geri.Size = new System.Drawing.Size(44, 50);
            this.image_geri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.image_geri.TabIndex = 17;
            this.image_geri.TabStop = false;
            this.image_geri.Zoom = 10;
            this.image_geri.Click += new System.EventHandler(this.image_geri_Click);
            // 
            // txt_sicil
            // 
            this.txt_sicil.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sicil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_sicil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_sicil.HintForeColor = System.Drawing.Color.Empty;
            this.txt_sicil.HintText = "";
            this.txt_sicil.isPassword = false;
            this.txt_sicil.LineFocusedColor = System.Drawing.Color.Black;
            this.txt_sicil.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_sicil.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txt_sicil.LineThickness = 3;
            this.txt_sicil.Location = new System.Drawing.Point(748, 84);
            this.txt_sicil.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sicil.Name = "txt_sicil";
            this.txt_sicil.Size = new System.Drawing.Size(363, 38);
            this.txt_sicil.TabIndex = 18;
            this.txt_sicil.Text = "Sicil Numarası";
            this.txt_sicil.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_sicil.Enter += new System.EventHandler(this.txt_sicil_Enter);
            this.txt_sicil.Leave += new System.EventHandler(this.txt_sicil_Leave);
            // 
            // yeni_kullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1164, 743);
            this.Controls.Add(this.txt_sicil);
            this.Controls.Add(this.image_geri);
            this.Controls.Add(this.box_cinsiyet);
            this.Controls.Add(this.bunifuMaterialTextbox3);
            this.Controls.Add(this.box_Görevli);
            this.Controls.Add(this.box_Görevi);
            this.Controls.Add(this.txt_Tel);
            this.Controls.Add(this.txt_Eposta);
            this.Controls.Add(this.txt_Adres);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_TC);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.bunifuMaterialTextbox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "yeni_kullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Kullanıcı Kayıt";
            this.Load += new System.EventHandler(this.yeni_kullanici_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.yeni_kullanici_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.yeni_kullanici_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.yeni_kullanici_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_geri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_TC;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Eposta;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Soyad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Ad;
        private Bunifu.Framework.UI.BunifuThinButton2 btnkaydet;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Tel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.ComboBox box_Görevli;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Adres;
        private System.Windows.Forms.ComboBox box_Görevi;
        private System.Windows.Forms.ComboBox box_cinsiyet;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Bunifu.Framework.UI.BunifuImageButton image_geri;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_sicil;
    }
}