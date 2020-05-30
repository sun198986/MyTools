using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.ZipString
{
    class Program
    {
        static void Main(string[] args)
        {
            //test
            string sourceString = "123";
            string result =  ZipStringHelper.CompressString(sourceString);
            Console.WriteLine(result);
            Console.ReadLine();
            string decompress = ZipStringHelper.DecompressString(result);
            Console.WriteLine(decompress);
            Console.ReadLine();
        }
    }
}
