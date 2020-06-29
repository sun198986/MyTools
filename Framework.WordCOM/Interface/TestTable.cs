using System;
using Framework.FileUtil.Interface;
using Framework.ProcessUtil;
using Framework.WordCOM.Util;

namespace Framework.WordCOM.Interface
{
    public class TestTable
    {
        public void TestReportFunc()
        {
            ProcessControl processControl = new ConcreteProcessControl();
            processControl.KillWordProcess();
            string currDir = AppDomain.CurrentDomain.BaseDirectory;
            string fileFullName = $@"{currDir}Demo\test.docx";
            string outDirectoryUrl = $@"{currDir}NewFiles";
            FileControl fileControl = new ConcreteFileControl();
            fileControl.CreateDirectory(outDirectoryUrl);
            string outFileFullName = $@"{currDir}NewFiles\{Guid.NewGuid()}.docx";

            using (WordUtilExtensions wordUtil = new WordUtilExtensions(outFileFullName, fileFullName))
            {
                wordUtil.AddTableTest();
            }

            Console.WriteLine("success");
            Console.ReadLine();
        }
    }
}