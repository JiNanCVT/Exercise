using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1
{
    class Output
    {
        public Output(int  choseInt, IOrderedEnumerable<Student> list1, IOrderedEnumerable<Student> list2)
        {
            
                if (choseInt == 1)
                {
                    foreach (Student s in list1)
                    {
                        Console.WriteLine(s.name + s.score);

                    }
                    Console.Read();
                }
                else
                {
                    if (choseInt == 2)
                    {
                        foreach (Student s in list2)
                        {
                            Console.WriteLine(s.name + s.score);

                        }
                        Console.Read();
                    }
                    else
                    {
                        Console.WriteLine("请输入1或者2");
                        Console.Read();
                    }
                }
            } 
        }
    }

