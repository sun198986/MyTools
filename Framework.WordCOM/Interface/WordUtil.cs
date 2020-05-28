﻿/*Microsoft Word 16.0 Object Library
 **/

using Microsoft.Office.Interop.Word;
using Range = Microsoft.Office.Interop.Word.Range;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Framework.WordCOM.Interface
{
    public class WordUtil : IDisposable
    {
        private Application _wordApp;//word用程序
        private Document _currentWord;//当前操作的word
        private bool _disposed;
        private bool _needWrite = false;
        private bool _isSaveAs = false;
        private string _outFilePath = "";

        private object _missing = System.Reflection.Missing.Value;
        private object _objFalse = false;
        private object _objTrue = true;
        private object wdReplaceAll = WdReplace.wdReplaceAll;//替换所有文字
        private object wdReplaceOne = WdReplace.wdReplaceOne;//替换第一个文字

        private Dictionary<string, Document> _fileDic;

        public WordUtil()
        {

        }
        public WordUtil(string fileFullName)
        {
            if (fileFullName.Equals(""))
                _currentWord = CreatWord();
            else
            {
                _currentWord = OpenWord(fileFullName);
            }
            _outFilePath = fileFullName;

            _isSaveAs = false;
            _disposed = false;
            _needWrite = true;
        }

        /// <summary>
        /// 打开现有文件操作
        /// </summary>
        /// <param name="outFileFullName">生成文件路径</param>
        /// <param name="fileFullName">引用文件路径</param>
        /// <param name="isSaveAs">是否另存文件</param>
        public WordUtil(string outFileFullName, string fileFullName = "", bool isSaveAs = true)
        {
            if (outFileFullName.Equals(""))
                throw new Exception("输出文件路径不能为空");
            if (fileFullName.Equals(""))
                _currentWord = CreatWord();
            else
            {
                _currentWord = OpenWord(fileFullName);
            }

            _outFilePath = outFileFullName;
            _isSaveAs = isSaveAs;

            _disposed = false;
            _needWrite = true;
        }


        #region 公共方法


        public int AddPictureToWord(string pictureFullName, string bookmark, float width = 0, float height = 0)
        {
            try
            {
                this.AddShapePicture(pictureFullName, _currentWord, GetBookmarkRank(_currentWord, bookmark), width, height);
            }
            catch (Exception ex)
            {
                _needWrite = false;
                Dispose();
                throw new Exception(string.Format("错误信息:{0}.{1}", ex.StackTrace.ToString(), ex.Message));
            }
            return 1;
        }

        /// <summary>
        /// 获取操作word的页数
        /// </summary>
        /// <returns></returns>
        public int GetDocumnetPageCount()
        {
            return _currentWord.ComputeStatistics(WdStatistic.wdStatisticPages, ref _missing);
        }

        /// <summary>
        /// 复制其他文件的表格到当前word
        /// </summary>
        /// <returns></returns>
        public string CopyTableToWord(string otherFilePath, string bookmark, int tableIndex, bool isCloseTheFile)
        {
            try
            {
                Document otherFile = OpenWord(otherFilePath);
                Range range = GetBookmarkRank(_currentWord, bookmark);
                otherFile.Tables[tableIndex].Range.Copy();
                range.Paste();
                range.Tables[1].AutoFitBehavior(WdAutoFitBehavior.wdAutoFitWindow);
                if (isCloseTheFile)
                    CloseWord(otherFile, otherFilePath);
            }
            catch (Exception ex)
            {
                _needWrite = false;
                Dispose();
                throw new Exception(string.Format("错误信息:{0}.{1}", ex.StackTrace.ToString(), ex.Message));
            }
            return "创建成功";
        }

        /// <summary>
        /// 复制其他文件的文本框到当前word
        /// </summary>
        /// <returns></returns>
        public string CopyImageToWord(string otherFilePath, string bookmark, bool isCloseTheFile)
        {
            try
            {

                Document otherFile = OpenWord(otherFilePath);
                otherFile.Select();

                Range bookmarkPic = GetBookmarkRank(_currentWord, bookmark);

                try
                {
                    ShapeRange shapeRange = otherFile.Shapes.Range(1);
                    InlineShape inlineShape = shapeRange.ConvertToInlineShape();
                    inlineShape.Select();
                    _wordApp.Selection.Copy();
                }
                catch (Exception)
                {
                    Shape shape = otherFile.Shapes[1];
                    Frame inlineShape = shape.ConvertToFrame();
                    inlineShape.Select();
                    _wordApp.Selection.Copy();
                }
                finally
                {
                    bookmarkPic.Paste();
                    if (isCloseTheFile)
                        CloseWord(otherFile, otherFilePath);
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

        /// <summary>
        /// 根据书签向word中插入内容
        /// </summary>
        /// <returns></returns>
        public string InsertContentToWordByBookmark(string content, string bookmark, bool isUnderLine = false)
        {
            try
            {
                Range range = GetBookmarkReturnNull(_currentWord, bookmark);
                if (range == null)
                    return "未找到书签:" + bookmark;
                range.Select();
                range.Text = content;
                if (isUnderLine)
                    range.Underline = WdUnderline.wdUnderlineSingle;
            }
            catch (Exception ex)
            {
                _needWrite = false;
                Dispose();
                throw new Exception(string.Format("错误信息:{0}.{1}", ex.StackTrace.ToString(), ex.Message));
            }
            return "插入成功";
        }

        /// <summary>
        /// 复制其他文件内容到当前文件
        /// </summary>
        /// <returns></returns>
        public string CopyOtherFileContentToWord(string filePth, string bookmark, bool isCloseTheFile = true)
        {
            try
            {
                Document htmldoc = OpenWord(filePth);
                htmldoc.Content.Copy();
                Range range = GetBookmarkRank(_currentWord, bookmark);
                range.Select();
                range.Paste();
                range.Select();
                int tableCount = _wordApp.Selection.Tables.Count;
                if (tableCount > 0)
                {
                    foreach (Table table in _wordApp.Selection.Tables)
                    {
                        table.AutoFitBehavior(WdAutoFitBehavior.wdAutoFitWindow);
                    }
                }

                if (isCloseTheFile)
                    CloseWord(htmldoc, filePth);
            }
            catch (Exception ex)
            {
                _needWrite = false;
                Dispose();
                throw new Exception(string.Format("错误信息:{0}.{1}", ex.StackTrace.ToString(), ex.Message));
            }

            return "保存成功";
        }

        /// <summary>
        /// 复制第二个文件内容到第一个文件
        /// </summary>
        /// <returns></returns>
        public string CopyOtherFileContentToWord(string firstFilePath, string secondFilePath, string bookmark, bool isCloseTheFile = true)
        {
            try
            {
                Document htmldoc = OpenWord(firstFilePath);
                Document secondFile = OpenWord(secondFilePath);
                Range range = GetBookmarkRank(secondFile, bookmark);
                htmldoc.Content.Copy();
                range.Select();
                range.PasteAndFormat(WdRecoveryType.wdPasteDefault);
                range.Select();
                int tableCount = _wordApp.Selection.Tables.Count;
                if (tableCount > 0)
                {
                    foreach (Table table in _wordApp.Selection.Tables)
                    {
                        table.AutoFitBehavior(WdAutoFitBehavior.wdAutoFitWindow);
                    }
                }

                if (isCloseTheFile)
                    CloseWord(htmldoc, firstFilePath);
            }
            catch (Exception ex)
            {
                _needWrite = false;
                Dispose();
                throw new Exception(string.Format("错误信息:{0}.{1}", ex.StackTrace.ToString(), ex.Message));
            }

            return "保存成功";
        }

        /// <summary>
        /// 替换文字
        /// </summary>
        /// <returns></returns>
        public string ReplaceWritten(Dictionary<int, Dictionary<string, string>> replaceDic, int replaceType = 2)
        {
            try
            {
                _currentWord.Content.Select();

                foreach (var item in replaceDic)
                {
                    int type = item.Key;
                    foreach (var itemV in item.Value)
                    {
                        Replace(type, itemV.Key, itemV.Value, replaceType);
                    }
                }
            }
            catch (Exception ex)
            {
                _needWrite = false;
                Dispose();
                throw new Exception(string.Format("错误信息:{0}.{1}", ex.StackTrace.ToString(), ex.Message));
            }

            return "替换成功";
        }

        /// <summary>
        /// word文档中插入excel
        /// </summary>
        /// <param name="excelFileFullName">excel文件</param>
        /// <param name="bookmark">书签名称 excel插入位置书签名称 默认为"" 插入文档末尾</param>
        /// <param name="excelWidht">excel宽</param>
        /// <param name="excelHeight">excel高</param>
        /// <returns>创建结果或错误信息</returns>
        public string InsertExcel(string excelFileFullName, string bookmark, int excelWidht = 450, int excelHeight = 200)
        {
            if (excelFileFullName.Equals(""))
            {
                throw new Exception("excel文件不能为空");
            }
            try
            {
                _currentWord.Select();

                object bk = bookmark;
                Range excelRange = null;

                if (_currentWord.Bookmarks.Exists(bookmark))
                {
                    excelRange = GetBookmarkRank(_currentWord, bookmark);
                }
                else
                {
                    InsertBreakPage(false);
                }

                object fileType = @"Excel.Sheet.12";//插入的excel 格式，HKEY_CLASSES_ROOT，所以是.12  Excel.Chart.8也可以
                object filename = excelFileFullName;//插入的excel的位置
                object linkToFile = true;
                object rangeOLE = excelRange;
                //添加一个OLEObject对象
                InlineShape sp = _wordApp.Selection.InlineShapes.AddOLEObject(ref fileType,
                    ref filename,
                    ref _missing,//真 若要将 OLE 对象链接到创建它的文件
                    ref _missing,//真 图标
                    ref _missing,//图标链接
                    ref _missing,
                    ref _missing,
                    ref rangeOLE);//位置
                sp.Height = excelHeight;//200
                sp.Width = excelWidht;
            }
            catch (Exception ex)
            {
                _needWrite = false;
                Dispose();
                throw new Exception(string.Format("错误信息:{0}.{1}", ex.StackTrace.ToString(), ex.Message));
            }
            return "创建成功";
        }

        /// <summary>
        /// 合并word
        /// </summary>
        /// <returns></returns>
        public int MerageWord(List<string> fileFullNamelist, bool isPage = false)
        {
            try
            {
                _currentWord.Activate();
                for (int i = 0; i < fileFullNamelist.Count; i++)
                {
                    InsertWord(fileFullNamelist[i], isPage ? i > 0 : isPage);
                }
            }
            catch (Exception ex)
            {
                _needWrite = false;
                Dispose();
                throw new Exception(string.Format("错误信息:{0}.{1}", ex.StackTrace.ToString(), ex.Message));
            }

            return fileFullNamelist.Count;
        }

        /// <summary>
        /// 设置复选框选中
        /// </summary>
        /// <returns></returns>
        public string SelecionCheckbox(string bookmark, int controlIndex, bool isCheck = true)
        {
            try
            {
                Range range = GetBookmarkRank(_currentWord, bookmark);
                range.Select();
                range = _wordApp.Selection.Cells[1].Range;
                range.Select();

                int i = 1;

                foreach (InlineShape shape in _wordApp.Selection.InlineShapes)
                {
                    if (shape.Type == WdInlineShapeType.wdInlineShapeOLEControlObject)
                    {
                        object oleControl = shape.OLEFormat.Object;
                        Type oleControlType = oleControl.GetType();
                        //设置复选框选中
                        if (i == controlIndex)
                            oleControlType.InvokeMember("Value", System.Reflection.BindingFlags.SetProperty, null, oleControl, new object[] { isCheck.ToString() });
                        i++;
                    }
                }

                return "设置成功";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 私有方法
        private void NewApp()
        {
            _wordApp = new Application();
        }

        //关闭application
        private void CloseApp()
        {
            object wdSaveOptions = WdSaveOptions.wdDoNotSaveChanges;
            foreach (Document item in _wordApp.Documents)
            {
                item.Close(ref wdSaveOptions, ref _missing, ref _missing);
            }
            _wordApp.Application.Quit(ref _objFalse, ref _missing, ref _missing);
            _wordApp = null;
        }

        //创建一个新的word
        private Document CreatWord()
        {
            if (_wordApp == null)
                NewApp();
            return _wordApp.Documents.Add(ref _missing, ref _missing, ref _missing, ref _objFalse);
        }

        //打开word
        private Document OpenWord(string fileFullPath, bool isOtherFormat = false)
        {
            if (_wordApp == null)
                NewApp();
            Document openWord = null;

            //判断文件是否打开
            if (_fileDic != null && _fileDic.ContainsKey(fileFullPath))
                openWord = _fileDic[fileFullPath];
            else
            {
                if (_fileDic == null)
                {
                    _fileDic = new Dictionary<string, Document>();
                }
                object otherFormat = isOtherFormat ? true : false;//其他格式文件用word打开
                object obj = fileFullPath;
                openWord = _wordApp.Documents.Open(ref obj,
                ref _missing,//文档名（可包含路径）
                ref _missing,//True 显示 转换文件对话框中，如果该文件不是 Microsoft Word 格式
                ref _missing,// 如果该属性值为 True , 则以只读方式打开文档
                ref _missing,//true 要将文件名添加到列表中最近使用的文件在文件菜单的底部
                ref _missing,//打开文档时所需的密码
                ref _missing,//打开模板时所需的密码
                ref _missing,//为 False，则激活打开的文档
                ref _missing,
                ref _missing,
                ref _missing,
                ref _objFalse, //在可见窗口中打开文档。 默认值为 True
                ref _missing,
                ref _missing,
                ref _missing,
                ref _missing);

                _fileDic.Add(fileFullPath, openWord);
            }


            return openWord;
        }

        //关闭word
        private void CloseWord(Document doc, string fileFulleName = "")
        {
            doc.Close(ref _objFalse, ref _missing, ref _missing);
            if (fileFulleName != null)
                _fileDic.Remove(fileFulleName);
        }

        //保存word
        private void SaveWord(Document doc)
        {
            doc.Save();
        }

        //另存word
        private void SaveAsWord(Document doc, string outFileFullName)
        {
            //筛选保存格式
            object defFormat = FilterExtendName(outFileFullName);
            object path = outFileFullName;
            doc.SaveAs(
                ref path,      //FileName
                ref defFormat,     //FileFormat
                ref _missing,     //LockComments
                ref _missing,     //PassWord     
                ref _missing,     //AddToRecentFiles
                ref _missing,     //WritePassword
                ref _missing,     //ReadOnlyRecommended
                ref _missing,     //EmbedTrueTypeFonts
                ref _missing,     //SaveNativePictureFormat
                ref _missing,     //SaveFormsData
                ref _missing,     //SaveAsAOCELetter,
                ref _missing,     //Encoding
                ref _objFalse,     //InsertLineBreaks
                ref _missing,     //AllowSubstitutions
                ref _missing,     //LineEnding
                ref _missing      //AddBiDiMarks
          );
        }

        /// <summary>
        /// 根据文件拓展名获取文件类型
        /// </summary>
        /// <param name="fileFullName"></param>
        /// <returns></returns>
        private object FilterExtendName(string fileFullName)
        {
            int index = fileFullName.LastIndexOf('.');
            string extendName = fileFullName.Substring(index, fileFullName.Length - index);
            object resultFormat = null;
            switch (extendName)
            {
                case ".pdf":
                    resultFormat = WdSaveFormat.wdFormatPDF;
                    break;
                case ".rtf":
                    resultFormat = WdSaveFormat.wdFormatRTF;
                    break;
                case ".xml":
                    resultFormat = WdSaveFormat.wdFormatXMLDocument;
                    break;
                case ".docx":
                default:
                    resultFormat = WdSaveFormat.wdFormatDocumentDefault;
                    break;
            }
            return resultFormat;
        }

        /// <summary>
        /// 获取文件名称
        /// </summary>
        /// <param name="fileFullName"></param>
        /// <returns></returns>
        private string FilterFileName(string fileFullName)
        {
            int index = fileFullName.LastIndexOf('\\');
            return fileFullName.Substring(index, fileFullName.Length - index);
        }


        //在application内插入文件(合并word)
        private void InsertWord(string fileName, bool ifBreakPage = false)
        {
            if (ifBreakPage)
                InsertBreakPage(true);
            _wordApp.Selection.InsertFile(
                        fileName,
                        ref _missing,
                        ref _missing,      //confirmConversion = false;
                        ref _missing,                   //link = false;
                        ref _missing              //attachment = false;
                        );
        }

        /// <summary>
        /// 为当前选中区域添加分页符
        /// </summary>
        /// <param name="isPage"></param>
        private void InsertBreakPage(bool isPage)
        {
            object unite = WdUnits.wdStory;
            _wordApp.Selection.EndKey(ref unite, ref _missing);

            object breakType = WdBreakType.wdSectionBreakContinuous;//分节符
            _wordApp.ActiveWindow.Selection.InsertBreak(breakType);

            if (isPage)
            {
                object breakPage = WdBreakType.wdPageBreak;//分页符
                _wordApp.ActiveWindow.Selection.InsertBreak(breakPage);
            }
        }

        /// <summary>
        /// 当前word插入图片
        /// </summary>
        /// <returns></returns>
        private InlineShape AddPicture(string picFileName, Document doc, Range range, float width = 0, float height = 0)
        {
            range.Select();
            InlineShape image = doc.InlineShapes.AddPicture(picFileName, ref _missing, ref _missing, range);
            if (width != 0 && height != 0)
            {
                image.Width = width;
                image.Height = height;
            }
            return image;
        }

        private Shape AddShapePicture(string picFileName, Document doc, Range range, float width = 0, float height = 0)
        {
            range.Select();
            Shape image = doc.Shapes.AddPicture(picFileName, ref _missing, ref _missing, range);
            if (width != 0 && height != 0)
            {
                image.Width = width;
                image.Height = height;
            }
            return image;
        }

        /// <summary>
        /// 获取书签的位置
        /// </summary>
        /// <param name="word"></param>
        /// <param name="bookmark"></param>
        /// <returns></returns>
        private Range GetBookmarkRank(Document word, string bookmark)
        {
            object bk = bookmark;
            Range bookmarkRank = null;
            if (word.Bookmarks.Exists(bookmark))
                bookmarkRank = word.Bookmarks.get_Item(ref bk).Range;
            else
                throw new Exception(string.Format("未找到书签:{0}", bookmark));

            return bookmarkRank;
        }

        /// <summary>
        /// 获取书签位置,如果不存在返回null
        /// </summary>
        /// <param name="word"></param>
        /// <param name="bookmark"></param>
        /// <returns></returns>
        private Range GetBookmarkReturnNull(Document word, string bookmark)
        {
            object bk = bookmark;
            Range bookmarkRank = null;
            if (word.Bookmarks.Exists(bookmark))
                bookmarkRank = word.Bookmarks.get_Item(ref bk).Range;
            //else
            //    throw new Exception(string.Format("未找到书签:{0}", bookmark));

            return bookmarkRank;
        }

        /// <summary>
        /// word清除域代码格式
        /// </summary>
        /// <returns></returns>
        private int ClearWordCodeFormat()
        {
            _currentWord.Select();
            ClearCode();
            return 1;
        }

        /// <summary>
        /// 域代码转文本
        /// </summary>
        private void ClearCode()
        {
            ShowCodesAndUnlink(_currentWord.Content);
            for (int i = 1; i <= _wordApp.Selection.Sections.Count; i++)
            {
                Section wordSection = _wordApp.Selection.Sections[i];
                Microsoft.Office.Interop.Word.Range footerRange = wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                ShowCodesAndUnlink(footerRange);

                Microsoft.Office.Interop.Word.Range footerRange1 = wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterFirstPage].Range;
                ShowCodesAndUnlink(footerRange1);

                Microsoft.Office.Interop.Word.Range headerRange = wordSection.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                ShowCodesAndUnlink(headerRange);

                Microsoft.Office.Interop.Word.Range headerRange1 = wordSection.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterFirstPage].Range;
                ShowCodesAndUnlink(headerRange1);
            }
        }

        /// <summary>
        /// 将域代码替换为文本域值
        /// </summary>
        /// <param name="range"></param>
        private void ShowCodesAndUnlink(Range range)
        {
            range.Fields.ToggleShowCodes();
            range.Fields.Unlink();
        }

        //全文替换文本 1.文本 2. 页脚 3. 页眉
        private void Replace(int type, string oldWord, string newWord, int replaceType)
        {
            object repalceTypObj = replaceType == 1 ? wdReplaceOne : wdReplaceAll;
            switch (type)
            {
                //1:为文本
                default:
                    _wordApp.Selection.Find.Replacement.ClearFormatting();
                    _wordApp.Selection.Find.ClearFormatting();
                    _wordApp.Selection.Find.Text = oldWord;//需要被替换的文本
                    _wordApp.Selection.Find.Replacement.Text = newWord;//替换文本 
                    try
                    {
                        //执行替换操作
                        _wordApp.Selection.Find.Execute(
                        ref _missing, ref _missing, ref _missing,
                        ref _missing, ref _missing, ref _missing,
                        ref _missing, ref _missing, ref _missing,
                        ref _missing, ref repalceTypObj,// 指定要执行替换的个数：一个、全部或者不替换。 可以是任何WdReplace常量:wdReplaceAll wdReplaceNone wdReplaceOne
                        ref _missing, ref _missing, ref _missing,
                        ref _missing);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    break;
                case 2://页脚
                    try
                    {
                        for (int i = 1; i <= _wordApp.Selection.Sections.Count; i++)
                        {

                            Section wordSection = _wordApp.Selection.Sections[i];

                            Microsoft.Office.Interop.Word.Range footerRange = wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;

                            //footerRange.Fields.ToggleShowCodes();//显示域代码
                            footerRange.Find.ClearFormatting();
                            footerRange.Find.Replacement.ClearFormatting();
                            footerRange.Find.Text = oldWord;
                            footerRange.Find.Replacement.Text = newWord;
                            footerRange.Find.Execute(ref _missing, ref _missing, ref _missing,
                                                   ref _missing, ref _missing, ref _missing,
                                                   ref _missing, ref _missing, ref _missing,
                                                   ref _missing, ref repalceTypObj, ref _missing,
                                                   ref _missing, ref _missing, ref _missing);
                            // footerRange.Fields.Update();//更新域代码


                            Microsoft.Office.Interop.Word.Range footerRange1 = wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterFirstPage].Range;
                            // footerRange1.Fields.ToggleShowCodes();//显示域代码
                            footerRange1.Find.ClearFormatting();
                            footerRange1.Find.Replacement.ClearFormatting();
                            footerRange1.Find.Text = oldWord;
                            footerRange1.Find.Replacement.Text = newWord;
                            footerRange1.Find.Execute(ref _missing, ref _missing, ref _missing,
                                                   ref _missing, ref _missing, ref _missing,
                                                   ref _missing, ref _missing, ref _missing,
                                                   ref _missing, ref repalceTypObj, ref _missing,
                                                   ref _missing, ref _missing, ref _missing);
                            //footerRange1.Fields.Update();//更新域代码
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                    break;
                case 3://页眉
                    try
                    {
                        for (int i = 1; i <= _wordApp.Selection.Sections.Count; i++)
                        {
                            Section wordSection = _wordApp.Selection.Sections[i];
                            Microsoft.Office.Interop.Word.Range headerRange = wordSection.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;

                            //headerRange.Fields.ToggleShowCodes();
                            headerRange.Find.ClearFormatting();
                            headerRange.Find.Replacement.ClearFormatting();
                            headerRange.Find.Text = oldWord;
                            headerRange.Find.Replacement.Text = newWord;
                            headerRange.Find.Execute(ref _missing, ref _missing, ref _missing,
                                                   ref _missing, ref _missing, ref _missing,
                                                   ref _missing, ref _missing, ref _missing,
                                                   ref _missing, ref repalceTypObj, ref _missing,
                                                   ref _missing, ref _missing, ref _missing);
                            //headerRange.Fields.Update();

                            Microsoft.Office.Interop.Word.Range headerRange1 = wordSection.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterFirstPage].Range;
                            //footerRange1.Fields.ToggleShowCodes();//显示域代码
                            headerRange1.Find.ClearFormatting();
                            headerRange1.Find.Replacement.ClearFormatting();
                            headerRange1.Find.Text = oldWord;
                            headerRange1.Find.Replacement.Text = newWord;
                            headerRange1.Find.Execute(ref _missing, ref _missing, ref _missing,
                                                   ref _missing, ref _missing, ref _missing,
                                                   ref _missing, ref _missing, ref _missing,
                                                   ref _missing, ref repalceTypObj, ref _missing,
                                                   ref _missing, ref _missing, ref _missing);
                            //footerRange1.Fields.Update();//更新域代码
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                    break;

            }
        }

        /// <summary>
        /// table合并单元格
        /// </summary>
        /// <param name="table">表格</param>
        /// <param name="startRow">首单元格的行</param>
        /// <param name="startColumn">首单元格的列</param>
        /// <param name="endRow">尾单元格的行</param>
        /// <param name="endColumn">尾单元格的列</param>
        private void MergeCell(Table table, int startRow, int startColumn, int endRow, int endColumn)
        {
            MergeCell(table.Cell(startRow, startColumn), table.Cell(endRow, endColumn));
        }

        /// <summary>
        /// 重写table合并单元格
        /// </summary>
        /// <param name="startCell">首单元格</param>
        /// <param name="endCell">尾单元格</param>
        private void MergeCell(Cell startCell, Cell endCell)
        {
            startCell.Merge(endCell);
        }

        /// <summary>
        /// 当前选中文字加粗居左
        /// </summary>
        private void FontBoldLeft()
        {
            _wordApp.Selection.Font.Bold = (int)WdConstants.wdToggle;
            _wordApp.Selection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
        }


        /// <summary>
        /// 设置表格添加边框
        /// </summary>
        /// <param name="table"></param>
        private void SetTabelFormat(Table table)
        {
            table.Select();
            table.Borders.Enable = (int)WdLineStyle.wdLineStyleSingle;
        }

        /// <summary>
        /// 为table添加序号
        /// </summary>
        /// <param name="table">表格</param>
        /// <param name="columnNumber">添加序号的列</param>
        /// <param name="isTitle">是否有表头</param>
        private void AddTableNumber(Table table, int columnNumber, bool isTitle = true)
        {
            table.Select();
            table.Cell(1, columnNumber).Select();
            _wordApp.Selection.SelectColumn();
            int intCell = 0;
            foreach (Cell item in _wordApp.Selection.Cells)
            {
                if (isTitle && intCell == 0)
                {
                    intCell++;
                    continue;
                }

                if (!isTitle)
                {
                    intCell++;
                }

                item.Range.Text = (intCell).ToString();
                intCell++;
            }
        }


        /// <summary>
        /// 创建并移动到下一个段落
        /// </summary>
        private void CreateAndGoToNextParagraph(Range range, bool isCreateParagraph, bool isMove)
        {
            range.Select();
            if (isCreateParagraph)
            {
                object unite = WdUnits.wdLine;
                _wordApp.Selection.EndKey(ref unite, ref _missing);
                _wordApp.Selection.TypeParagraph();
            }
            if (isMove)
            {
                object move = 1;
                range.Move(WdUnits.wdParagraph, ref move);
            }
        }
        /// <summary>
        /// 插入段落
        /// </summary>
        /// <param name="range"></param>
        private void InsertParagraph(Range range)
        {
            object contLine = 1;
            object WdLine = WdUnits.wdLine;//换一行;
            range.Document.ActiveWindow.Selection.MoveDown(ref WdLine, ref contLine, ref _missing);//移动焦点
            range.Document.ActiveWindow.Selection.TypeParagraph();//插入段落
        }

        /// <summary>
        /// 设置table格式
        /// </summary>
        /// <param name="table"></param>
        private void ClearFormatTable(Table table)
        {
            table.Select();
            if (table.Rows.Count > 0)
            {
                table.AutoFitBehavior(WdAutoFitBehavior.wdAutoFitWindow);
                _wordApp.Selection.ClearFormatting();
                _wordApp.Options.DefaultHighlightColorIndex = WdColorIndex.wdNoHighlight;
                _wordApp.Selection.Range.HighlightColorIndex = WdColorIndex.wdNoHighlight;
                _wordApp.Selection.Shading.Texture = WdTextureIndex.wdTextureNone;
                _wordApp.Selection.Shading.ForegroundPatternColor = WdColor.wdColorAutomatic;
                _wordApp.Selection.Shading.BackgroundPatternColor = WdColor.wdColorAutomatic;
                table.Select();
                _wordApp.Selection.SelectCell();
                _wordApp.Selection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                _wordApp.Selection.Cells.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                //table.Range.Application.Selection.Cells.DistributeHeight();
                //table.Range.Application.Selection.Cells.DistributeWidth();

                SetDistributeTable(table);
            }

        }
        /// <summary>
        /// 设置table除表头之外的单元格等高
        /// </summary>
        /// <param name="table"></param>
        private void SetDistributeTable(Table table)
        {
            int tableRows = table.Rows.Count;
            if (tableRows >= 2)
            {
                int tableColumns = table.Columns.Count;
                object extend = WdMovementType.wdExtend;//选中拓展格式

                table.Cell(2, 1).Select();
                int t1 = table.Cell(2, 1).Range.Application.Selection.MoveDown(WdUnits.wdLine, tableRows - 2, ref extend);
                _wordApp.Selection.Cells.DistributeHeight();
            }

        }

        /// <summary>
        /// 根据windows大小设置表格大小
        /// </summary>
        /// <param name="table"></param>
        private void SetAutoFitContentForTable(Table table)
        {
            table.Select();
            _wordApp.Selection.Tables[1].AutoFitBehavior(WdAutoFitBehavior.wdAutoFitContent);
            _wordApp.Selection.Tables[1].AutoFitBehavior(WdAutoFitBehavior.wdAutoFitWindow);
        }

        /// <summary>
        /// 根据文件名称结束word进程
        /// </summary>
        /// <param name="fileName">word文件名称</param>
        public void KillWordProcess(string fileName)
        {
            Process myProcess = new Process();
            Process[] wordProcess = Process.GetProcessesByName("winword");
            foreach (Process pro in wordProcess) //这里是找到那些没有界面的Word进程
            {
                //IntPtr ip = pro.MainWindowHandle;

                string str = pro.MainWindowTitle; //发现程序中打开跟用户自己打开的区别就在这个属性
                                                  //用户打开的str 是文件的名称，程序中打开的就是空字符串
                if (str == fileName)
                {
                    pro.Kill();
                }
            }
        }

        /// <summary>
        /// 删除word进程
        /// </summary>
        public void KillWordProcess()
        {
            Process myProcess = new Process();
            Process[] wordProcess = Process.GetProcessesByName("winword");
            foreach (Process pro in wordProcess) //这里是找到那些没有界面的Word进程
            {
                pro.Kill();
            }
        }

        #endregion

        #region 资源回收
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_needWrite)
                    {
                        if (!_outFilePath.Equals("") && _isSaveAs)
                        {
                            SaveAsWord(_currentWord, _outFilePath);
                        }
                        else if (!_isSaveAs)
                        {
                            SaveWord(_currentWord);
                        }
                        _currentWord = null;
                    }

                    if (_wordApp != null)
                        CloseApp();

                    if (_fileDic != null)
                        _fileDic = null;
                }
                _disposed = true;
            }
        }
        #endregion
    }
}
