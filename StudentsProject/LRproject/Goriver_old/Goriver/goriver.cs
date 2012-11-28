using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goriver
{
    class goriver
    {
        public int farmer = 0, fox = 0, chicken = 0, vegetable = 0;//声明成员，农夫，狐狸，鸡，菜和状态，0表示本岸，1表示对岸
        public int sum = 0;//记录走的步数，最后for循环输出
        public int add = 1;
        public bool[, , ,] path = new bool[2, 2, 2, 2];//状态表，共16个状态
        public String[] result = new String[10];//字符串数组，用于最后输出

        public bool win()
        {
            if (4 == farmer + fox + chicken + vegetable) return true;
            return false;
        }//判断是否胜利

        public bool kill()
        {
            if (fox == chicken && farmer != chicken || chicken == vegetable && farmer != vegetable) return true;
            return false;
        }//判断是否不满足条件

        public bool marked()
        {
            if (path[farmer, fox, chicken, vegetable] == true) return true;
            return false;
        }//判断状态表中是否已经被标记

        public void mark()
        {
            path[farmer, fox, chicken, vegetable] = true;
        }//标记状态表中当前位置，用true标记

        public void unmark()
        {
            path[farmer, fox, chicken, vegetable] = false;
        }//反标记为false

        public void record()
        {
            String temp = " ";
            String a1 = "farmer ";
            String a2 = "fox ";
            String a3 = "chicken ";
            String a4 = "vegetable ";
            String b1 = "       ";
            String b2 = "    ";
            String b3 = "        ";
            String b4 = "          ";
            if (farmer == 1)
            {
                temp = a1; a1 = b1; b1 = temp;
            }
            if (fox == 1)
            {
                temp = a2; a2 = b2; b2 = temp;
            }
            if (chicken == 1)
            {
                temp = a3; a3 = b3; b3 = temp;
            }
            if (vegetable == 1)
            {
                temp = a4; a4 = b4; b4 = temp;
            }  //一种表示方法处理格式
            result[sum] = a1 + a2 + a3 + a4 + "<--->" + b1 + b2 + b3 + b4;
            sum++;
        }//用result字符串数组记录一次行动，用于输出，步数sum+1

        public void unrecord()
        {
            sum--;
        }//反记录，因为最后用sum循环输出，所以只把sum-1,并未清空记录表，

        public void show()
        {
            int i;
            Console.WriteLine("farmer fox chicken vegetable <--->");
            for (i = 0; i < sum; i++) Console.WriteLine(result[i]);
            Console.WriteLine("\n\n");
        }
    }
}
