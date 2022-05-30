using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pansiyon
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(1) + textBox1.Text.Substring(0, 1);
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            if(textBoxKullaniciAdi.Text=="Admin"&& textBoxSifre.Text == "12345")
            {
                FrmKayitForm fr = new FrmKayitForm();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız.Tekrar Deneyin!!!!");
                textBoxKullaniciAdi.Clear();
                textBoxSifre.Clear();
            }
        }
    }
}
