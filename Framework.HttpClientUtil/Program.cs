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
            string currDir = AppDomain.CurrentDomain.BaseDirectory;
            string fileFullName = string.Format(@"{0}Demo\标准模板(新).docx", currDir);
            hcc.PostFormFilesAndParam(@"http://192.168.30.209:8989/Report/WordConvertPdf", fileFullName);
        }
    }
}
