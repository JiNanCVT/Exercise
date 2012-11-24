using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class3test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
 
            InitializeComponent();
            this.listBox1.Items.Add("广东省");
            this.listBox1.Items.Add("其他省");
          
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
            int index = listBox1.IndexFromPoint(e.X, e.Y);
            listBox1.SelectedIndex = index;
            if (listBox1.SelectedIndex ==0)
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.AddRange(new object[] {
            "广州市",
            "深圳市",
            "珠海市",
            "汕头市",
            "佛山市",
            "韶关市",
            "湛江市",
            "肇庆市",
            "江门市",
            "茂名市",
            "惠州市",
            "梅州市",
            "汕尾市",
            "河源市",
            "阳江市",
            "清远市",
            "东莞市",
            "中山市",
            "潮州市",
            "揭阳市",
            "云浮市"});
            }

            if (listBox1.SelectedIndex == 1)
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("other");
            }
            
        }

        
       
    }
}
