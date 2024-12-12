namespace OgrenciDersSecimSistemi
{
    partial class Form1
    {
        /// <summary>
        /// Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Temizleme işlevi
        /// </summary>
        /// <param name="disposing">Yönetilen kaynakları temizle</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.cmbRolSecimi = new System.Windows.Forms.ComboBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();

            this.SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(120, 50);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(200, 20);
            this.txtKullaniciAdi.TabIndex = 0;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(120, 100);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(200, 20);
            this.txtSifre.TabIndex = 1;
            this.txtSifre.PasswordChar = '*';
            // 
            // cmbRolSecimi
            // 
            this.cmbRolSecimi.FormattingEnabled = true;
            this.cmbRolSecimi.Location = new System.Drawing.Point(120, 150);
            this.cmbRolSecimi.Name = "cmbRolSecimi";
            this.cmbRolSecimi.Size = new System.Drawing.Size(200, 21);
            this.cmbRolSecimi.TabIndex = 2;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(120, 200);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(200, 30);
            this.btnGirisYap.TabIndex = 3;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(30, 50);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(70, 13);
            this.lblKullaniciAdi.TabIndex = 4;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(30, 100);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(32, 13);
            this.lblSifre.TabIndex = 5;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(30, 150);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(24, 13);
            this.lblRol.TabIndex = 6;
            this.lblRol.Text = "Rol:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(360, 300);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.cmbRolSecimi);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Name = "Form1";
            this.Text = "Giriş Yap";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.ComboBox cmbRolSecimi;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblRol;
    }
}
