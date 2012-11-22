using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-------学生系统排名------");
            Console.WriteLine("请先输入资料(学生姓名 回车键 成绩)：");
            Console.WriteLine("如果输入完成请按e结束资料输入");

            List<Student> list = new List<Student>();
            while (true)
            {

                var name = Console.ReadLine();
                if (name == "e")
                    break;
                var sco = Console.ReadLine();
                int score = int.Parse(sco);
                Student s = new Student(name, score);
                list.Add(s);
                Console.WriteLine("学生姓名：{0}", name);
                Console.WriteLine("学生分数：{0}", score);
            }
            Console.WriteLine("现在你可以查看具体资料了：");
            Console.WriteLine("按1：依照分数的高低排名");
            Console.WriteLine("按2：依照名字升序排列的结果");
            Console.WriteLine("按3，退出管理系统");

            while (true)
            {
            E: Console.WriteLine("你的选择是：");
                var n = Console.ReadLine();
                int N = int.Parse(n);
                if (N != 1 && N != 2 && N != 3)
                {
                    Console.WriteLine("Your choice is wrong");
                    goto E;
                }
                if (N == 1)
                {
                    var list1 = list.OrderByDescending(s => s._score);
                    //list.Sort(new StudentComparer(StudentComparer.CompareType.score));
                    foreach (Student item in list1)
                        Console.WriteLine("{0}     {1}", item._score, item._name);
                }
                else if (N == 2)
                {
                    var list2 = list.OrderByDescending(s => s._name);
                    foreach (Student item in list)
                        Console.WriteLine("{0}     {1}", item._name, item._score);
                    //list.Sort(new StudentComparer(StudentComparer.CompareType.name));
                    //foreach (Student item in list)
                    //    Console.WriteLine(item.ToString());

                }
                else if (N == 3)
                {
                    Console.WriteLine("Welcome your next coming ");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}  
