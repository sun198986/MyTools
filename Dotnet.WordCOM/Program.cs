using Dotnet.WordCOM.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet.WordCOM
{
    class Program
    {
        static void Main(string[] args)
        {
            string currDir = AppDomain.CurrentDomain.BaseDirectory;
            string fileFullName = string.Format(@"{0}demo\标准模板(新).docx", currDir);
            string outFileFullName = string.Format(@"{0}demo\{1}.docx", currDir, Guid.NewGuid().ToString());
            string pictureFullName = string.Format(@"{0}demo\qrcode.jpg", currDir);
            using (WordUtil wordUtil = new WordUtil(outFileFullName, fileFullName))
            {
                wordUtil.AddPictureToWord(pictureFullName, "QRCode", 2f,2f);
            }

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
