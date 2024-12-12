using System;
using System.Windows.Forms;

namespace OgrenciDersSecimSistemi
{
    public partial class FormDanisman : Form
    {
        private string danismanAdi;

        public FormDanisman(string danismanAdi)
        {
            InitializeComponent();
            this.danismanAdi = danismanAdi;
        }

        // Danışman ders onaylama butonu
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            // Seçilen dersin onaylanması
            if (lstOgrenciDersleri.SelectedItem != null)
            {
                string selectedItem = lstOgrenciDersleri.SelectedItem.ToString();

                // Dersin onaylandığına dair kullanıcıya bildirim
                MessageBox.Show($"{selectedItem} dersi onaylandı!");

                // Dersin durumunu veritabanında güncelle
                // Veritabanı işlemleri burada yapılacak (onay durumu değiştirilecek)

                // Öğrenci seçtiği dersleri artık görebilecek
                lstOgrenciDersleri.Items.Remove(lstOgrenciDersleri.SelectedItem);
            }
            else
            {
                MessageBox.Show("Lütfen onaylamak için bir ders seçin.");
            }
        }

        // Öğrencinin derslerini listele (veritabanı bağlantısı ile yapılacak)
        public void ListeleDersler()
        {
            // Veritabanından dersler çekilecek
            // Örneğin, öğrenci ders seçimlerini veritabanından alıp listeye ekleyebilirsiniz.
            lstOgrenciDersleri.Items.Add("Matematik - 3 kredi");
            lstOgrenciDersleri.Items.Add("Fizik - 4 kredi");
            lstOgrenciDersleri.Items.Add("Kimya - 2 kredi");
        }

        // Form yüklendiğinde dersleri listele
        private void FormDanisman_Load(object sender, EventArgs e)
        {
            // Danışman tarafından görülecek dersleri listele
            ListeleDersler();
        }
    }
}
