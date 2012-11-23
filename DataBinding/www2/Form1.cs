using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
     
    public partial class Form1 : Form
    {
        List<string> cities = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listView2.Items.Clear();

            if (listView1.Items[0].Selected == true)
            {
                cities.Clear();
                listView2.Items.Clear();
                cities.Add("广州市");
                cities.Add("深圳市");
                cities.Add("珠海市");
                cities.Add("高州市");
                foreach (string city in cities)
                {

                    listView2.Items.Add(city);
                }

            }

            if (listView1.Items[1].Selected == true)
            {
                cities.Clear();
                listView2.Items.Clear();
                cities.Add("成都市");
                cities.Add("绵阳市");
                cities.Add("巴中市");
                cities.Add("乐山市");
                foreach (string city in cities)
                {
                    listView2.Items.Add(city);
                }
            }
            if (listView1.Items[2].Selected == true)
            {
                cities.Clear();
                listView2.Items.Clear();
                cities.Add("南京市");
                cities.Add("杭州市");
                cities.Add("苏州市");
                foreach (string city in cities)
                {
                    listView2.Items.Add(city);
                }
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
