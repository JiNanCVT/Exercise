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
    public partial class Form1 : Form
    {
        private string stFilePath = string.Empty;
        int n = 0;
        static Form1 form1 = new Form1();
        Students list = new Students();
        Students list3 = new Students();
        public Form1()
        {


            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            
            //List<Student> list = new List<Student>();
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
                    s.addInfo(textBox1.Text, textBox2.Text);
                    s.outputToListView(listView1);
                    list.Add(s);
                }
                string aver = list.average(listView1).ToString ();         //求平均值
                textBox4.Text = aver;                             //显示平均值
            }
            catch (FormatException ee)
            {
                MessageBox.Show("请输入0~100的分数!");
            }
            textBox1.Clear();
            textBox2.Clear();
            MessageBox.Show(list.Count().ToString());

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            var  list1 = list.OrderBy(f => f.score);

            var list2 = list.OrderBy(f => f.name);

            string pp = string.Empty;

            if (comboBox1.SelectedItem.ToString().Equals("按成绩排序"))
            {
                list3.turnToList(list1).outputToListView(listView1);                   //将list1输出到listView1
            }
            else if (comboBox1.SelectedItem.ToString().Equals("按姓名排序"))
                {
                    list3.turnToList(list2).outputToListView(listView1);               //将list2输出到listView1
                }
              else if (comboBox1.SelectedItem.ToString().Equals(pp))
                            MessageBox.Show("请选择功能");
        }

     
        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "RTF File|*.txt";
            saveFileDialog1.DefaultExt = "*.txt";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                textBox3.Text = saveFileDialog1.FileName.ToString();
            }

            if (textBox3.Text == "")
            {
                MessageBox.Show("请选择保存路径");
            }

            string stFilePath = string.Empty;
            stFilePath = textBox3.Text + ".txt";

            StreamWriter swStream;

            if (File.Exists(stFilePath))
            {
                swStream = new StreamWriter(stFilePath);
            }
            else
            {
                swStream = File.CreateText(stFilePath);
            }

            //using (StreamWriter swStream = new StreamWriter(stFilePath))
            //{
            swStream.Write("姓名\t\t\t\t\t\t\t成绩");
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                for (int j = 0; j < listView1.Items[i].SubItems.Count; j++)
                {
                    string _strTemp = listView1.Items[i].SubItems[j].Text;
                    swStream.Write(_strTemp);

                    swStream.Write("\t\t\t\t\t\t\t");
                }
                swStream.WriteLine();
            }
            //关闭流,释放资源
            swStream.Flush();
            swStream.Close();

            Process.Start("notepad.exe", stFilePath);
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            list.Clear();
            OpenFileDialog lwtxt = new OpenFileDialog();
            lwtxt.Filter = "文本文件(*.txt)|*.txt";
            
            if (lwtxt.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(lwtxt.FileName))
                {
                    string s = sr.ReadToEnd();
                    string[] lines = s.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    if (lines.Count() == 0)
                    {
                        MessageBox.Show("请选择保存学生信息的txt文件");
                        return;
                    }

                    foreach (var i in lines)
                    {
                        string[] data = i.Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
                        try
                        {     
                            
                            if(float.Parse(data[1]) >= 0 && float.Parse(data[1]) <= 100 )
                                listView1.Items.Add(new ListViewItem(data));
                           
                        }
                        catch (Exception e1)
                        {
                            MessageBox.Show("请选择保存学生信息的txt文件");
                            return;
                        }


                        
                    }
                }
                int t = listView1.Items.Count;
                float sum1 = 0;
                int I = 0;
                float Average = 0;

                for (; I < t; I++)
                {
                    sum1 += Convert.ToInt32(listView1.Items[I].SubItems[1].Text);

                } Average = sum1 / I;
                string show = string.Format("{0}", Average);
                textBox4.Text = show;
                for (n = 0; n < listView1.Items.Count; n++)
                {
                    Student stu = new Student();

                    //sum += float.Parse(lv.Items[n].SubItems[1].Text);
                    stu.addInfo(listView1.Items[n].SubItems[0].Text, listView1.Items[n].SubItems[1].Text);
                    list.Add(stu);

                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            textBox4.Clear();
            list.Clear();
            
        }

        
    }
}
