/***
 * https://docs.microsoft.com/zh-cn/dotnet/api/documentformat.openxml.wordprocessing?view=openxml-2.8.1
 * */
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace WordOpenXml
{
    class Program
    {
        static void Main(string[] args)
        {
            //string filepath = $"{AppDomain.CurrentDomain.BaseDirectory}\\Demo\\demo.docx";
            //WordXml.CreateWordDoc(filepath, "你好");
            //ExcelXml.ImportExcelData();
            //ExcelXml.ExportExcelData<ExcelDataModel>();
            //Console.WriteLine("Hello World!");


            string docName = @"D:\Document\OpenXml.xlsx";
            string sheetName = "Sheet1";

            IEnumerable<ExcelDataModel> iel = new List<ExcelDataModel>
            {
                new ExcelDataModel("a1","b2","c3","d4","e5","f6","g7","h8","i9","j10"),
                new ExcelDataModel("a1","b2","c3","d4","e5","f6","g7","h8","i9","j10"),
                new ExcelDataModel("a1","b2","c3","d4","e5","f6","g7","h8","i9","j10"),
                new ExcelDataModel("a1","b2","c3","d4","e5","f6","g7","h8","i9","j10"),
                new ExcelDataModel("a1","b2","c3","d4","e5","f6","g7","h8","i9","j10")
            };

            ExcelXml.ImportExcelDataForTemplate(docName, sheetName,iel);
            //ExcelXml.ImportExcelData(docName, iel);

            //string docName = @"D:\Document\OpenXml.xlsx";
            //string sheetName = "Sheet1";
            //string cell1Name = "A2";
            //string cell2Name = "B2";
            //ExcelXml.MergeCells(docName, sheetName, cell1Name, cell2Name);

            Console.WriteLine("成功");
            Console.ReadLine();
        }
    }
}
