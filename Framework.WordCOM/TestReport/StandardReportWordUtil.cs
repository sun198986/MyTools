using System;
using System.Collections.Generic;
using System.IO;
using Framework.WordCOM.Util;
using Microsoft.Office.Interop.Word;
using Newtonsoft.Json.Linq;
using System.Drawing;
using System.Linq;

namespace Framework.WordCOM.TestReport
{
    public class StandardReportWordUtil : WordUtil
    {

        /// 打开现有文件操作
        /// </summary>
        /// <param name="fileFullName">需保存文件的路径</param>
        public StandardReportWordUtil(string fileFullName) : base(fileFullName)
        {

        }

        public StandardReportWordUtil(string outFileFullName, string fileFullName = "", bool isSaveAs = true) : base(outFileFullName, fileFullName, isSaveAs)
        {

        }
        #region 标准报告业务相关

        protected Dictionary<Cell, string> lowerRightCornerCells = new Dictionary<Cell, string>();

        public virtual int TableSplit(string bookmark)
        {
            try
            {
                List<CellInfo> cellList = new List<CellInfo>();

                int pageIndex = 0;
                Range tableRange = GetBookmarkRank(_currentWord, bookmark);
                Table table = tableRange.Tables[1];

                Cells cells = table.Range.Cells;

                foreach (Cell cell in cells)
                {

                    Range r = cell.Range;
                    int rowNumber = (int)r.Information[WdInformation.wdStartOfRangeRowNumber];
                    int columnNumber = (int)r.Information[WdInformation.wdStartOfRangeColumnNumber];
                    int pageNumber = (int)r.Information[WdInformation.wdActiveEndPageNumber];
                    cellList.Add(new CellInfo(r.Text, rowNumber, columnNumber, pageNumber,cell));
                    if (r.Text.Equals("\r\a") && !r.Text.Contains("$$"))
                    {
                        continue;
                    }
                    r.Select();
                    if (_wordApp.Selection.Bookmarks.Exists("photo"))
                        break;

                    if (pageNumber >= 6 && pageNumber != pageIndex)
                    {

                        //判断第一列最后一个单元格 的高度
                        CellInfo cellInfo = cellList.LastOrDefault(p => p.ColumnNumber == 1);
                        if (cellInfo != null)
                        {
                            Cell firstLastCell = table.Cell(cellInfo.RowNumber, cellInfo.ColumnNumber);
                            if (HandleFirstColumnCellAddRow(firstLastCell,pageNumber,table,cellList))
                            {
                                pageIndex = pageNumber;
                                continue;
                            }
                        }
                        r.Select();
                        _wordApp.Selection.SplitTable();

                        List<Cell> cellNextList = new List<Cell>();
                        for (int j = 1; j <= 11; j++)
                        {
                            Cell cellNext = TableContinueContent(table, j, cellList, pageNumber);
                            if (cellNext != null)
                                cellNextList.Add(cellNext);
                        }

                        //处理单项结论
                        HandleConclusion(table, cellList, cellNextList);

                        _wordApp.Selection.Delete(WdUnits.wdCharacter, 1);
                        pageIndex = pageNumber;
                    }
                }
                //替换字符
                Dictionary<int, Dictionary<string, string>> replaceDic = new Dictionary<int, Dictionary<string, string>>();
                Dictionary<string, string> valuePairs = new Dictionary<string, string>();
                valuePairs.Add("$$", "");//报告编号
                replaceDic.Add(1, valuePairs);//替换全部内容
                ReplaceWritten(replaceDic);

                return 1;
            }
            catch (Exception ex)
            {
                _needWrite = false;
                Dispose();
                throw new Exception(string.Format("错误信息:{0}.{1}", ex.StackTrace.ToString(), ex.Message));
            }

        }

