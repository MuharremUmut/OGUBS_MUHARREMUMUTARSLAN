namespace OgrenciDersSecimSistemi
{
    partial class FormDanisman
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
            this.lstOgrenciDersleri = new System.Windows.Forms.ListBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.lblOnayDurumu = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // ListBox - Öğrenci Dersleri
            this.lstOgrenciDersleri.FormattingEnabled = true;
            this.lstOgrenciDersleri.ItemHeight = 15;
            this.lstOgrenciDersleri.Location = new System.Drawing.Point(12, 12);
            this.lstOgrenciDersleri.Name = "lstOgrenciDersleri";
            this.lstOgrenciDersleri.Size = new System.Drawing.Size(200, 150);
            this.lstOgrenciDersleri.TabIndex = 0;

            // Onayla Button
            this.btnOnayla.Location = new System.Drawing.Point(137, 168);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(75, 23);
            this.btnOnayla.TabIndex = 1;
            this.btnOnayla.Text = "Ders Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);

            // Onay Durumu Label
            this.lblOnayDurumu.AutoSize = true;
            this.lblOnayDurumu.Location = new System.Drawing.Point(12, 198);
            this.lblOnayDurumu.Name = "lblOnayDurumu";
            this.lblOnayDurumu.Size = new System.Drawing.Size(150, 15);
            this.lblOnayDurumu.TabIndex = 2;
            this.lblOnayDurumu.Text = "Onaylanmamış dersler:";

            // Form Settings
            this.ClientSize = new System.Drawing.Size(224, 240);
            this.Controls.Add(this.lblOnayDurumu);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.lstOgrenciDersleri);
            this.Name = "FormDanisman";
            this.Text = "Danışman Sayfası";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ListBox lstOgrenciDersleri;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Label lblOnayDurumu;
    }
}
