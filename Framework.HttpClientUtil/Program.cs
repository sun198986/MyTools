using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Framework.HttpClientUtil
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClientCommit hcc = new HttpClientCommit();
            //string currDir = AppDomain.CurrentDomain.BaseDirectory;
            //string fileFullName = string.Format(@"{0}Demo\国医检（设）字GYJ2020第3169号(1).docx", currDir);
            //hcc.PostFormFilesAndParam(@"http://192.168.30.209:8989//Report/WordConvertPdf", fileFullName);
            hcc.GetAsync("http://localhost:5000/api/regist?search=Address:3&orderby=Address");
        }
    }
}
