namespace BAUOtomasyon.WinUI
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.rdbOgrenci = new System.Windows.Forms.RadioButton();
            this.rdbAkademisyen = new System.Windows.Forms.RadioButton();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.errorKullanici = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorKullanici)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(164, 56);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(204, 22);
            this.txtKullaniciAdi.TabIndex = 2;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(164, 101);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(204, 22);
            this.txtSifre.TabIndex = 3;
            // 
            // rdbOgrenci
            // 
            this.rdbOgrenci.AutoSize = true;
            this.rdbOgrenci.Checked = true;
            this.rdbOgrenci.Location = new System.Drawing.Point(164, 156);
            this.rdbOgrenci.Name = "rdbOgrenci";
            this.rdbOgrenci.Size = new System.Drawing.Size(79, 21);
            this.rdbOgrenci.TabIndex = 4;
            this.rdbOgrenci.TabStop = true;
            this.rdbOgrenci.Text = "Öğrenci";
            this.rdbOgrenci.UseVisualStyleBackColor = true;
            // 
            // rdbAkademisyen
            // 
            this.rdbAkademisyen.AutoSize = true;
            this.rdbAkademisyen.Location = new System.Drawing.Point(255, 156);
            this.rdbAkademisyen.Name = "rdbAkademisyen";
            this.rdbAkademisyen.Size = new System.Drawing.Size(113, 21);
            this.rdbAkademisyen.TabIndex = 5;
            this.rdbAkademisyen.Text = "Akademisyen";
            this.rdbAkademisyen.UseVisualStyleBackColor = true;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(164, 201);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(204, 41);
            this.btnGirisYap.TabIndex = 6;
            this.btnGirisYap.Text = "GİRİŞ YAP";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.Location = new System.Drawing.Point(164, 257);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(204, 41);
            this.btnKayitOl.TabIndex = 7;
            this.btnKayitOl.Text = "KAYIT OL";
            this.btnKayitOl.UseVisualStyleBackColor = true;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // errorKullanici
            // 
            this.errorKullanici.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 325);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.rdbAkademisyen);
            this.Controls.Add(this.rdbOgrenci);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorKullanici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.RadioButton rdbOgrenci;
        private System.Windows.Forms.RadioButton rdbAkademisyen;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.ErrorProvider errorKullanici;
    }
}