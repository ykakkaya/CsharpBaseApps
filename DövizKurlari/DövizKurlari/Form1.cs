using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DövizKurlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String today = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(today);
            DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date ").Attributes["Tarih"].Value);
            String UsdAlis = xmldoc.SelectSingleNode("Tarih_Date //Currency [@Kod='USD']/BanknoteBuying").InnerXml;
            String UsdSatis = xmldoc.SelectSingleNode("Tarih_Date //Currency [@Kod='USD']/BanknoteSelling").InnerXml;
            String EuroAlis= xmldoc.SelectSingleNode("Tarih_Date //Currency [@Kod='EUR']/BanknoteBuying").InnerXml;
            String EuroSatis = xmldoc.SelectSingleNode("Tarih_Date //Currency [@Kod='EUR']/BanknoteBuying").InnerXml;
            labelTarih.Text = tarih.ToLongDateString();
            labelusdAlis.Text = UsdAlis.ToString();
            labelUsdSatis.Text = UsdSatis.ToString();
            labelEuroAlis.Text = EuroAlis.ToString();
            labelEuroSatis.Text = EuroSatis.ToString();

        
        }
    }
}