        protected virtual bool HandleFirstColumnCellAddRow(Cell firstLastCell, int pageNumber, Table table, List<CellInfo> cellList)
        {
            firstLastCell.Select();
            float cellPositionTop =
                (float)firstLastCell.Range.Information[WdInformation.wdVerticalPositionRelativeToPage];
            float pageHeight = firstLastCell.Range.PageSetup.PageHeight;
            bool result = pageHeight - cellPositionTop < 190;
            if (result)
            {
                _wordApp.Selection.InsertRowsAbove(1);
                _wordApp.Selection.Cells.Merge();
                _wordApp.Selection.Borders[WdBorderType.wdBorderLeft].LineStyle = WdLineStyle.wdLineStyleNone;
                _wordApp.Selection.Borders[WdBorderType.wdBorderRight].LineStyle = WdLineStyle.wdLineStyleNone;
                _wordApp.Selection.Borders[WdBorderType.wdBorderBottom].LineStyle = WdLineStyle.wdLineStyleNone;
                Cell secondLastCell = _wordApp.Selection.Cells[1];

                while ((int)firstLastCell.Range.Information[WdInformation.wdActiveEndPageNumber] != pageNumber)
                {
                    secondLastCell.SetHeight(secondLastCell.Height + 1, WdRowHeightRule.wdRowHeightAtLeast);
                }
            }

            return result;
        }

        protected virtual bool HandleFirstColumnCell(Cell firstLastCell,int pageNumber,Table table,List<CellInfo> cellList)
        {
            firstLastCell.Select();
            
            float cellPositionTop =
                (float)firstLastCell.Range.Information[WdInformation.wdVerticalPositionRelativeToPage];
            float pageHeight = firstLastCell.Range.PageSetup.PageHeight;
            if (pageHeight - cellPositionTop < 150)
            {
                List<CellInfo> firstColumnList = cellList.Where(p => p.ColumnNumber == 1).ToList();
                CellInfo lastSecondCellInfo = firstColumnList[firstColumnList.Count - 2];
                Cell secondLastCell = table.Cell(lastSecondCellInfo.RowNumber, lastSecondCellInfo.ColumnNumber);

                while ((int)firstLastCell.Range.Information[WdInformation.wdActiveEndPageNumber] != pageNumber)
                {
                    secondLastCell.SetHeight(secondLastCell.Height + 1, WdRowHeightRule.wdRowHeightAtLeast);
                }
            }

            return pageHeight - cellPositionTop < 150;
        }

        protected virtual void HandleConclusion(Table table, List<CellInfo> cellList, List<Cell> nextCellList)
        {

            //新的单项结论表格(第二个表格倒数第二行)
            if (nextCellList.Count < 2)
            {
                return;
            }
            Cell nextCellInfo = nextCellList[nextCellList.Count - 2];

            //找到最后一个带$$的单元格
            CellInfo cellInfo = cellList.Where(p => p.CellText.Contains("$$")).LastOrDefault();
            if (nextCellInfo.Range.Text.Equals("") || nextCellInfo.Range.Text.Equals("\r\a"))
                nextCellInfo.Range.InsertAfter(cellInfo.CellText.Replace("\r\a", ""));

        }

        protected virtual Cell TableContinueContent(Table table, int column, List<CellInfo> list, int pageIndex)
        {

            Cell cellInfo = null;
            Range range = table.Range.GoToNext(WdGoToItem.wdGoToTable);
            Table tableNext = range.Tables[1];
            try
            {
                cellInfo = tableNext.Cell(1, column);
            }
            catch (Exception)
            {
                return null;
            }
            if (!tableNext.Cell(1, column).Range.Text.Equals("\r\a") || column > 4)
                return cellInfo;
            string cellText = "";
            int inoRow = table.Range.Paragraphs.Count;

            cellText = list.Where(p => p.ColumnNumber == column).OrderByDescending(p => p.RowNumber).First().CellText;
            if (!cellText.Contains("续") && column == 1)
                cellText = "续\r\a" + cellText.Replace("\r\a", "");
            tableNext.Cell(1, column).Range.InsertAfter(cellText.Replace("\r\a", ""));
            return cellInfo;
        }

