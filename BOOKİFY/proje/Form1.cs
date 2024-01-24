using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox1.Text;
            string sifre = textBox2.Text;





            if (kullaniciAdi == "sedel" && sifre == "1234")
            {

                Bookify anaSayfa = new Bookify();
                anaSayfa.Show();


                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (textBox2.PasswordChar == '*')
            {

                textBox2.PasswordChar = '\0'; // '\0' karakteri şifre karakterlerini gösterir
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
    }
}
