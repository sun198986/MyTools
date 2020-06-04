using System;
using Framework.FileUtil.Interface;
using Framework.ProcessUtil;

namespace Framework.WordCOM.Util
{
    public class CalculatePageHeight
    {
        public void calculatePage()
        {
            ProcessControl processControl = new ConcreteProcessControl();
            processControl.KillWordProcess();
            string currDir = AppDomain.CurrentDomain.BaseDirectory;
            string fileFullName = string.Format(@"{0}Demo\StandardReport.docx", currDir);
            string outDirctoryUrl = string.Format(@"{0}NewFiles", currDir);
            FileControl fileControl = new ConcreteFileControl();
            fileControl.CreateDirectory(outDirctoryUrl);
            string outFileFullName = string.Format(@"{0}NewFiles\{1}.docx", currDir, Guid.NewGuid().ToString());

            using (WordUtilExtensions wordUtil = new WordUtilExtensions(outFileFullName, fileFullName))
            {
                
                wordUtil.TestPageHeight("test");
                wordUtil.TestPageHeight("test1");
                wordUtil.TestPageHeight("test3");
            }

            Console.WriteLine("success");
            Console.ReadLine();
        }
    }
}