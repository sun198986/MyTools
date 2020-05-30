using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Framework.MD5Encrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceString = "123";
            string resultMD5 =  MD5Helper.MD5Encrypt(sourceString);
            Console.WriteLine(resultMD5);
            Console.ReadLine();
        }
    }
}
