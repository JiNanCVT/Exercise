using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_2
{
    
    class DataProcess:List<Student> 
    {
        private float sum;
        private int n=0;
        private float aver;
        public void OutputToListView(ListView lv)
        {
           
            
            lv.Items.Clear();
            foreach (Student s in this)
            {
                string stuNum = s.score.ToString();
                ListViewItem item = new ListViewItem(new string[] { s.Name, stuNum });
                lv.Items.Add(item);
            }
        }
        public float Average()
        {
            sum = 0;
            n = 0;
            aver = 0;
            foreach (Student s in this)
            {
                sum += s.score;
                n++;
            }
            aver = sum / n;
            return aver;
        }
        public DataProcess TurnToList(IOrderedEnumerable<Student> l)
        {
            DataProcess list = new DataProcess ();
            foreach (Student stu in l)
            {
                list.Add(stu);
            }
            return list;
        }
        public DataProcess GetStuFromListView(ListView lv)
        {
            for (n = 0; n < lv.Items.Count; n++)
            {
                Student stu = new Student();
                stu.AddInfo(lv.Items[n].SubItems[0].Text, lv.Items[n].SubItems[1].Text);
                this.Add(stu);
            }
            return this;
        }
        public  DataProcess OderByName()
        {
            var list1 = this.OrderBy(f => f.name);
            return this.TurnToList(list1);
        }
        public DataProcess OderByScore()
        {
            var list1 = this.OrderBy(f => f.score);
            return this.TurnToList(list1);
        }

    }
}
