using Framework.ProcessUtil;
using Framework.WordCOM.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.WordCOM
{
    class Program
    {
        static void Main(string[] args)
        {
            //添加二维码
            //QRCodeControl qc = new QRCodeControl();
            //qc.AddQRCode();

            //单元格右下角添加内容
            //add content to lower right corner

            //AddToLowerRightCorner atl = new AddToLowerRightCorner();
            //atl.ConcreteAdd();

            //CalculatePageHeight cph = new CalculatePageHeight();
            //cph.calculatePage();

            TestReportControl trc = new TestReportControl();
            trc.TestReportFunc();
        }
    }
}
