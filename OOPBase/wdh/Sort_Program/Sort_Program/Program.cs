using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();

            Console.Write("请输入学生的人数：");
            int number = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.Write("请输入第" + i + "个学生的名字：");
                string __name = Console.ReadLine();

                Console.Write("请输入第" + i + "个学生的分数:");
                int __score = Int32.Parse(Console.ReadLine());

                studentList.Add(new Student(__score, __name));
            }

            //studentList.Add(new Student(80, "王东鸿"));
            //studentList.Add(new Student(90, "陈思涌"));
            //studentList.Add(new Student(80, "刘冰星"));
            //studentList.Add(new Student(88, "罗蔚"));
            //studentList.Add(new Student(95, "闫培松"));

            Console.WriteLine("请选择功能:");
            Console.WriteLine("1:按分数升序!");
            Console.WriteLine("2:按名字升序!");
            Console.WriteLine("3:退出程序!");
            int k;
            string loop;
 
           do{ 
           

            k = Int32.Parse(Console.ReadLine());
                switch (k)
                {
                    case 1:
                        {
                            studentList.Sort(Sort_Score.SortStudent);
                            Console.WriteLine("姓名" + "\t" + "分数");
                            foreach (var s in studentList)
                            {
                                Console.WriteLine(s.Name + "\t" + s.Score);
                            }
                            Console.WriteLine("是否继续？（Y/N）");
                            loop= Console.ReadLine();
                            if (loop == "Y" || loop == "y")
                            {
                                Console.WriteLine("请选择功能:");
                                Console.WriteLine("1:按分数升序!");
                                Console.WriteLine("2:按名字升序!");
                                Console.WriteLine("3:退出程序!");
                                continue;
                            }
                            else
                            {
                                Environment.Exit(0);
                            }
                            break;
                      
                        }

                    case 2:
                        {
                            studentList.Sort(Sort_Name.SortStudentt);
                            Console.WriteLine("姓名" + "\t" + "分数");
                            foreach (var s in studentList)
                            {
                                Console.WriteLine(s.Name + "\t" + s.Score);
                            }
                            Console.WriteLine("是否继续？（Y/N）");
                            loop = Console.ReadLine();
                            if (loop == "Y" || loop == "y")
                            {
                                Console.WriteLine("请选择功能:");
                                Console.WriteLine("1:按分数升序!");
                                Console.WriteLine("2:按名字升序!");
                                Console.WriteLine("3:退出程序!");
                            }
                            else
                            {
                                Environment.Exit(0);
                            }
                        }
                        break;

                    case 3:
                        {
                            Environment.Exit(0);
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("输入不符合要求；请重新输入");
                            Console.WriteLine("请选择功能:");
                            Console.WriteLine("1:按分数升序!");
                            Console.WriteLine("2:按名字升序!");
                            Console.WriteLine("3:退出程序!");
                            continue;
                        }                            
                }
           } while (k != 3); 
        }
    }
}

