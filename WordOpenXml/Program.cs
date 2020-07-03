/***
 * https://docs.microsoft.com/zh-cn/dotnet/api/documentformat.openxml.wordprocessing?view=openxml-2.8.1
 * */
using System;

namespace WordOpenXml
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = $"{AppDomain.CurrentDomain.BaseDirectory}\\Demo\\demo.docx";
            WordXml.CreateWordDoc(filepath, "你好");
            Console.WriteLine("Hello World!");
        }
    }
}
