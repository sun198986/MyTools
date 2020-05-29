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
                throw new Exception(string.Format("错误信息:{0}.{1}", ex.StackTrace.ToString(), ex.Message));
            }
            return 1;
        }

       
    }
}
