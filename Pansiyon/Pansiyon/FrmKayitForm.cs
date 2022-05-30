using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pansiyon
{
    public partial class FrmKayitForm : Form
    {
        public FrmKayitForm()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-JMM0C4R;Initial Catalog=pansiyon;Integrated Security=True");
        
        private void verileriGoster()
        {
            listView1.Items.Clear();
            baglantı.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM müsteriler", baglantı);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Id"].ToString();
                ekle.SubItems.Add( oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Gtarih"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Hesap"].ToString());
                ekle.SubItems.Add(oku["Ctarih"].ToString());

                listView1.Items.Add(ekle);
            }
            baglantı.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO müsteriler (Id,Ad,Soyad,OdaNo,Gtarih,Telefon,Hesap,Ctarih)values('" + textBoxID.Text.ToString() + "','" + textBoxAD.Text.ToString() + "','" + textBoxSOYAD.Text.ToString() + "','" + comboBoxOdaNo.Text.ToString() + "','" + dateTimePickerGiris.Text.ToString() + "','" + textBoxTelefon.Text.ToString() + "','" + textBoxHesap.Text.ToString() + "','" + dateTimePickerCikis.Text.ToString() + "')", baglantı);
            komut.ExecuteNonQuery();
            komut.CommandText="insert into doluoda(doluyerler)values('" + comboBoxOdaNo.Text + "')";
            komut.ExecuteNonQuery();
            komut.CommandText = ("delete from bosoda where bosyerler='" + comboBoxOdaNo.Text + "'");
            komut.ExecuteNonQuery();
            baglantı.Close();
            verileriGoster();
            textBoxID.Clear();
            textBoxAD.Clear();
            textBoxSOYAD.Clear();
            
            textBoxTelefon.Clear();
            textBoxHesap.Clear();
        }

        int id = 0;
        private void buttonSil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM müsteriler WHERE Id=(" + id + ")", baglantı);
            komut.ExecuteNonQuery();

            komut.CommandText = "insert into bosoda(bosyerler)values('" + comboBoxOdaNo.Text + "')";
            komut.ExecuteNonQuery();
            komut.CommandText = ("delete from doluoda where doluyerler='" + comboBoxOdaNo.Text + "'");
            komut.ExecuteNonQuery();
            baglantı.Close();
            verileriGoster();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBoxID.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBoxAD.Text= listView1.SelectedItems[0].SubItems[1].Text;
            textBoxSOYAD.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBoxOdaNo.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBoxTelefon.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBoxHesap.Text = listView1.SelectedItems[0].SubItems[6].Text;
            dateTimePickerGiris.Text = listView1.SelectedItems[0].SubItems[4].Text;
            dateTimePickerCikis.Text = listView1.SelectedItems[0].SubItems[7].Text;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("UPDATE müsteriler SET Id='" + textBoxID.Text.ToString() + "',Ad='" + textBoxAD.Text.ToString() + "',Soyad='" + textBoxSOYAD.Text.ToString() + "',OdaNo='" + comboBoxOdaNo.Text.ToString() + "',Gtarih='" + dateTimePickerGiris.Text.ToString() + "',Telefon='" + textBoxTelefon.Text.ToString() + "',Hesap='" + textBoxHesap.Text.ToString() + "',Ctarih='" + dateTimePickerCikis.Text.ToString() + "'WHERE Id=" + id + "", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            verileriGoster();
        }

        private void FrmKayitForm_Load(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from bosoda",baglantı);
            SqlDataReader oda = komut.ExecuteReader();
            while (oda.Read())
            {
                comboBoxOdaNo.Items.Add(oda[0].ToString());
            }
            baglantı.Close();
        }

        private void buttonArama_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglantı.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM müsteriler where Ad like'%"+textBoxArama.Text+"%'", baglantı);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Gtarih"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Hesap"].ToString());
                ekle.SubItems.Add(oku["Ctarih"].ToString());

                listView1.Items.Add(ekle);
            }
            baglantı.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(1) + textBox1.Text.Substring(0, 1);
        }
    }
}
