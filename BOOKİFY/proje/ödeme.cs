using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proje
{
    public partial class ödeme : Form
    {
        public ödeme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBox1.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(comboBox2.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBox2.Text))
            {
                // Eğer bir kontrol elemanı boşsa, kullanıcıya uyarı ver
                MessageBox.Show("Lütfen ödeme sayfasını eksiksiz doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            MessageBox.Show("Ödemeniz başarıyla alınmıştır.Bizi tercih ettiğiniz için teşekkürler.");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar)) //kalveyeden girilen değer rakamsa
            {
                e.Handled = true; // rakam olduğu için göstermiyo
            }
        }
    }
}
