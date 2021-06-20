using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;

namespace Framework.HttpClientUtil
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClientCommit hcc = new HttpClientCommit();
            //string currDir = AppDomain.CurrentDomain.BaseDirectory;
            //string fileFullName = string.Format(@"{0}Demo\国医检（设）字GYJ2020第3169号(1).docx", currDir);
            //hcc.PostFormFilesAndParam(@"http://localhost:15280/User/Login", "");
            //hcc.GetAsync("http://localhost:5000/api/regist?search=Address:3&orderby=Address");

            var http = new HttpHelp();

            var tasks = new List<Task>();

            for (int i = 0; i < 100; i++)
            {
                var i1 = i;
                
                var task1 = Task.Factory.StartNew(http.TestPost);
                tasks.Add(task1);
            }

            Task.WaitAny(tasks.ToArray());

            Console.ReadLine();
        }

        
    }
}
