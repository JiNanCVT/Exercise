using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;             //导出txt
using System.Diagnostics;

namespace Homework_2
{
    public partial class MainForm : Form
    {
        private string stFilePath = string.Empty;
        int n = 0;
        static MainForm form1 = new MainForm();
        DataProcess list = new DataProcess();
        public MainForm()
        {


            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("请输入学生姓名");
                return;
            }
            
            try
            {
                if (float.Parse(textBox2.Text) < 0 || float.Parse(textBox2.Text) > 100)
                {
                    MessageBox.Show("请输入0~100的分数");
                    return;
                }
                else
                {
                    Student s = new Student();
                    s.AddInfo(textBox1.Text, textBox2.Text);
                    s.OutputToListView(listView1);
                    list.Add(s);
                }
                string aver = list.Average().ToString ();         //求平均值
                textBox4.Text = aver;                             //显示平均值
            }
            catch (FormatException ee)
            {
                MessageBox.Show("请输入0~100的分数!");
            }
            textBox1.Clear();
            textBox2.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            //var  list1 = list.OrderBy(f => f.score);

            //var list2 = list.OrderBy(f => f.name);

            string pp = string.Empty;

            if (comboBox1.SelectedItem.ToString().Equals("按成绩排序"))
            {
                //将list1输出到listView1
                list.OderByScore().OutputToListView(listView1);                   
            }
            else if (comboBox1.SelectedItem.ToString().Equals("按姓名排序"))
                {
                    //将list2输出到listView1
                    list.OderByName().OutputToListView(listView1);               
                }
              else if (comboBox1.SelectedItem.ToString().Equals(pp))
                            MessageBox.Show("请选择功能");
        }

     
        private void button4_Click(object sender, EventArgs e)
        {
            FileDo file = new FileDo();
            file.Save(textBox3.Text, listView1);                                         //保存信息
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
            FileDo file = new FileDo();
            DialogResult drr = new DialogResult();
            if (listView1.Items.Count != 0)
                drr = MessageBox.Show("是否要保存已输入信息", "", MessageBoxButtons.OKCancel);
            if (drr == DialogResult.OK)
            {
                file.Save(textBox3.Text, listView1);

            }
            else
            {
                listView1.Items.Clear();
                list.Clear();
                file.Open(listView1);
            }

            list.GetStuFromListView(listView1);                //从listView中获取数据到list
            textBox4.Text = list.Average().ToString();         //计算平均值并在listBox中显示


        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            textBox4.Clear();
            list.Clear();
            
        }

        
    }
}
