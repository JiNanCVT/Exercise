using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Homework_2
{
    
    class Students:List<Student> 
    {
        private float sum;
        private int n;
        private float aver;
        public void outputToListView(ListView lv)
        {
           
            
            lv.Items.Clear();
            foreach (Student s in this)
            {
                string stuNum = s.score.ToString();
                ListViewItem item = new ListViewItem(new string[] { s.Name, stuNum });
                lv.Items.Add(item);
            }
        }
        public float average(ListView lv)
        {
            sum = 0;
         
            aver = 0;
            for (n=0;n<lv.Items.Count;n++)
            {
                //Student stu = new Student();

                sum+=float.Parse(lv.Items[n].SubItems[1].Text);
                //stu.addInfo(lv.Items[n].SubItems[0].Text,lv.Items[n].SubItems[1].Text);
                //this.Add(stu);
            }
            
            foreach (Student s in this)
            {
                sum += s.score;
                n++;
            }
            aver = sum / n;
            return aver;
        }
        public Students turnToList(IOrderedEnumerable<Student> l)
        {
            this.Clear();
            foreach (Student stu in l)
            {
                this.Add(stu);
            }
            return this;
        }
    }
}
