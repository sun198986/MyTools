using System;
using Word.OfficeCOM.Utils;

namespace Word.OfficeCOM
{
    class Program
    {
        static void Main(string[] args)
        {
            string currDir = AppDomain.CurrentDomain.BaseDirectory;
            string fileFullName = string.Format(@"{0}demo\标准模板(新).docx", currDir);
            string outFileFullName = string.Format(@"{0}demo\{1}.docx", currDir,Guid.NewGuid().ToString());
            string pictureFullName = string.Format(@"{0}demo\", currDir);
            using (WordUtil wordUtil = new WordUtil(outFileFullName, fileFullName)) { 
                
            }

            Console.WriteLine("Hello World!");
        }
    }
}
