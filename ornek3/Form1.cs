using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToplama_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt32(txtSayi1.Text);
            sayi2 = Convert.ToInt32(txtSayi2.Text);
            sonuc = sayi1 + sayi2;

            lblSonuc.Text = "Toplam:" + sonuc.ToString();

            

        }

        private void btnÇıkarma_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt32(txtSayi1.Text);
            sayi2 = Convert.ToInt32(txtSayi2.Text);
            sonuc = sayi1 - sayi2;

            lblSonuc.Text = "Fark:" + sonuc.ToString();
        }

        private void btnÇarpma_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt32(txtSayi1.Text);
            sayi2 = Convert.ToInt32(txtSayi2.Text);
            sonuc = sayi1 * sayi2;

            lblSonuc.Text = "Çarpma:" + sonuc.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float sayi1, sayi2, sonuc;
            sayi1 = Convert.ToSingle(txtSayi1.Text);
            sayi2 = Convert.ToSingle(txtSayi2.Text);
            sonuc = sayi1 /sayi2;

            lblSonuc.Text = "Bölme:" + sonuc.ToString();
        }
    }
}
