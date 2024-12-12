using System;
using System.Windows.Forms;

namespace OgrenciDersSecimSistemi
{
    public partial class FormOgrenciDersSecim : Form
    {
        private string kullaniciAdi;
        private int mevcutKredi = 0;
        private const int krediLimiti = 30;

        public FormOgrenciDersSecim(string kullaniciAdi)
        {
            InitializeComponent();
            this.kullaniciAdi = kullaniciAdi;
        }

       
        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            
            if (mevcutKredi < krediLimiti)
            {
               
                lstAktifDersler.Items.Add("Yeni Ders");  
                mevcutKredi += 5;  
                lblMevcutKredi.Text = $"Mevcut Kredi: {mevcutKredi}/{krediLimiti}";
            }
            else
            {
                MessageBox.Show("Kredi limitini aştınız.");
            }
        }

        
        private void btnDersSil_Click(object sender, EventArgs e)
        {
            
            if (lstAktifDersler.SelectedItem != null)
            {
                lstAktifDersler.Items.Remove(lstAktifDersler.SelectedItem);
                mevcutKredi -= 5; 
                lblMevcutKredi.Text = $"Mevcut Kredi: {mevcutKredi}/{krediLimiti}";
            }
            else
            {
                MessageBox.Show("Silmek için bir ders seçin.");
            }
        }

        
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Ders seçimleriniz onaylandı!");
            this.Close();
        }
    }
}
