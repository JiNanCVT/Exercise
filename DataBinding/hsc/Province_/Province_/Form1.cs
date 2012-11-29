using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Province_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void com2_change_by1(string _proname)
        {
            switch (_proname)
            {
                case "广东省（粤）":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(new object[] {"广州市","深圳市","珠海市",
                        "东莞市","汕头市","佛山市","江门市","潮州市","揭阳市","惠州市"});
                    break;
                case "福建省（闽）":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(new object[] {"福州市","厦门市","泉州市",
                        "龙岩市","三明市","南平市","宁德市"});
                    break;
                case "广西壮族（桂）":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(new object[] { "南宁市", "柳州市", "桂林市",
                        "梧州市", "北海市", "钦州市" });
                    break;
                default:
                    break;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")   //选中省份之后改变各个控件的属性，清空省份则不用
            {
                comboBox2.Enabled = true;
                string _proname;
                _proname = comboBox1.Text;   //获取当前combobox1中选中的内容
                com2_change_by1(_proname);   //设置combobox2的集合内容
            }
        }
        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
