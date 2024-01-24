using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace proje
{
    public partial class Bookify : Form
    {
        public Bookify()
        {
            InitializeComponent();
        }
        double toplam;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Text == "")
                label7.Text = "0";
            else if (listBox1.Text == "Yerdeniz Büyücüsü-Ursula K. Le Guin 82TL")
                label7.Text = "82";
            else if (listBox1.Text == "Yüzüklerin Efendisi-J. R. R. Tolkien 95TL")
                label7.Text = "95";
            else if (listBox1.Text == "Açlık Oyunları-Suzanne Collins 180TL")
                label7.Text = "180";
            else if (listBox1.Text == "Yıldız Tozu-Neil Gaiman 50TL")
                label7.Text = "50";
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.Text == "")
                label8.Text = "0";
            else if (listBox2.Text == "Peri MasalI-Stephen King 168TL")
                label8.Text = "168";
            else if (listBox2.Text == "Şizofren-John Katzenbach 115TL")
                label8.Text = "115";
            else if (listBox2.Text == "O Gece-Gillian Mcallister 90TL")
                label8.Text = "90" ;
            
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox3.Text == "")
                label9.Text = "0";
            else if (listBox3.Text == "Siyasi Tarih-Oral Sander 182TL")
                label9.Text = "182";
            else if (listBox3.Text == "Alman İdeolojisi-Friedrich Engels 200TL")
                label9.Text = "200";
            else if (listBox3.Text == "Siyâsetnâme-Nizâmülmülk 60TL")
                label9.Text = "60";
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox4.Text == "")
                label10.Text = "0";
            else if (listBox4.Text == "Hayır Diyebilme Sanatı-Müthiş Psikoloji 60TL")
                label10.Text = "60";
            else if (listBox4.Text == "Bir Ömür Nasıl Yaşanır?-İlber Ortaylı 75TL")
                label10.Text = "75";
            else if (listBox4.Text == "İyi Hissetmek-David D. Burns 158TL")
                label10.Text = "158";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam;
            listBox5.Items.Clear();

            if (listBox1.Text != "")
                listBox5.Items.Add(listBox1.Text + " | " + label7.Text + " TL");

            if (listBox2.Text != "")
                listBox5.Items.Add(listBox2.Text + " | " + label8.Text + " TL");

            if (listBox3.Text != "")
                listBox5.Items.Add(listBox3.Text + " | " + label9.Text + " TL");

            if (listBox4.Text != "")
                listBox5.Items.Add(listBox4.Text + " | " + label10.Text + " TL");

            toplam = int.Parse(label7.Text) + int.Parse(label8.Text) + int.Parse(label9.Text) + int.Parse(label10.Text);
            textBox1.Text = toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox5.Items.Clear();
            listBox1.SelectedItem = null;
            listBox2.SelectedItem = null;
            listBox3.SelectedItem = null;
            listBox4.SelectedItem = null;
            textBox1.Text = "0";
            richTextBox1.Text = "";

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double toplam, ogrenci, indirim, odenecekTutar;
            toplam = double.Parse(textBox1.Text);

            if (checkBox1.Checked)
                ogrenci = toplam / 20;
            else
                ogrenci = 0;

            if (toplam >= 250)
                indirim = toplam / 10;
            else
                indirim = 0;

            odenecekTutar = toplam - indirim - ogrenci;

            richTextBox1.Text = "";
            richTextBox1.Text = "~~~~~~~~BOOKİFY~~~~~~~~" + "\n\n";
            richTextBox1.Text += "TOPLAM TUTAR = " + toplam + " TL" + "\n";
            richTextBox1.Text += "İNDİRİM TUTARI = " + indirim + " TL" + "\n";
            richTextBox1.Text += "ÖĞRENCİ İNDİRİMİ = " + ogrenci + " TL" + "\n";
            richTextBox1.Text += "_______________________________\n";
            richTextBox1.Text += "ÖDENECEK TUTAR = " + odenecekTutar + " TL" + "\n";
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label13.Text = label13.Text.Substring(1) + label13.Text.Substring(0, 1);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(double.Parse(textBox1.Text)<= 0)
            {
                MessageBox.Show("Lütfen sepeti doldurunuz.");

            }
            else if(double.Parse(textBox1.Text) > 0) 
            {
                ödeme ödeme = new ödeme();
                ödeme.Show();
            }

        }
    }
}
