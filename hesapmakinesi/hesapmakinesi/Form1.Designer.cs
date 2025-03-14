using System;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde TabControl otomatik olarak ilk sekmeye geçiş yapar.
        }

        // Temel Hesap Makinesi İşlemleri
        private void btnTopla_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(txtSayi1.Text);
            double sayi2 = Convert.ToDouble(txtSayi2.Text);
            lblSonuc.Text = (sayi1 + sayi2).ToString();
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(txtSayi1.Text);
            double sayi2 = Convert.ToDouble(txtSayi2.Text);
            lblSonuc.Text = (sayi1 - sayi2).ToString();
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(txtSayi1.Text);
            double sayi2 = Convert.ToDouble(txtSayi2.Text);
            lblSonuc.Text = (sayi1 * sayi2).ToString();
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(txtSayi1.Text);
            double sayi2 = Convert.ToDouble(txtSayi2.Text);
            if (sayi2 != 0)
                lblSonuc.Text = (sayi1 / sayi2).ToString();
            else
                MessageBox.Show("Bölme işlemi için ikinci sayı 0 olamaz!");
        }

        // Bilimsel Hesap Makinesi İşlemleri
        private void btnKareAl_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(txtBilimsel.Text);
            lblBilimselSonuc.Text = Math.Pow(sayi, 2).ToString();
        }

        private void btnKarekokAl_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(txtBilimsel.Text);
            lblBilimselSonuc.Text = Math.Sqrt(sayi).ToString();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(txtBilimsel.Text);
            lblBilimselSonuc.Text = Math.Sin(sayi * Math.PI / 180).ToString(); // Derece cinsinden
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(txtBilimsel.Text);
            lblBilimselSonuc.Text = Math.Cos(sayi * Math.PI / 180).ToString(); // Derece cinsinden
        }
    }
}
