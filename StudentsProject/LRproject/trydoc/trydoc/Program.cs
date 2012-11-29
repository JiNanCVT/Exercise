using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Office.Interop.Word;

namespace trydoc
{
    class Program
    {
        private static string readDoc(string fn)
        {
            try
            {
                object readOnly = true;
                object missing = System.Reflection.Missing.Value;
                object fileName = fn;

                //初始化word程序
                Application wordapp = new Application();

                //打开指定的doc文件
                Document doc = wordapp.Documents.Open(ref fileName,
                    ref missing, ref readOnly, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing, ref missing);

                //读取指定的doc文件的文本
                string txt = doc.Content.Text;

                //关闭doc文件
                doc.Close(ref missing, ref missing, ref missing);

                //退出word程序
                wordapp.Quit(ref missing, ref missing, ref missing);

                return txt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private static int getWordLength(string s)
        {
            if (s != null)
                return s.Length;
            else
                return 0;
        }

        static void Main(string[] args)
        {

            string abc;
            int num, total = 0;
            int count = 0;

            DirectoryInfo dir = new DirectoryInfo(@"e:\trans");

            foreach (FileInfo dChild in dir.GetFiles())
            {

                if (dChild.Extension.Equals(".doc") || dChild.Extension.Equals(".docx"))
                {
                    count++;
                    Console.WriteLine(dChild.FullName);

                    abc = readDoc(dChild.FullName);
                    num = getWordLength(abc);
                    total += num;

                    Console.WriteLine("字数：" + num + "\t总字数：" + total);
                    Console.WriteLine();

                }

            }


            Console.WriteLine("End\t文件数：" + count);
            Console.Read();

        }
    }
}
