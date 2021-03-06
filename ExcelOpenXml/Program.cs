﻿using System;
using System.Collections.Generic;

namespace ExcelOpenXml
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileFullName = @"E:\Common_Soft\OpenXmlRead3.xlsx";
            string sheetName = "Sheet1";
            IEnumerable<ExcelDataModel> iel = new List<ExcelDataModel>
            {
                new ExcelDataModel("a1","b2","c3","d4","e5","f6","g7","h8","i9","j10"),
                new ExcelDataModel("a1","b2","c3","d4","e5","f6","g7","h8","i9","j10"),
                new ExcelDataModel("a1","b2","c3","d4","e5","f6","g7","h8","i9","j10"),
                new ExcelDataModel("a2","b2","c3","d4","e5","f6","g7","h8","i9","j10"),
                new ExcelDataModel("a1","b2","c3","d4","e5","f6","g7","h8","i9","j10")
            };
            using (ExcelOpenXmlUtil excelOpenXmlUtil = new ExcelOpenXmlUtil(fileFullName, sheetName))
            {
                excelOpenXmlUtil.ImportExcelDataForTemplate(iel, 1, 0, "", "");
            }

           // var data = ExcelRead.Read<StudentExcelDto>(fileFullName);
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
