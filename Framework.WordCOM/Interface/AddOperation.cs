using System;
using Framework.FileUtil.Interface;
using Framework.ProcessUtil;
using Framework.WordCOM.Util;

namespace Framework.WordCOM.Interface
{
    public class AddOperation
    {
        public void conreteOperation()
        {
            ProcessControl processControl = new ConcreteProcessControl();
            processControl.KillWordProcess();
            string currDir = AppDomain.CurrentDomain.BaseDirectory;
            string fileFullName = string.Format(@"{0}Demo\标准模板(新).docx", currDir);
            string outDirctoryUrl = string.Format(@"{0}NewFiles", currDir);
            FileControl fileControl = new ConcreteFileControl();
            fileControl.CreateDirectory(outDirctoryUrl);
            string outFileFullName = string.Format(@"{0}NewFiles\{1}.docx", currDir, Guid.NewGuid().ToString());

            using (WordUtilExtensions wordUtil = new WordUtilExtensions(outFileFullName, fileFullName))
            {
                int result = wordUtil.AddOperation("bgbh");
            }

            Console.WriteLine("success");
            Console.ReadLine();
        }
    }
}