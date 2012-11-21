using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("\n\n\t输入1按分数排序\t输入2按姓名排序\t输入3退出\n");
            int enternum;
            List<Student> students = new List<Student>();

            
            
            Student s1 = new Student("Kobe:", 94);
            Student s2 = new Student("LBJ:", 96);
            Student s3 = new Student("Rondo:", 90);
            Student s4 = new Student("CP3:", 92);
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            begin:
            enternum = Convert.ToInt16(Console.ReadLine());
             
                if (1 == enternum)
                { Cgrade cg = new Cgrade(); students.Sort(cg); }
                else if (2 == enternum)
                { Cname cg = new Cname(); students.Sort(cg); }
                else if (3 == enternum) { Console.WriteLine("Bye"); System.Environment.Exit(0); }
                else { Console.WriteLine("输入错误"); System.Environment.Exit(0); }

                foreach (Student s in students)
                {
                    Console.Write(s.Name); Console.Write(s.Grade);
                    Console.Write('\n');
                }
              
           goto begin;
        



        }
    }
}




