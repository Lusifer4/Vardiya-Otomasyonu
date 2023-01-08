namespace WindowsFormsApp1
{
    partial class Giris_ekranı
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris_ekranı));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Kullanici = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Parola = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblGiris = new System.Windows.Forms.Label();
            this.btnGiris = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.img_facebook = new Bunifu.Framework.UI.BunifuImageButton();
            this.img_instagram = new Bunifu.Framework.UI.BunifuImageButton();
            this.img_twiter = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Checkbox_yonetici = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lbl_yonetici = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_facebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_instagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_twiter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox5);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(23)))), ((int)(((byte)(65)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(303, 702);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(73, 309);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(160, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(73, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Kullanici
            // 
            this.txt_Kullanici.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Kullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Kullanici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_Kullanici.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Kullanici.HintText = "";
            this.txt_Kullanici.isPassword = false;
            this.txt_Kullanici.LineFocusedColor = System.Drawing.Color.DimGray;
            this.txt_Kullanici.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Kullanici.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txt_Kullanici.LineThickness = 5;
            this.txt_Kullanici.Location = new System.Drawing.Point(475, 241);
            this.txt_Kullanici.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Kullanici.Name = "txt_Kullanici";
            this.txt_Kullanici.Size = new System.Drawing.Size(371, 44);
            this.txt_Kullanici.TabIndex = 1;
            this.txt_Kullanici.Text = "Kulanici Adı";
            this.txt_Kullanici.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Kullanici.Enter += new System.EventHandler(this.txt_Kullanici_Enter);
            this.txt_Kullanici.Leave += new System.EventHandler(this.txt_Kullanici_Leave);
            // 
            // txt_Parola
            // 
            this.txt_Parola.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Parola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_Parola.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Parola.HintText = "";
            this.txt_Parola.isPassword = false;
            this.txt_Parola.LineFocusedColor = System.Drawing.Color.DimGray;
            this.txt_Parola.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Parola.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txt_Parola.LineThickness = 5;
            this.txt_Parola.Location = new System.Drawing.Point(475, 331);
            this.txt_Parola.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Parola.Name = "txt_Parola";
            this.txt_Parola.Size = new System.Drawing.Size(371, 44);
            this.txt_Parola.TabIndex = 2;
            this.txt_Parola.Text = "Parola";
            this.txt_Parola.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Parola.Enter += new System.EventHandler(this.txt_Parola_Enter);
            this.txt_Parola.Leave += new System.EventHandler(this.txt_Parola_Leave);
            // 
            // lblGiris
            // 
            this.lblGiris.AutoSize = true;
            this.lblGiris.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiris.ForeColor = System.Drawing.Color.White;
            this.lblGiris.Location = new System.Drawing.Point(619, 174);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(83, 34);
            this.lblGiris.TabIndex = 3;
            this.lblGiris.Text = "GİRİŞ";
            this.lblGiris.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblGiris_MouseMove);
            // 
            // btnGiris
            // 
            this.btnGiris.ActiveBorderThickness = 1;
            this.btnGiris.ActiveCornerRadius = 20;
            this.btnGiris.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(23)))), ((int)(((byte)(65)))));
            this.btnGiris.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnGiris.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(23)))), ((int)(((byte)(65)))));
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGiris.BackgroundImage")));
            this.btnGiris.ButtonText = "Giriş Yap";
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGiris.IdleBorderThickness = 1;
            this.btnGiris.IdleCornerRadius = 30;
            this.btnGiris.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnGiris.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGiris.IdleLineColor = System.Drawing.Color.Maroon;
            this.btnGiris.Location = new System.Drawing.Point(536, 516);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(5);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(248, 50);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(617, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 1);
            this.label1.TabIndex = 5;
            this.label1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(418, 232);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(418, 331);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // img_facebook
            // 
            this.img_facebook.BackColor = System.Drawing.Color.Transparent;
            this.img_facebook.Image = ((System.Drawing.Image)(resources.GetObject("img_facebook.Image")));
            this.img_facebook.ImageActive = null;
            this.img_facebook.Location = new System.Drawing.Point(635, 588);
            this.img_facebook.Name = "img_facebook";
            this.img_facebook.Size = new System.Drawing.Size(50, 50);
            this.img_facebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.img_facebook.TabIndex = 8;
            this.img_facebook.TabStop = false;
            this.img_facebook.Zoom = 10;
            this.img_facebook.Click += new System.EventHandler(this.img_facebook_Click);
            // 
            // img_instagram
            // 
            this.img_instagram.BackColor = System.Drawing.Color.Transparent;
            this.img_instagram.Image = ((System.Drawing.Image)(resources.GetObject("img_instagram.Image")));
            this.img_instagram.ImageActive = null;
            this.img_instagram.Location = new System.Drawing.Point(734, 588);
            this.img_instagram.Name = "img_instagram";
            this.img_instagram.Size = new System.Drawing.Size(50, 50);
            this.img_instagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.img_instagram.TabIndex = 9;
            this.img_instagram.TabStop = false;
            this.img_instagram.Zoom = 10;
            this.img_instagram.Click += new System.EventHandler(this.img_instagram_Click);
            // 
            // img_twiter
            // 
            this.img_twiter.BackColor = System.Drawing.Color.Transparent;
            this.img_twiter.Image = ((System.Drawing.Image)(resources.GetObject("img_twiter.Image")));
            this.img_twiter.ImageActive = null;
            this.img_twiter.Location = new System.Drawing.Point(536, 588);
            this.img_twiter.Name = "img_twiter";
            this.img_twiter.Size = new System.Drawing.Size(50, 50);
            this.img_twiter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.img_twiter.TabIndex = 10;
            this.img_twiter.TabStop = false;
            this.img_twiter.Zoom = 10;
            this.img_twiter.Click += new System.EventHandler(this.img_twiter_Click);
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(900, 0);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(33, 33);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bunifuImageButton4.TabIndex = 12;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            this.bunifuImageButton4.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(621, 92);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(79, 79);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // Checkbox_yonetici
            // 
            this.Checkbox_yonetici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Checkbox_yonetici.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Checkbox_yonetici.Checked = false;
            this.Checkbox_yonetici.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Checkbox_yonetici.ForeColor = System.Drawing.Color.White;
            this.Checkbox_yonetici.Location = new System.Drawing.Point(826, 398);
            this.Checkbox_yonetici.Name = "Checkbox_yonetici";
            this.Checkbox_yonetici.Size = new System.Drawing.Size(20, 20);
            this.Checkbox_yonetici.TabIndex = 14;
            // 
            // lbl_yonetici
            // 
            this.lbl_yonetici.AutoSize = true;
            this.lbl_yonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yonetici.ForeColor = System.Drawing.Color.White;
            this.lbl_yonetici.Location = new System.Drawing.Point(732, 398);
            this.lbl_yonetici.Name = "lbl_yonetici";
            this.lbl_yonetici.Size = new System.Drawing.Size(88, 16);
            this.lbl_yonetici.TabIndex = 15;
            this.lbl_yonetici.Text = "Yönetici Girişi";
            // 
            // Giris_ekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(935, 702);
            this.Controls.Add(this.lbl_yonetici);
            this.Controls.Add(this.Checkbox_yonetici);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.bunifuImageButton4);
            this.Controls.Add(this.img_twiter);
            this.Controls.Add(this.img_instagram);
            this.Controls.Add(this.img_facebook);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.lblGiris);
            this.Controls.Add(this.txt_Parola);
            this.Controls.Add(this.txt_Kullanici);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Giris_ekranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_facebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_instagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_twiter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGiris;
        private System.Windows.Forms.Label lblGiris;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Parola;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Kullanici;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private Bunifu.Framework.UI.BunifuImageButton img_twiter;
        private Bunifu.Framework.UI.BunifuImageButton img_instagram;
        private Bunifu.Framework.UI.BunifuImageButton img_facebook;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_yonetici;
        private Bunifu.Framework.UI.BunifuCheckbox Checkbox_yonetici;
    }
}

