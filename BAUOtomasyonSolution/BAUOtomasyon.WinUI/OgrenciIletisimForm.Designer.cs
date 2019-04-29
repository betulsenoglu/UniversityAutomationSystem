namespace BAUOtomasyon.WinUI
{
    partial class OgrenciIletisimForm
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
            this.dgrOgrenciListesi = new System.Windows.Forms.DataGridView();
            this.txtOgrenciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrOgrenciListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrOgrenciListesi
            // 
            this.dgrOgrenciListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrOgrenciListesi.Location = new System.Drawing.Point(3, 88);
            this.dgrOgrenciListesi.Name = "dgrOgrenciListesi";
            this.dgrOgrenciListesi.RowTemplate.Height = 24;
            this.dgrOgrenciListesi.Size = new System.Drawing.Size(947, 398);
            this.dgrOgrenciListesi.TabIndex = 0;
            // 
            // txtOgrenciAdi
            // 
            this.txtOgrenciAdi.Location = new System.Drawing.Point(104, 33);
            this.txtOgrenciAdi.Name = "txtOgrenciAdi";
            this.txtOgrenciAdi.Size = new System.Drawing.Size(220, 22);
            this.txtOgrenciAdi.TabIndex = 1;
            this.txtOgrenciAdi.TextChanged += new System.EventHandler(this.txtOgrenciAdi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğrenci Adı:";
            // 
            // OgrenciIletisimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOgrenciAdi);
            this.Controls.Add(this.dgrOgrenciListesi);
            this.Name = "OgrenciIletisimForm";
            this.Text = "OgrenciIletisimForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgrOgrenciListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrOgrenciListesi;
        private System.Windows.Forms.TextBox txtOgrenciAdi;
        private System.Windows.Forms.Label label1;
    }
}