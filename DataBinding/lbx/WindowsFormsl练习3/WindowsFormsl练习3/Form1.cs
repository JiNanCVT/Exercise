using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsl练习3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Provinces_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (Provinces.Items[0].Selected == true)
            {
                Cities.Items.Clear();
                Cities.Items.Add(ShowCity.p1[0]);
                Cities.Items.Add(ShowCity.p1[1]);
            }
            else if (Provinces.Items[1].Selected == true) 
            {
                Cities.Items.Clear();
                Cities.Items.Add(ShowCity.p2[0]);
                Cities.Items.Add(ShowCity.p2[1]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
