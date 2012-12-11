using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace Homework_2
{
    class FileDo
    {
        public void Save (string textBox,ListView listView1)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "RTF File|*.txt";
            
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                textBox = saveFileDialog1.FileName.ToString();
            }
            else if (dr == DialogResult.Cancel)
                return;


            

            string stFilePath = string.Empty;
            stFilePath = textBox;

            StreamWriter swStream;

            if (File.Exists(stFilePath))
            {
                swStream = new StreamWriter(stFilePath);
            }
            else
            {
                    swStream = File.CreateText(stFilePath);
            }
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

            
        }
        public void Open(ListView lv)
        {
           //listView1.Items.Clear();
           //list.Clear();
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

                            if (float.Parse(data[1]) >= 0 && float.Parse(data[1]) <= 100)
                                lv.Items.Add(new ListViewItem(data));

                        }
                        catch (Exception ex1)
                        {
                            MessageBox.Show("请选择保存学生信息的txt文件");
                            return;
                        }



                    }
                }
            }
        }
    }
}
