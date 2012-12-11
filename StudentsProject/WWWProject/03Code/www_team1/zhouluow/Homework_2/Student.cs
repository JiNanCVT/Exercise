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
            set {name = value; }
        }
        public float  score;

        public float  Score
        {
            get { return score; }
            set {  score = value;}
        }
        
        public void AddInfo(String name, String score)
        {
            this.name = name;
            this.score = float.Parse(score);
        }
        public void OutputToListView(ListView lv)
        {
            ListViewItem item = new ListViewItem(new string[] {this.Name, this.score.ToString () });
            lv.Items.Add(item);
        }
    }
}
