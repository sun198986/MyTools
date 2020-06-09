using Framework.ProcessUtil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.WordCOM.Util
{
    public class QRCodeControl
    {
        public void AddQRCode() {
            ProcessControl processControl = new ConcreteProcessControl();
            processControl.KillWordProcess();
            string currDir = AppDomain.CurrentDomain.BaseDirectory;
            string fileFullName = string.Format(@"{0}Demo\StandardReport29c2fdba-ec2a-4ba8-bdba-45740deae924.docx", currDir);
            string outFileFullName = string.Format(@"{0}NewFiles\{1}.docx", currDir, Guid.NewGuid().ToString());
            string pictureFullName = string.Format(@"{0}Demo\qrcode.jpg", currDir);
            using (WordUtil wordUtil = new WordUtil(outFileFullName, fileFullName))
            {
                wordUtil.AddPictureToWord(pictureFullName, "main_qrcode", 630f,60f, 80f, 80f);
            }

            Console.WriteLine("success");
            Console.ReadLine();
        }
    }
}
