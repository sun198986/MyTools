﻿using Framework.ProcessUtil;
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
            string fileFullName = string.Format(@"{0}Demo\标准模板(新).docx", currDir);
            string outFileFullName = string.Format(@"{0}NewFiles\{1}.docx", currDir, Guid.NewGuid().ToString());
            string pictureFullName = string.Format(@"{0}Demo\qrcode.jpg", currDir);
            using (WordUtil wordUtil = new WordUtil(outFileFullName, fileFullName))
            {
                wordUtil.AddPictureToWord(pictureFullName, "QRCode",630f,60f, 80f, 80f);
            }

            Console.WriteLine("success");
            Console.ReadLine();
        }
    }
}
