using System;
using System.Collections.Generic;
using System.Text;

namespace ExcelOpenXml
{
    /// <summary>
    /// Excel列特性
    /// </summary>
    public class ExcelColumnAttribute : Attribute
    //: DescriptionAttribute
    {
        /// <summary>
        /// 建议列名
        /// </summary>
        public virtual string ColumnName { get; }

        /// <summary>
        /// 是否显示列
        /// </summary>
        public virtual bool IsShow { get; }

        /// <summary>
        /// 初始化Excel列名的特性
        /// </summary>
        /// <param name="isShow">是否显示列（在类上为false时不解析默认第一行，在属性上为false时不显示属性的值）</param>
        public ExcelColumnAttribute(bool isShow = true)
        {
            IsShow = isShow;
        }

        /// <summary>
        /// 初始化Excel列名的特性
        /// </summary>
        /// <param name="description">建议列名（在属性上为Excel中的第一行的头值）</param>
        /// <param name="isShow">是否显示列（在类上为false时不解析默认第一行，在属性上为false时不显示属性的值）</param>
        public ExcelColumnAttribute(string description, bool isShow = true)
        {
            ColumnName = description;
            IsShow = isShow;
        }

    }
}
