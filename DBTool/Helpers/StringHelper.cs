using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DBTool.Helpers
{
    public class StringHelper
    {
        char charSplit = '_';

        /// <summary>
        /// 跳过的字符串
        /// </summary>
        private List<string> listPass = new List<string>();

        public string TurnStr(string strConvert) {
            string strRes = PieceString(strConvert);
            return strRes;
        }

        /// <summary>
        /// 小写转换为驼峰
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private string ConvertString(string tb1)
        {
            Match mt = Regex.Match(tb1, @"_(\w*)*");
            while (mt.Success)
            {
                var item = mt.Value;
                if (!string.IsNullOrWhiteSpace(item))
                {
                    if (listPass.Contains(item.ToLower()))
                    {
                        continue;
                    }
                }
                while (item.IndexOf('_') >= 0)
                {
                    string newUpper = item.Substring(item.IndexOf(charSplit), 2);
                    item = item.Replace(newUpper, newUpper.Trim(charSplit).ToUpper());
                    tb1 = tb1.Replace(newUpper, newUpper.Trim(charSplit).ToUpper());
                }
                mt = mt.NextMatch();
            }

            return tb1;
        }

        /// <summary>
        /// 字符拼装
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string PieceString(string str)
        {
            StringBuilder strRes = new StringBuilder();
            if (!string.IsNullOrWhiteSpace(str))
            {
                List<string> strList = str.Split(charSplit).ToList();
                foreach (var item in strList)
                {
                    if (listPass.Contains(item))
                    {
                        strRes.Append(item);
                    }
                    else
                    {
                        strRes.Append(ConvertString(charSplit + item.ToLower()));
                    }
                }
            }
            return strRes.ToString();
        }
    }
}