        /// <summary>
        /// 表格拆分
        /// </summary>
        /// <param name="array">拆分数组</param>
        /// <param name="bookmark">书签</param>
        /// <returns></returns>
        public virtual int TableSplit(JArray array, string bookmark)
        {
            try
            {
                Range tableRange = GetBookmarkRank(_currentWord, bookmark);

                Table table = tableRange.Tables[1];

                for (int i = array.Count - 1; i >= 0; i--)
                {
                    TableSplit((JObject)array[i], i + 1, table);
                }

                table.Cell(1, 1).Select();
                _wordApp.Selection.Rows.HeadingFormat = -1;
                ClearTableFormat(table);

                if (lowerRightCornerCells.Count > 0)
                {
                    foreach (var item in lowerRightCornerCells)
                    {
                        Cell cell = item.Key;
                        string content = item.Value;
                        AddCellLowerRightCornerContent(cell, content);
                    }
                }

                return 1;
            }
            catch (Exception ex)
            {
                _needWrite = false;
                Dispose();
                throw new Exception(string.Format("错误信息:{0}.{1}", ex.StackTrace.ToString(), ex.Message));
            }

        }

        protected virtual void ClearTableFormat(Table table)
        {
            table.Select();
            _wordApp.Selection.ParagraphFormat.SpaceBeforeAuto = 0;
            _wordApp.Selection.ParagraphFormat.SpaceAfterAuto = 0;
            _wordApp.Selection.ParagraphFormat.AutoAdjustRightIndent = 0;
            _wordApp.Selection.ParagraphFormat.DisableLineHeightGrid = -1;
            _wordApp.Selection.ParagraphFormat.WordWrap = -1;
        }

