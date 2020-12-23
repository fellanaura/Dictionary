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

namespace Dictionary
{
    public partial class Form1 : Form
    {
        XmlDocument xmlDoc = new XmlDocument();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string API = "dict.1.1.20161113T050014Z.6b0875d1a4748f03.5fa57e579db9cb75107915ea230a9d8d3321526f";
            string Word = textBoxWord.Text;
            string url = string.Format("https://dictionary.yandex.net/api/v1/dicservice/lookup?key={0}&lang=en-en&text={1}", API, Word);
            xmlDoc.Load(url);

            XmlElement root = xmlDoc.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("/DicResult/def/tr");
            DataTable dt = new DataTable();
            dt.Columns.Add("Arti1", typeof(string));
            dt.Columns.Add("Arti2", typeof(string));
            dt.Columns.Add("Arti3", typeof(string));
            dt.Columns.Add("Arti4", typeof(string));
            dt.Columns.Add("Arti5", typeof(string));
            dt.Columns.Add("Arti6", typeof(string));
            dt.Columns.Add("Arti7", typeof(string));
            dt.Columns.Add("Arti8", typeof(string));
            dt.Columns.Add("Arti9", typeof(string));
            dt.Columns.Add("Arti10", typeof(string));
            dt.Columns.Add("Arti11", typeof(string));
            dt.Columns.Add("Arti12", typeof(string));            
            foreach (XmlNode item in nodes)
            {
                DataRow dr = dt.NewRow();
                dr[0] = item["text"].InnerText;
                dr[1] = item["text"].InnerText;
                dr[2] = item["text"].InnerText;
                dr[3] = item["text"].InnerText;
                dr[4] = item["text"].InnerText;
                dr[5] = item["text"].InnerText;
                dr[6] = item["text"].InnerText;                
                dt.Rows.Add(dr);
            }

                try
                {
                    string d1 = dt.Rows[0][1].ToString();
                    txt1.Text = d1.ToString();
                    string d2 = dt.Rows[1][1].ToString();
                    txt2.Text = d2.ToString();
                    string d3 = dt.Rows[2][1].ToString();
                    txt3.Text = d3.ToString();
                    string d4 = dt.Rows[3][1].ToString();
                    txt4.Text = d4.ToString();
                    string d5 = dt.Rows[4][1].ToString();
                    txt5.Text = d5.ToString();
                    string d6 = dt.Rows[5][1].ToString();
                    txt6.Text = d6.ToString();
                    string d7 = dt.Rows[6][1].ToString();
                    txt7.Text = d7.ToString();
                    string d8 = dt.Rows[7][1].ToString();
                    txt8.Text = d8.ToString();
                    string d9 = dt.Rows[8][1].ToString();
                    txt9.Text = d9.ToString();
                    string d10 = dt.Rows[9][1].ToString();
                    txt10.Text = d10.ToString();
                    string d11 = dt.Rows[10][1].ToString();
                    txt11.Text = d11.ToString();
                    string d12 = dt.Rows[11][1].ToString();
                    txt12.Text = d12.ToString();
                }
                catch (Exception ex)
                {
                    
                }            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelWaktu.Text = DateTime.Now.ToLongTimeString();
            labelTgl.Text = DateTime.Now.ToLongDateString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxWord.Text = "";
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";
            txt7.Text = "";
            txt8.Text = "";
            txt9.Text = "";
            txt10.Text = "";
            txt11.Text = "";
            txt12.Text = "";            
        }
    }
}
