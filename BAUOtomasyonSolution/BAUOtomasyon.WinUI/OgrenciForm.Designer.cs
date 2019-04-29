namespace BAUOtomasyon.WinUI
{
    partial class OgrenciForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtKimlik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbErkek = new System.Windows.Forms.RadioButton();
            this.rdbKadin = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dateDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnOgrenciKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(148, 9);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(207, 22);
            this.txtAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(148, 42);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(207, 22);
            this.txtSoyad.TabIndex = 3;
            // 
            // txtKimlik
            // 
            this.txtKimlik.Location = new System.Drawing.Point(148, 81);
            this.txtKimlik.MaxLength = 11;
            this.txtKimlik.Name = "txtKimlik";
            this.txtKimlik.Size = new System.Drawing.Size(207, 22);
            this.txtKimlik.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kimlik:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cinsiyet:";
            // 
            // rdbErkek
            // 
            this.rdbErkek.AutoSize = true;
            this.rdbErkek.Location = new System.Drawing.Point(148, 122);
            this.rdbErkek.Name = "rdbErkek";
            this.rdbErkek.Size = new System.Drawing.Size(65, 21);
            this.rdbErkek.TabIndex = 7;
            this.rdbErkek.Text = "Erkek";
            this.rdbErkek.UseVisualStyleBackColor = true;
            // 
            // rdbKadin
            // 
            this.rdbKadin.AutoSize = true;
            this.rdbKadin.Checked = true;
            this.rdbKadin.Location = new System.Drawing.Point(290, 122);
            this.rdbKadin.Name = "rdbKadin";
            this.rdbKadin.Size = new System.Drawing.Size(65, 21);
            this.rdbKadin.TabIndex = 8;
            this.rdbKadin.TabStop = true;
            this.rdbKadin.Text = "Kadın";
            this.rdbKadin.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Doğum Tarihi:";
            // 
            // dateDogumTarihi
            // 
            this.dateDogumTarihi.Location = new System.Drawing.Point(148, 159);
            this.dateDogumTarihi.Name = "dateDogumTarihi";
            this.dateDogumTarihi.Size = new System.Drawing.Size(207, 22);
            this.dateDogumTarihi.TabIndex = 10;
            // 
            // btnOgrenciKaydet
            // 
            this.btnOgrenciKaydet.Location = new System.Drawing.Point(148, 201);
            this.btnOgrenciKaydet.Name = "btnOgrenciKaydet";
            this.btnOgrenciKaydet.Size = new System.Drawing.Size(207, 41);
            this.btnOgrenciKaydet.TabIndex = 11;
            this.btnOgrenciKaydet.Text = "Öğrenci Kaydet";
            this.btnOgrenciKaydet.UseVisualStyleBackColor = true;
            this.btnOgrenciKaydet.Click += new System.EventHandler(this.btnOgrenciKaydet_Click);
            // 
            // OgrenciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 264);
            this.Controls.Add(this.btnOgrenciKaydet);
            this.Controls.Add(this.dateDogumTarihi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdbKadin);
            this.Controls.Add(this.rdbErkek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKimlik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Name = "OgrenciForm";
            this.Text = "OgrenciForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtKimlik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbErkek;
        private System.Windows.Forms.RadioButton rdbKadin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateDogumTarihi;
        private System.Windows.Forms.Button btnOgrenciKaydet;
    }
}