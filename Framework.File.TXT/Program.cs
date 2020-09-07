using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.File.TXT
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"E:\demo\testtxt.txt";
            if (!System.IO.File.Exists(filename))
            {
                //没有则创建这个文件
                FileStream fs1 = new FileStream(filename, FileMode.Create, FileAccess.Write);//创建写入文件
                StreamWriter sw = new StreamWriter(fs1);
                sw.WriteLine("test时间:"+DateTime.Now.ToString("yyyyMMdd HHmmss"));//开始写入值
                sw.Close();
                fs1.Close();
                Console.WriteLine("创建成功");
                Console.ReadLine();
            }
            else
            {
                FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Write);
                StreamWriter sr = new StreamWriter(fs);
                sr.WriteLine("test时间:" + DateTime.Now.ToString("yyyyMMdd HHmmss"));//开始写入值
                sr.Close();
                fs.Close();
                Console.WriteLine("修改成功");
                Console.ReadLine();
            }
        }
    }
}
