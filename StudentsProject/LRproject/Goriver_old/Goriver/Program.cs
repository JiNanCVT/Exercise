using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goriver
{
    class Program
    {
        static void start(goriver a)
        {
            if (a.win() == true)
            {
                Console.WriteLine(a.add); a.add++; a.show(); a.unrecord(); a.unmark();
            }
            //判断是否胜利，调用win方法，若是，则调用show方法输出
            else
            {
                if (true)
                {
                    a.farmer = 1 - a.farmer; //利用0+1=1进行赋值，表示到对岸去，表示已行动
                    if (a.kill() == false && a.marked() == false)//同时满足没有kill且没有走过被mark的地方，进行下一步
                    {
                        a.mark(); a.record(); start(a);
                    }//满足时，标记新地方，记录，表示行动有效，再次运行start
                    a.farmer = 1 - a.farmer;//若无法满足可移动（默认农夫可移动），没有kill，没有mark，行动无效，返回
                }
                //行动1，船夫自己过河，下分别为带狐狸，鸡，菜过河
                if (a.farmer == a.fox)
                {
                    a.fox = 1 - a.fox; a.farmer = 1 - a.farmer;
                    if (a.kill() == false && a.marked() == false)//同时满足没有kill且没有走过被mark的地方，进行下一步
                    {
                        a.mark(); a.record(); start(a);
                    }
                    a.fox = 1 - a.fox; a.farmer = 1 - a.farmer;
                }

                if (a.farmer == a.chicken)
                {
                    a.chicken = 1 - a.chicken; a.farmer = 1 - a.farmer;
                    if (a.kill() == false && a.marked() == false)//同时满足没有kill且没有走过被mark的地方，进行下一步
                    {
                        a.mark(); a.record(); start(a);
                    }
                    a.chicken = 1 - a.chicken; a.farmer = 1 - a.farmer;
                }

                if (a.farmer == a.vegetable)
                {
                    a.vegetable = 1 - a.vegetable; a.farmer = 1 - a.farmer;
                    if (a.kill() == false && a.marked() == false)//同时满足没有kill且没有走过被mark的地方，进行下一步
                    {
                        a.mark(); a.record(); start(a);
                    }
                    a.vegetable = 1 - a.vegetable; a.farmer = 1 - a.farmer;
                }
                /*若能运行到此，说明虽然上一步行动有效(已标记和记录），但是没有跳出到show方法输出，
                      也没有再次标记等进入下一步(4中行动运行结束），即进入"死胡同"，这样上一步行动其实无意义，
                         因此下面行进反记录，反标记，以便在循环中继续（在上一步行动中进行另外的行动，保持上一步并未标记和记录）
                  而若第一次循环就运行到此，所以题目无解，反标记，反记录，并不影响*/
                a.unrecord();
                a.unmark();
            }
        }//一种算法

        static void Main(string[] args)
        {
            goriver go = new goriver();
            go.mark();
            start(go);
            Console.Read();
        }
    }
}
