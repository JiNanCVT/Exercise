using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            //Console.WriteLine("请输入学生姓名和分数");
            //Console.ReadLine();

            List<Student> student = new List<Student>();

            while (true)
            {
                var name = Console.ReadLine();
                if (name == "e")
                    break;
                string strScore = Console.ReadLine();
                int scor = int.Parse(strScore);

                student.Add(new Student(scor, name));
                
            }
           
            
            //student.Add(new Student(90,"李四"));
            //student.Add(new Student(95,"王五"));
            
            Console.Write("按分数排序请输入1\n按姓名排序请输入2\n退出请按3\n");

            number = 0;
           
            do
            {
                try
                {
                    number = Int32.Parse(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine(" ");
                }

                switch (number)
                {
                    case 1:
                        Console.WriteLine("按分数排序");
                        student.Sort(Student.SortStudent1);
                        break;
                    case 2:
                        Console.WriteLine("按姓名排序");
                        student.Sort(Student.SortStudent2);
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("请重新输入");
                        continue ;   
                }
                foreach (var s in student)
                {
                    Console.WriteLine(s.Name  +  s.Grade);
                }
            } while (number != 3);
         
            Console.Read();
        }

        }
    }

