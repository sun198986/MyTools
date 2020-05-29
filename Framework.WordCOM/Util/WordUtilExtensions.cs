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

        public int AddCellLowerRightCornerContent(string bookmark,string content)
        {
            try
            {
                Range range= this.GetBookmarkRank(_currentWord, bookmark);
                Cell cell = range.Cells[1];
                cell.Range.Select();

                object unite = WdUnits.wdLine;
                _wordApp.Selection.EndKey(ref unite, ref _missing);
                _wordApp.Selection.TypeParagraph();
                _wordApp.Selection.TypeText(content);
                _wordApp.Selection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;

                //Paragraph paragraph= _wordApp.Selection.Paragraphs.Add(range);
                //_wordApp.Selection.InsertAfter(content);
                //_wordApp.Selection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
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
