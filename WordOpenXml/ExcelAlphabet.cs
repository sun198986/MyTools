using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Text;

namespace YCBX.Office.ExcelXml
{
    /// <summary>
    /// Excel字母码帮助（26进制转换）
    /// </summary>
    public class ExcelAlphabet
    {
        //备注 A 对应char为65，Z 对应char为90

        /// <summary>
        /// 26个字母
        /// </summary>
        public static uint AlphabetCount = 26;

        /// <summary>
        /// 数字转字符
        /// </summary>
        /// <param name="iNumber"></param>
        /// <returns></returns>
        public static string ColumnToABC(int iNumber)
        {
            if (iNumber < 1 || iNumber > 702)
                throw new Exception("转为26进制可用10进制范围为1-702");

            string sLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int iUnits = 26;
            int iDivisor = (int)(iNumber / iUnits);
            int iResidue = iNumber % iUnits;
            if (iDivisor == 1 && iResidue == 0)
            {
                iDivisor = 0;
                iResidue = iResidue + iUnits;
            }
            else
            {
                if (iResidue == 0)
                {
                    iDivisor -= 1;
                    iResidue += iUnits;
                }
            }
            if (iDivisor == 0)
            {
                return sLetters.Substring(iResidue - 1, 1);
            }
            else
            {
                return sLetters.Substring(iDivisor - 1, 1) + sLetters.Substring(iResidue - 1, 1);
            }
        }

        /// <summary>
        /// 字符转数字
        /// </summary>
        /// <param name="sString"></param>
        /// <returns></returns>
        public static int ABCToColumn(string sString)
        {
            if (string.Compare(sString, "A") == -1 || string.Compare(sString, "ZZ") == 1)
                return 0;

            string sLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int iUnits = 26;
            int sFirst = -1;
            int sSecond = 0;
            if (sString.Length == 1)
            {
                sSecond = sLetters.IndexOf(sString);
            }
            else
            {
                sFirst = sLetters.IndexOf(sString.Substring(0, 1));
                sSecond = sLetters.IndexOf(sString.Substring(1, 1));
            }
            return (sFirst + 1) * iUnits + (sSecond + 1);
        }
    }
}