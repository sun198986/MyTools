using Framework.ProcessUtil;
using Framwork.FileUtil.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.WordCOM.Util
{
    public class AddToLowerRightCorner
    {
        public void ConcreteAdd() {
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
               int result=  wordUtil.AddCellLowerRightCornerContent("ypms","testcontent");
            }

            Console.WriteLine("success");
            Console.ReadLine();
        }
    }
}
