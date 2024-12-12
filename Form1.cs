using System;
using System.Windows.Forms;

namespace OgrenciDersSecimSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;  
            string sifre = txtSifre.Text;  
            string rol = cmbRolSecimi.SelectedItem?.ToString();  

            
            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(rol))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            
            if (rol == "Öğrenci")
            {
               
                Form ogrenciEkrani = new FormOgrenciDersSecim(kullaniciAdi);  
                ogrenciEkrani.Show();
                this.Hide(); 
            }
            
            else if (rol == "Danışman Hoca")
            {
                if (sifre == "123")  
                {
                    
                    FormDanismanDersOnay danismanEkrani = new FormDanismanDersOnay(kullaniciAdi); 
                    danismanEkrani.Show();
                    this.Hide();  
                else
                {
                    MessageBox.Show("Danışman şifresi hatalı.");
                }
            }
            else
            {
                MessageBox.Show("Geçersiz rol seçimi.");
            }
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbRolSecimi.Items.Add("Öğrenci");  
            cmbRolSecimi.Items.Add("Danışman Hoca");
            cmbRolSecimi.SelectedIndex = 0;  
        }
    }
}
