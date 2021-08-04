using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ServiceReference1.ProxyClient().GetAppPopedom("服务业务管理系统","MASSVSC","1");
        }
    }
}
