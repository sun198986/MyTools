using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.QRCodeUtil
{
    class Program
    {
        static void Main(string[] args)
        {
            string currDir = AppDomain.CurrentDomain.BaseDirectory;
            string outFileFullName = string.Format(@"{0}NewFiles\{1}.jpg", currDir, Guid.NewGuid().ToString());
            using (QRCodeUtil qRCodeUtil = new QRCodeUtil()) {
                qRCodeUtil.QRCode(outFileFullName, "123123");
            }
        }
    }
}
