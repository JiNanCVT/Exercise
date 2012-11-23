using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lw
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> mylist = new List<Student>();
            Student s0 = new Student("钓丝6", 76);
            Student s1 = new Student("不丝2", 23);
            Student s2 = new Student("啊丝8", 28);
            Student s3 = new Student("没丝4", 13);
            Student s4 = new Student("老丝5", 79);
            mylist.Add(s0);
            mylist.Add(s1);
            mylist.Add(s2);
            mylist.Add(s3);
            mylist.Add(s4);
            var mylist1 = mylist.OrderBy(f => f.Grade);
            var mylist2 = mylist.OrderBy(f => f.Name);

            Console.WriteLine("请选择排序方式：1。分数   2。名字   3。exit");

            int ch = Console.Read();
            if (ch == '1' )
            {
                Console.ReadLine();//格式控制
                foreach (Student student in mylist1)
                {
                    Console.Write("\n");
                    Console.Write(student.Name);//已经排好序，故可分开write；
                    Console.Write(":\t");
                    Console.Write(student.Grade);
                }
                Console.ReadLine();
            }
            if (ch == '2')
            {
                Console.ReadLine();//格式控制
                foreach (Student student in mylist2)
                {
                    Console.Write("\n");
                    Console.Write(student.Name);
                    Console.Write(":\t");
                    Console.Write(student.Grade);
                }
                Console.ReadLine();
            }
            if (ch == '3')
                System.Environment.Exit(0);
            
        }


        class Student
        {
            private string name;
            public string Name
            {
                get { return name; }
            }


            private int grade;
            public int Grade
            {
                get { return grade; }
                set { grade = value; }
            }

            public Student(string name, int grade)
            {
                this.name = name;

                this.grade = grade;
            }
        }
    }
}

