using PowerPoint;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word;

namespace Framework.WpsWordDemo
{
    public class ToPdfHelper : IDisposable

    {

        dynamic wps;

        public ToPdfHelper(string typeName)

        {

            if (typeName == "xls")

                typeName = "KET.Application";

            else if (typeName == "ppt")

                typeName = "KWPP.Application";

            else

                typeName = "KWps.Application";

            //创建wps实例，需提前安装wps

            Type type = Type.GetTypeFromProgID(typeName);

            if (type == null)

                type = Type.GetTypeFromProgID("wps.Application");

            wps = Activator.CreateInstance(type);

        }

        /// <summary>

        /// 使用wps将Word转PDF

        /// </summary>

        /// <param name="saveUrl">文件路径</param>

        /// <param name="targetPath">源文件路径</param>

        /// <returns></returns>

        public string WordWpsToPdf( string targetPath)

        {

            if (targetPath == null)

            {

                throw new ArgumentNullException("wpsFilename");

            }

            var wordPath =  targetPath;

            var pdfPath = Path.ChangeExtension(wordPath, "pdf");

            try

            {

                //用wps 打开word不显示界面

                dynamic doc = wps.Documents.Open(wordPath, Visible: false);

                //doc 转pdf

                doc.ExportAsFixedFormat(pdfPath, WdExportFormat.wdExportFormatPDF);

                //设置隐藏菜单栏和工具栏

                //wps.setViewerPreferences(PdfWriter.HideMenubar | PdfWriter.HideToolbar);

                doc.Close();

                doc = null;

            }

            catch (Exception)

            {

                //targetPath = GetEXCELtoPDF.CreatePDFs(saveUrl, targetPath);

            }

            finally

            {

                Dispose();

            }

            return Path.ChangeExtension(targetPath, "pdf");

        }


        public void Dispose()

        {
            if (wps != null) { wps.Quit(); wps = null; }
        }

    }
}