        /// <summary>
        /// 表格拆分
        /// </summary>
        /// <param name="jObject">拆分对象</param>
        /// <param name="xuhao">序号</param>
        /// <param name="table">需拆分表格</param>
        /// <returns></returns>
        public virtual int TableSplit(JObject jObject, int xuhao, Table table)
        {

            table.Cell(1, 1).Select();
            _wordApp.Selection.InsertRowsBelow(1);
            _wordApp.Selection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphJustify;
            _wordApp.Selection.Cells.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalTop;
            _wordApp.Selection.Font.NameFarEast = "宋体";
            _wordApp.Selection.Font.NameAscii = "宋体";
            _wordApp.Selection.Font.NameOther = "宋体";
            // Row newRow = table.Rows[2];

            //序号
            table.Cell(2, 1).Range.Text = jObject["idxNo"].ToString().Trim();
            //检验项目
            table.Cell(2, 2).Range.Text = jObject["itemContent"].ToString();
            //单项结论
            if (jObject["comment"] != null)
                table.Cell(2, 6).Range.Text = "$$" + jObject["comment"].ToString();
            //备注
            if (jObject["reMark"] != null && !jObject["reMark"].ToString().Equals(""))
                table.Cell(2, 7).Range.Text = jObject["reMark"].ToString();

            JArray firstItems = (JArray)jObject["list"];

            if (firstItems.Count != 0)
            {
                int firstItemsCount = firstItems.Count;
                //标准条款
                Cell cell3 = table.Cell(2, 3);
                cell3.Split(firstItemsCount, 1);
                for (int i = 0; i < firstItemsCount; i++)
                {
                    table.Cell(2 + i, 3).Range.Text = firstItems[i]["stdItmNo"].ToString();
                }

                //标准要求
                Cell cell4 = table.Cell(2, 4);
                Cell cell5 = table.Cell(2, 5);
                cell4.Split(firstItemsCount, 1);
                cell5.Split(firstItemsCount, 1);

                //拆分备注列
                Cell cell7 = table.Cell(2, 7);
                cell7.Split(firstItemsCount, 1);

                Dictionary<JObject, string> cellCol4Dic = new Dictionary<JObject, string>();
                for (int i = 0; i < firstItemsCount; i++)
                {
                    Cell tempCell = table.Cell(2 + i, 4);
                    JObject firstItem = (JObject)firstItems[i];
                    tempCell.Range.Text = firstItem["stdName"].ToString();
                    cellCol4Dic.Add(firstItem, (2 + i).ToString() + "," + 4.ToString());

                }

                //遍历节点拆分单元格
                bool whilebool = true;
                while (whilebool)
                {
                    cellCol4Dic = AddCellAndSplit(table, cellCol4Dic, lowerRightCornerCells);
                    whilebool = (cellCol4Dic.Count != 0);
                }
            }

            return 1;
        }
        /// <summary>
        /// 遍历节点拆分单元格
        /// </summary>
        /// <returns></returns>
        protected virtual Dictionary<JObject, string> AddCellAndSplit(Table table, Dictionary<JObject, string> cellCol6Dic, Dictionary<Cell, string> lowerRightCornerCells)
        {
            Dictionary<JObject, string> cellCol7Dic = new Dictionary<JObject, string>();
            int incr = 0;
            foreach (var item in cellCol6Dic)
            {
                JObject j = item.Key;
                string c = item.Value;
                int cRow = int.Parse(c.Split(',')[0]) + incr;
                int cCol = int.Parse(c.Split(',')[1]);
                if (j["list"] == null)
                    continue;
                JArray secondItems = (JArray)j["list"];
                int secondItemsCount = secondItems.Count;
                if (secondItemsCount > 0)
                {

                    if (secondItemsCount != 1)
                    {
                        //检验结果列拆分
                        table.Cell(cRow, cCol + 1).Split(secondItemsCount, 1);
                        //备注列拆分
                        table.Cell(cRow, cCol + 3).Split(secondItemsCount, 1);
                    }

                    table.Cell(cRow, cCol).Select();
                    table.Cell(cRow, cCol).Split(secondItemsCount, 2);
                    for (int i = 0; i < secondItemsCount; i++)
                    {
                        table.Cell(cRow + i, cCol).SetWidth(45f, WdRulerStyle.wdAdjustFirstColumn);

                        //table.Cell(cRow+i, cCol).PreferredWidthType = WdPreferredWidthType.wdPreferredWidthPoints;
                        //table.Cell(cRow+i, cCol).PreferredWidth = 40f;
                    }

                    if (secondItemsCount != 1)
                        table.Cell(cRow, cCol).Merge(table.Cell(cRow + secondItemsCount - 1, cCol));
                    // table.Cell(cRow, cCol).SetWidth(40f, WdRulerStyle.wdAdjustFirstColumn);//拆分单元格后设置列宽

                    //结果有拆分的
                    int resultIndex = 0;


                    for (int i = 0; i < secondItemsCount; i++)
                    {
                        //备注列标识 是否有加列
                        int remarkCol = secondItemsCount != 1 ? 4 : 2;

                        Cell tempCell = table.Cell(cRow + i + resultIndex, cCol + 1);
                        JObject secondItem = (JObject)secondItems[i];
                        tempCell.Range.Text = secondItem["stdItmNo"] != null ? secondItem["stdItmNo"].ToString() + secondItem["itemContent"].ToString() : secondItem["itemContent"].ToString();

                        if (secondItem["rightContent"] != null && !secondItem["rightContent"].ToString().Equals(""))
                        {
                            //this.AddCellLowerRightCornerContent(tempCell, secondItem["rightContent"].ToString());
                            lowerRightCornerCells.Add(tempCell, secondItem["rightContent"].ToString());
                        }

                        if (secondItem["reMark"] != null && !secondItem["reMark"].Equals(""))
                        {
                            try
                            {
                                table.Cell(cRow + i + resultIndex, cCol + 4).Range.Text = secondItem["reMark"].ToString();
                            }
                            catch (Exception)
                            {
                                table.Cell(cRow + i + resultIndex, cCol + 2).Range.Text = secondItem["reMark"].ToString();
                            }

                        }
                        //检验结果
                        if (secondItem["controls"] != null && !secondItem["controls"].Equals("") && (secondItem["list"] == null || ((JArray)secondItem["list"]).Count == 0))
                        {
                            Cell resultCell = table.Cell(cRow + i + resultIndex, cCol + 2);
                            JArray resultList = JArray.Parse(secondItem["controls"].ToString());
                            int resultCount = resultList.Count;
                            if (resultCount > 1)
                            {
                                resultCell.Select();
                                resultCell.Split(resultCount, 2);
                                for (int k = 0; k < resultCount; k++)
                                {
                                    //序号列的单元格
                                    Cell xuhaoCell = table.Cell(cRow + i + resultIndex + k, cCol + 2);
                                    xuhaoCell.SetWidth(26f, WdRulerStyle.wdAdjustFirstColumn);
                                    //设置序号列宽度
                                    //xuhaoCell.PreferredWidthType = WdPreferredWidthType.wdPreferredWidthPoints;
                                    //xuhaoCell.PreferredWidth = 25f;

                                }
                                for (int k = 0; k < resultCount; k++)
                                {
                                    Cell xuhaoCell = table.Cell(cRow + i + resultIndex + k, cCol + 2);
                                    xuhaoCell.Range.Text = "#" + (k + 1).ToString();
                                    table.Cell(cRow + i + resultIndex + k, cCol + 2 + 1).Range.Text = resultList[k]["result"].ToString();
                                }
                                resultIndex = resultIndex + resultCount - 1;
                            }
                            else
                            {
                                resultCell.Range.Text = resultList.First["result"].ToString();
                            }

                        }
                        cellCol7Dic.Add(secondItem, (cRow + i + resultIndex).ToString() + "," + (cCol + 1).ToString());
                    }
                    incr = incr + secondItemsCount + resultIndex - 1;
                }
            }

            return cellCol7Dic;
        }

