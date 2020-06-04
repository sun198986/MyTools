using System;
using Framework.FileUtil.Interface;
using Framework.ProcessUtil;
using Framework.WordCOM.TestReport;

namespace Framework.WordCOM
{
    public class TestReportControl
    {
        public void TestReportFunc()
        {
            ProcessControl processControl = new ConcreteProcessControl();
            processControl.KillWordProcess();
            string currDir = AppDomain.CurrentDomain.BaseDirectory;
            string fileFullName = string.Format(@"{0}Demo\StandardReport.docx", currDir);
            string outDirctoryUrl = string.Format(@"{0}NewFiles", currDir);
            FileControl fileControl = new ConcreteFileControl();
            fileControl.CreateDirectory(outDirctoryUrl);
            string outFileFullName = string.Format(@"{0}NewFiles\{1}.docx", currDir, Guid.NewGuid().ToString());

            using (StandardReportWordUtil wordUtil = new StandardReportWordUtil(outFileFullName, fileFullName))
            {
                wordUtil.TableSplit("standard");
            }

            Console.WriteLine("success");
            Console.ReadLine();
        }
    }
}