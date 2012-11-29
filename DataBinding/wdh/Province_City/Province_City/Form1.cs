using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Province_City
{
    public partial class Province_City : Form
    {
        public Province_City()
        {
            InitializeComponent();
        }
       
        public int number;

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            City_SelectedIndexChanged(sender, null);
            main_SelectedIndexChanged(sender, null);
            button4.Enabled = false;
        }

        private void Province_SelectedIndexChanged(object sender, EventArgs e)
        {
                number = Province.SelectedIndex;
                button4.Enabled = true;                                          
        }

        private void City_SelectedIndexChanged(object sender, EventArgs e)
        {
            City.Items.Clear();//清空城市显示窗口
            switch (number)
            {
               //省会项列表的数组下标作为索引
                case 0://对应于北京
                    {                       
                        foreach (var s in Cities.string0)
                        {
                            City.Items.Add(s);
                        }
                        break;
                    }

                case 1://对应于广东省
                    {                       
                        foreach (var s in Cities.string1)
                        {
                            City.Items.Add(s);
                        }
                        break;
                    }

            }
        }

        private void _province_Click(object sender, EventArgs e)
        {

        }
        //将各个省会添加进项列表
        private void main_SelectedIndexChanged(object sender, EventArgs e)
        {
            main.Items.Clear();//清空省会显示窗口
            switch (number)
            {
                case 0:
                    {                       
                        main.Items.Add(Main_City.s[number]);
                        break;
                    }
                
                case 1:
                    {
                        main.Items.Add(Main_City.s[number]);
                        break;
                    }
            }
        }
       
    }
}
