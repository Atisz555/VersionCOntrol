using MNB2.Entities;
using MNB2.MnbServiceReference;
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

namespace MNB2
{
    public partial class Form1 : Form
    {
        BindingList<RateData> Rates = new BindingList<RateData>();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = Rates;
            LoadXml(GetExchangeRates());
        }

        private string GetExchangeRates()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();
            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = "EUR",
                startDate = "2020-01-01",
                endDate = "2020-06-30"
            };
            var response = mnbService.GetExchangeRates(request);
            var result = response.GetExchangeRatesResult;
            return result;
        }

        private void LoadXml(string result)
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(result);

            foreach (XmlElement item in xml.DocumentElement)
            {
                var date = item.GetAttribute("date");
                var x = (XmlElement)item.ChildNodes[0];
                var currency = x.GetAttribute("curr");
                var val = x.InnerText;
                Rates.Add(new RateData()
                {
                    Date = DateTime.Parse(date),
                    Currency = currency,
                    Value = decimal.Parse(val)
                });
            }
        }
              

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