        /// <summary>
        /// 单元格加段 加内容
        /// </summary>
        /// <param name="cell"></param>
        /// <param name="content"></param>
        public virtual void AddCellLowerRightCornerContent(Cell cell, string content)
        {
            try
            {
                cell.Range.Select();
                object unite = WdUnits.wdLine;
                _wordApp.Selection.EndKey(ref unite, ref _missing);
                _wordApp.Selection.TypeParagraph();
                _wordApp.Selection.TypeText(content);
                _wordApp.Selection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
            }
            catch (Exception ex)
            {
                _needWrite = false;
                Dispose();
                throw new Exception(string.Format("错误信息:{0}.{1}", ex.StackTrace.ToString(), ex.Message));
            }

        }

        /// <summary>
        /// 添加附表
        /// </summary>
        public virtual string AddAttachTable(string title, JArray array, string bookmark)
        {
            try
            {
                Range tableRange = GetBookmarkRank(_currentWord, bookmark);
                Table table = tableRange.Tables[1];
                table.Cell(1, 1).Select();
                _wordApp.Selection.InsertRowsBelow(1);
                _wordApp.Selection.Font.NameFarEast = "宋体";
                _wordApp.Selection.Font.NameAscii = "宋体";
                _wordApp.Selection.Font.NameOther = "宋体";
                _wordApp.Selection.Cells.Merge();
                _wordApp.Selection.Range.Text = title;

                int rowIndex = 2;

                for (int i = array.Count - 1; i >= 0; i--)
                {
                    JObject item = (JObject)array[i];
                    table.Cell(rowIndex, 1).Select();
                    _wordApp.Selection.InsertRowsBelow(1);
                    _wordApp.Selection.Font.NameFarEast = "宋体";
                    _wordApp.Selection.Font.NameAscii = "宋体";
                    _wordApp.Selection.Font.NameOther = "宋体";
                    Cell cell = table.Cell(rowIndex + 1, 1);
                    cell.Select();
                    int itemCount = item["isTitle"] != null ? item.Count - 1 : item.Count;
                    if (rowIndex == 2)
                    {
                        cell.Split(1, itemCount);
                    }
                    int cellColumnIndex = 1;
                    foreach (var item2 in item)
                    {
                        if (!item2.Key.ToString().Equals("isTitle"))
                        {
                            table.Cell(rowIndex + 1, cellColumnIndex).Range.Text = item2.Value.ToString();
                            cellColumnIndex++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _needWrite = false;
                Dispose();
                throw new Exception(string.Format("错误信息:{0}.{1}", ex.StackTrace.ToString(), ex.Message));
            }
            return "创建成功";
        }

        #endregion
    }

    public class CellInfo
    {

        public CellInfo() { }

        public CellInfo(string cellText, int row, int column, int pageIndex, Cell realCell)
        {
            this.CellText = cellText;
            this.RowNumber = row;
            this.ColumnNumber = column;
            this.PageIndex = pageIndex;
            this.RealCell = realCell;
        }

        public string CellText { get; set; }

        public int RowNumber { get; set; }

        public int ColumnNumber { get; set; }

        public int PageIndex { get; set; }

        public Cell RealCell { get; set; }
    }
}