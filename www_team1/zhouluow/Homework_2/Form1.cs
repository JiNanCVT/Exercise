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
    public partial class MainForm : Form
    {
        //static Form1 form1 = new Form1();
        List<Student> _students = new List<Student>();
        public MainForm()
        {


            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            //List<Student> list = new List<Student>();
            if (Txt_Name.Text.Length==0)
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
                s.name = Txt_Name.Text;
                s.score = float.Parse(textBox2.Text);
                _students.Add(s);
                //form1.textBox1.Clear(); 
                //form1.textBox2.Clear();
            }
            }
            catch (FormatException ee)
            {
                MessageBox.Show("请输入学生成绩");
            }
            Txt_Name.Clear ();
            textBox2.Clear();
            Cmb_f.SelectedIndex = 0;
        }

        

       

        

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list1 = _students.OrderBy(f => f.score);
            //}
            //else
            //{
            var list2 = _students.OrderBy(f => f.name);
            //}
            Lsv_students.Items.Clear();
            string pp = string.Empty;
            if (Cmb_f.SelectedItem.ToString().Equals("按成绩排序"))
            {
                foreach (Student s in list1)
                {
                    string stuNum = s.score.ToString();
                    ListViewItem item = new ListViewItem(new string[] { s.Name, stuNum });
                    Lsv_students.Items.Add(item);
                }

            }
            else if (Cmb_f.SelectedItem.ToString().Equals("按姓名排序"))
            {
                foreach (Student s in list2)
                {
                    string stuNum = s.score.ToString();
                    ListViewItem item = new ListViewItem(new string[] { s.Name, stuNum });
                    Lsv_students.Items.Add(item);
                }
            }
            else if (Cmb_f.SelectedItem.ToString().Equals("平均值"))
            {
                foreach (Student s in _students)
                {
                    string stuNum = s.score.ToString();
                    ListViewItem item = new ListViewItem(new string[] { s.Name, stuNum });
                    Lsv_students.Items.Add(item);
                }
                int n = 0;
                float sum = 0;
                foreach (Student s in _students)
                {

                    sum += s.score;
                    n++;
                }
                float pj = sum / n;
                string p = pj.ToString();
                MessageBox.Show("平均值： " + p);
            }
            else if (Cmb_f.SelectedItem.ToString().Equals(pp))
                MessageBox.Show("请选择功能");
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
            for (int i = 0; i < Lsv_students.Items.Count; i++)
            {
                for (int j = 0; j < Lsv_students.Items[i].SubItems.Count; j++)
                {
                    string _strTemp = Lsv_students.Items[i].SubItems[j].Text;
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
   

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
