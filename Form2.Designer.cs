namespace OgrenciDersSecimSistemi
{
    partial class FormOgrenciDersSecim
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstAktifDersler = new System.Windows.Forms.ListBox();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.btnDersSil = new System.Windows.Forms.Button();
            this.lblMevcutKredi = new System.Windows.Forms.Label();
            this.lblKrediLimit = new System.Windows.Forms.Label();
            this.cmbDersArama = new System.Windows.Forms.ComboBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAktifDersler
            // 
            this.lstAktifDersler.FormattingEnabled = true;
            this.lstAktifDersler.ItemHeight = 15;
            this.lstAktifDersler.Location = new System.Drawing.Point(12, 12);
            this.lstAktifDersler.Name = "lstAktifDersler";
            this.lstAktifDersler.Size = new System.Drawing.Size(200, 150);
            this.lstAktifDersler.TabIndex = 0;
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.Location = new System.Drawing.Point(12, 168);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(75, 23);
            this.btnDersEkle.TabIndex = 1;
            this.btnDersEkle.Text = "Ders Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = true;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // btnDersSil
            // 
            this.btnDersSil.Location = new System.Drawing.Point(137, 168);
            this.btnDersSil.Name = "btnDersSil";
            this.btnDersSil.Size = new System.Drawing.Size(75, 23);
            this.btnDersSil.TabIndex = 2;
            this.btnDersSil.Text = "Ders Sil";
            this.btnDersSil.UseVisualStyleBackColor = true;
            this.btnDersSil.Click += new System.EventHandler(this.btnDersSil_Click);
            // 
            // lblMevcutKredi
            // 
            this.lblMevcutKredi.AutoSize = true;
            this.lblMevcutKredi.Location = new System.Drawing.Point(12, 198);
            this.lblMevcutKredi.Name = "lblMevcutKredi";
            this.lblMevcutKredi.Size = new System.Drawing.Size(114, 15);
            this.lblMevcutKredi.TabIndex = 3;
            this.lblMevcutKredi.Text = "Mevcut Kredi: 0/30";
            // 
            // lblKrediLimit
            // 
            this.lblKrediLimit.AutoSize = true;
            this.lblKrediLimit.Location = new System.Drawing.Point(12, 225);
            this.lblKrediLimit.Name = "lblKrediLimit";
            this.lblKrediLimit.Size = new System.Drawing.Size(100, 15);
            this.lblKrediLimit.TabIndex = 4;
            this.lblKrediLimit.Text = "Kredi Limiti: 30";
            // 
            // cmbDersArama
            // 
            this.cmbDersArama.FormattingEnabled = true;
            this.cmbDersArama.Location = new System.Drawing.Point(12, 243);
            this.cmbDersArama.Name = "cmbDersArama";
            this.cmbDersArama.Size = new System.Drawing.Size(200, 23);
            this.cmbDersArama.TabIndex = 5;
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(137, 272);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(75, 23);
            this.btnOnayla.TabIndex = 6;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // FormOgrenciDersSecim
            // 
            this.ClientSize = new System.Drawing.Size(224, 311);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.cmbDersArama);
            this.Controls.Add(this.lblKrediLimit);
            this.Controls.Add(this.lblMevcutKredi);
            this.Controls.Add(this.btnDersSil);
            this.Controls.Add(this.btnDersEkle);
            this.Controls.Add(this.lstAktifDersler);
            this.Name = "FormOgrenciDersSecim";
            this.Text = "Ders Seçim Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ListBox lstAktifDersler;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.Button btnDersSil;
        private System.Windows.Forms.Label lblMevcutKredi;
        private System.Windows.Forms.Label lblKrediLimit;
        private System.Windows.Forms.ComboBox cmbDersArama;
        private System.Windows.Forms.Button btnOnayla;
    }
}
