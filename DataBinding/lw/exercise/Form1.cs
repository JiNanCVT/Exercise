using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            if (listView1.Items[0].Selected ==true)
            {
                List<citys> heaven = new List<citys>();
                citys c1 = new citys();
                c1.I = 1;
                c1.Name = "广州";
                citys c2 = new citys();
                c2.I = 2;
                c2.Name = "茂名";
                heaven.Add(c1);
                heaven.Add(c2);
                foreach (citys c in heaven)
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
                    List<citys> lw = new List<citys>();
                    citys c1 = new citys();
                    c1.I = 1;
                    c1.Name = "桂林";
                    citys c2 = new citys();
                    c2.I = 2;
                    c2.Name = "南宁";
                    lw.Add(c1);
                    lw.Add(c2);
                    foreach (citys c in lw)
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
