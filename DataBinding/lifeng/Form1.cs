using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace myCity_search
{
    public partial class Form1 : Form
    {
        public int _index;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void province_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _index = province_comboBox.SelectedIndex;
            button2.Enabled=true;
            listBox1.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           switch(_index)
            {
                case 0://检索广东省城市
                    {
                        string s0_1 = " 广州市 深圳市 珠海市  汕头市 ";
                        string s0_2 = " 佛山市 韶关市 湛江市  肇庆市 ";
                        string s0_3 = " 江门市 茂名市 惠州市  梅州市 ";
                        string s0_4 = " 汕尾市 河源市 阳江市  清远市 ";
                        string s0_5 = " 东莞市 中山市 潮州市  揭阳市 ";
                        string s0_6 = " 云浮市";

                        listBox1.Items.Add(s0_1);
                        listBox1.Items.Add(s0_2);
                        listBox1.Items.Add(s0_3);
                        listBox1.Items.Add(s0_4);
                        listBox1.Items.Add(s0_5);
                        listBox1.Items.Add(s0_6);//+s0_2 +s0_3+ s0_4 + s0_5 + s0_6
                        Application.DoEvents();
                        break;
                    }
               case 1://检索湖南省
                   {
                        string s0_1 = " 长沙市 株洲市 湘潭市   衡阳市 ";
                        string s0_2 = " 邵阳市 岳阳市 张家界市 益阳市 ";
                        string s0_3 = " 怀化市 ";

                        listBox1.Items.Add(s0_1);
                        listBox1.Items.Add(s0_2);
                        listBox1.Items.Add(s0_3);
                        Application.DoEvents();
                        break;
                   }
               case 2://检索北京
                   {
                       string s0_1 = " 北京市 ";
                       listBox1.Items.Add(s0_1);
                       Application.DoEvents();
                       break;
                   }
               case 3://检索天津
                   {
                       string s0_1 = " 天津";
                       listBox1.Items.Add(s0_1);
                       Application.DoEvents();
                       break;
                   }
               case 4://检索河北省城市
                   {
                       string s0_1 = " 石家庄 保定市 承德市  唐山市 ";
                       string s0_2 = " 沧州市 衡水市 邢台市  邯郸市 ";
                       string s0_3 = " 秦皇岛市  ";

                       listBox1.Items.Add(s0_1);
                       listBox1.Items.Add(s0_2);
                       listBox1.Items.Add(s0_3);
                       Application.DoEvents();
                       break;
                   }
               case 5://检索山西省城市
                   {
                       string s0_1 = " 太原市 大同市 阳泉市  榆次市 ";
                       string s0_2 = " 长治市 晋城市 临汾市  ";
                       
                       listBox1.Items.Add(s0_1);
                       listBox1.Items.Add(s0_2);
                       Application.DoEvents();
                       break;
                   }
               case 6://检索辽宁省城市
                   {
                       string s0_1 = " 沈阳市 辽中市 大连市  鞍山市 ";
                       string s0_2 = " 抚顺市 本溪市 丹东市  锦州市 ";
                       string s0_3 = " 营口市 阜新市 辽阳市  铁岭市 ";
                       listBox1.Items.Add(s0_1);
                       listBox1.Items.Add(s0_2);
                       listBox1.Items.Add(s0_3);                    
                       Application.DoEvents();
                       break;
                   }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1_SelectedIndexChanged(sender, null);
            button2.Enabled = false;
        }
        

    }
}
