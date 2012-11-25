using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Homework_2
{
    class Student
    {
        public String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public float  score;

        public float  Score
        {
            get { return score; }
            set { 
                if (value >=0&&value<=100)
                score = value;
            else
                    MessageBox.Show("请输入0~100的分数！");
            }
        }
        public Student()
        {
            this.name = name;
            this.score = score;
        }
    }
}
