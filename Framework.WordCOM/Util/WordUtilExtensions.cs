using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.WordCOM.Util
{
    public class WordUtilExtensions : WordUtil
    {
        public WordUtilExtensions()
        {

        }

        public WordUtilExtensions(string outFileFullName, string fileFullName = "", bool isSaveAs = true) : base(outFileFullName, fileFullName, isSaveAs)
        {

        }

        /// <summary>
        /// 在单元格右下角添加内容
        /// </summary>
        public int AddCellLowerRightCornerContent(string bookmark, string content)
        {
            try
            {
                Range range = this.GetBookmarkRank(_currentWord, bookmark);
                Cell cell = range.Cells[1];
                AddCellLowerRightCornerContent(cell, content);
            }
            catch (Exception ex)
            {
                _needWrite = false;
                Dispose();
                throw new Exception($"错误信息:{ex.StackTrace.ToString()}.{ex.Message}");
            }
            return 1;
        }

        public int TestPageHeight(string bookmark)
        {

            try
            {
                Range range = this.GetBookmarkRank(_currentWord, bookmark);
                
                range.Select();
                float cellPosition =   (float)range.Information[WdInformation.wdVerticalPositionRelativeToPage];
                float pageHeight= range.PageSetup.PageHeight;
                float footDistance = range.PageSetup.FooterDistance;
                float cellHeight = range.Cells[1].Height;

                Table table = range.Tables[1];
                table.Select();
                float tablePosition = (float)table.Range.Information[WdInformation.wdVerticalPositionRelativeToPage];
                
                Console.WriteLine($"cellPositonTop:{cellPosition},pageHeight:{pageHeight},footDistance:{footDistance},cellHeight:{cellHeight},tablePostionTop:{tablePosition}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return 1;
        }

       
    }
}
