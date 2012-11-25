using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;             //导出txt用到呀亲
using System.Diagnostics;

namespace Homework_2
{
    public partial class Form1 : Form
    {
        static Form1 form1 = new Form1();
        List<Student> list = new List<Student>();
        public Form1()
        {


            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            //List<Student> list = new List<Student>();
            if (textBox1.Text.Length==0)
            {
                MessageBox.Show("请输入学生姓名");
                return;
            }
            try 
            {
            if (float.Parse(textBox2.Text) < 0 || float.Parse(textBox2.Text) > 100)
            {
                MessageBox.Show("请输入0~100的分数！");
                return;
            }
           


            else
            {
                Student s = new Student();
                s.name = textBox1.Text;
                s.score = float.Parse(textBox2.Text);
                list.Add(s);
                //form1.textBox1.Clear(); 
                //form1.textBox2.Clear();
            }
            }
            catch (FormatException ee)
            {
                MessageBox.Show("请输入学生成绩");
            }
            textBox1.Clear ();
            textBox2.Clear();
            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void studentBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list1 = list.OrderBy(f => f.score);
            //}
            //else
            //{
            var list2 = list.OrderBy(f => f.name);
            //}
            listView1.Items.Clear();
            string pp = string.Empty;
            if (comboBox1.SelectedItem.ToString().Equals("按成绩排序"))
            {
                foreach (Student s in list1)
                {
                    string stuNum = s.score.ToString();
                    ListViewItem item = new ListViewItem(new string[] { s.Name, stuNum });
                    listView1.Items.Add(item);
                }

            }
            else
                if (comboBox1.SelectedItem.ToString().Equals("按姓名排序"))
                {
                    foreach (Student s in list2)
                    {
                        string stuNum = s.score.ToString();
                        ListViewItem item = new ListViewItem(new string[] { s.Name, stuNum });
                        listView1.Items.Add(item);
                    }
                }
                else
                    if (comboBox1.SelectedItem.ToString().Equals("平均值"))
                    {
                        foreach (Student s in list)
                        {
                            string stuNum = s.score.ToString();
                            ListViewItem item = new ListViewItem(new string[] { s.Name, stuNum });
                            listView1.Items.Add(item);
                        }
                        int n = 0;
                        float sum = 0;
                        foreach (Student s in list)
                        {

                            sum += s.score;
                            n++;
                        }
                        float pj = sum / n;
                        string p = pj.ToString();
                        MessageBox.Show("平均值： " + p);
                    }
                    else
                        if (comboBox1.SelectedItem.ToString().Equals(pp))
                            MessageBox.Show("请选择功能");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
             FolderBrowserDialog FolderBrowserDialog1 = new FolderBrowserDialog();
            FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            FolderBrowserDialog1.ShowNewFolderButton = true;
            FolderBrowserDialog1.Description = "请选择磁盘";
            DialogResult dr = FolderBrowserDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                textBox3.Text = FolderBrowserDialog1.SelectedPath;
                //MessageBox.Show(textBox3.Text);

            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("请选择保存路径"); 
            }




            //string path = null;
            //path = textBox3.Text + "\\test.txt";
            //MessageBox.Show(path);
            string stFilePath = string.Empty;
            stFilePath = textBox3.Text + "排序结果.txt";

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
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                for (int j = 0; j < listView1.Items[i].SubItems.Count; j++)
                {
                    string _strTemp = listView1.Items[i].SubItems[j].Text;
                    swStream.Write(_strTemp);

                    swStream.Write("\t\t");
                }
                swStream.WriteLine();
            }
            //关闭流,释放资源
            swStream.Flush();
            swStream.Close();

            Process.Start("notepad.exe", stFilePath);
            }
   
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
