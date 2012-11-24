using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            if (listView1.Items[0].Selected ==true)
            {
                List<City> l1 = new List<City>();
                City c1 = new City();
                c1.I = 1;
                c1.Name = "广州";
                City c2 = new City();
                c2.I = 2;
                c2.Name = "汕头";
                l1.Add(c1);
                l1.Add(c2);
                foreach (City c in l1)
                {
                    string ii = c.i.ToString();
                    ListViewItem item = new ListViewItem(new string[] { ii, c.Name });
                    listView2.Items.Add(item);
                }
            }
            else
            {
                if (listView1.Items[1].Selected ==true )
                {
                    List<City> l2 = new List<City>();
                    City c1 = new City();
                    c1.I = 1;
                    c1.Name = "桂林";
                    City c2 = new City();
                    c2.I = 2;
                    c2.Name = "南宁";
                    l2.Add(c1);
                    l2.Add(c2);
                    foreach (City c in l2)
                    {
                        string ii = c.i.ToString();
                        ListViewItem item = new ListViewItem(new string[]{ ii, c.Name });
                        listView2.Items.Add(item);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
