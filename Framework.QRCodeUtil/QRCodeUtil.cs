/*ThoughtWorks.QRCode 1.1.0
 * */

using System;
using System.Drawing;
using System.Text;
using ThoughtWorks.QRCode.Codec;

namespace Framework.QRCodeUtil
{
    public class QRCodeUtil : IDisposable
    {
        public void QRCode(string filePath, string enCodeString)
        {
            try
            {
                Bitmap bt = null;
                QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
                qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;//编码方式(注意：BYTE能支持中文，ALPHA_NUMERIC扫描出来的都是数字)
                qrCodeEncoder.QRCodeScale = 10;//大小(值越大生成的二维码图片像素越高)
                qrCodeEncoder.QRCodeVersion = 0;//版本(注意：设置为0主要是防止编码的字符串太长时发生错误)
                qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;//错误效验、错误更正(有4个等级)
                qrCodeEncoder.QRCodeBackgroundColor = System.Drawing.Color.White;//背景色
                qrCodeEncoder.QRCodeForegroundColor = System.Drawing.Color.Black;//前景色
                bt = qrCodeEncoder.Encode(enCodeString, Encoding.UTF8);

                bt.Save(filePath);//保存图片
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
