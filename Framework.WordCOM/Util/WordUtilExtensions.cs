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

        public int AddOperation(string bookmark)
        {
            //添加运算类
            Range range = this.GetBookmarkRank(_currentWord, bookmark);

            range.Select();

            //Range om = _wordApp.Selection.OMaths.Add(range);
            //_wordApp.Selection.OMaths.BuildUp();
            //_wordApp.Selection.OMaths[1].Functions.Add(_wordApp.Selection.Range, WdOMathFunctionType.wdOMathFunctionAcc).Acc.Char = 773;
            //_wordApp.Selection.MoveLeft(WdUnits.wdCharacter, 1, WdMovementType.wdMove);
            //_wordApp.Selection.InsertSymbol(-10187, null, true, WdFontBias.wdFontBiasDefault);
            //_wordApp.Selection.InsertSymbol(-8433, null, true, WdFontBias.wdFontBiasDefault);

            Range om = _wordApp.Selection.OMaths.Add(range);
            _wordApp.Selection.OMaths.BuildUp();
            //_wordApp.Selection.OMaths[1].Functions.Add(_wordApp.Selection.Range, WdOMathFunctionType.wdOMathFunctionDelim,1).Delim.BegChar = 773;
            var omatchFunc = _wordApp.Selection.OMaths[1].Functions
                .Add(_wordApp.Selection.Range, WdOMathFunctionType.wdOMathFunctionDelim, 1);
            omatchFunc.Delim.BegChar = 124;
            omatchFunc.Delim.SepChar = 0;
            omatchFunc.Delim.EndChar = 124;
            omatchFunc.Delim.Grow = true;
            omatchFunc.Delim.Shape = WdOMathShapeType.wdOMathShapeCentered;
            _wordApp.Selection.MoveLeft(WdUnits.wdCharacter, 1, WdMovementType.wdMove);
            _wordApp.Selection.InsertSymbol(8242, "Cambria Math", true, WdFontBias.wdFontBiasDefault);
            _wordApp.Selection.InsertAfter("v");
            _wordApp.Selection.MoveLeft(WdUnits.wdCharacter, 2, WdMovementType.wdMove);
            _wordApp.Selection.InsertAfter("F");

            return 1;

        }

    }
}
