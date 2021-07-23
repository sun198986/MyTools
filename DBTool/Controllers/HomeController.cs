using DBTool.DB;
using DBTool.Helpers;
using DBTool.Models;
using DBTool.ViewModels;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DBTool.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDBContext _context;
        private readonly StringHelper _stringHelper;
        public HomeController(ILogger<HomeController> logger, IDBContext dBContext, StringHelper stringHelper)
        {
            _logger = logger;
            _context = dBContext;
            _stringHelper= stringHelper; 
        }

        public async Task<IActionResult> Index(SyscatTable syscatTable)
        {
            var list = await _context.QueryAsync<SyscatTable>("select TABSCHEMA,TABNAME from syscat.tables where TABSCHEMA='DB2ADMIN';");
            if (syscatTable.TabName != null)
            {
                ViewBag.TabSchema = syscatTable.TabSchema;
                ViewBag.TabName = syscatTable.TabName;
                list = await _context.QueryAsync<SyscatTable>($"select TABSCHEMA,TABNAME from syscat.tables where TABSCHEMA='{syscatTable.TabSchema}' and TABNAME='{syscatTable.TabName}';");
            }
            ViewBag.TempList = list;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="syscatTable"></param>
        /// <returns></returns>
        public async Task<IActionResult> ItemView(SyscatTable syscatTable)
        {
            var list = await _context.QueryAsync<SyscatColumn>($"select TABSCHEMA,TABNAME,COLNAME,TYPENAME,LENGTH from syscat.COLUMNS where TABSCHEMA='{syscatTable.TabSchema}' and TABNAME='{syscatTable.TabName}' order by COLNO;");
            ViewBag.ColList = list;
            return View(syscatTable);
        }

        public async Task<IActionResult> Modify(TabViewModel tabView)
        {
            var list = await _context.QueryAsync<SyscatColumn>($"select TABSCHEMA,TABNAME,COLNAME,TYPENAME,LENGTH from syscat.COLUMNS where TABSCHEMA='{tabView.SyscatTable.TabSchema}' and TABNAME='{tabView.SyscatTable.TabName}' order by COLNO;");

            var path = System.AppDomain.CurrentDomain.BaseDirectory + @"\ModelFiles";
            string cusnamespace = tabView.NameSapce ?? "DBTool.Models";
            string className = tabView.ClassName ?? _stringHelper.TurnStr(tabView.SyscatTable.TabName);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filename = $"{className}.cs";
            string filePath = Path.Combine(path,filename);
            FileStream fsFile=System.IO.File.Create(filePath);
            fsFile.Close();

            System.IO.File.AppendAllText(filePath, $"using System;\n");
            System.IO.File.AppendAllText(filePath, "\n");
            System.IO.File.AppendAllText(filePath, $"namespace {cusnamespace}\n");
            System.IO.File.AppendAllText(filePath, "{\n");
            System.IO.File.AppendAllText(filePath, $"\tpublic class {className}\n");
            System.IO.File.AppendAllText(filePath, "\t{\n");
            foreach (var item in list)
            {
                var typeName = string.Empty;
                switch(item.TypeName)
                {
                    case "DATE":
                    case "TIME":
                    case "TIMESTAMP":
                        typeName = "DateTime";
                        break;
                    case "DECIMAL":
                        typeName = "decimal";
                        break;
                    case "INT":
                    case "INTEGER":
                        typeName = "int";
                        break;
                    case "BIGINT":
                        typeName = "long";
                        break;
                    default:
                        typeName = "string";
                        break;
                }
                System.IO.File.AppendAllText(filePath, $"\t\tpublic {typeName} {_stringHelper.TurnStr(item.ColName)} {{ get; set; }}\n");
                System.IO.File.AppendAllText(filePath, "\n");
            }
            System.IO.File.AppendAllText(filePath, "\t}\n");
            System.IO.File.AppendAllText(filePath, "}\n");

            //下载
            //服务器地址
            //var serverFilePath = $@"{AppContext.BaseDirectory}ModelFiles\{fileName}";
            //using (FileStream fs = new FileStream(serverFilePath, FileMode.Open))
            //{
            //    byte[] bytes = new byte[(int)fs.Length];
            //    fs.Read(bytes, 0, bytes.Length);
            //    fs.Close();
            //    //Response.ContentEncoding = System.Text.Encoding.GetEncoding("UTF-8");
            //    Response.ContentType = "application/octet-stream;charset=UTF-8"; ;
            //    Response.Headers.Add("Content-Disposition", "attachment; filename=" + fileName);
            //    _ = Response.BodyWriter.WriteAsync(bytes);
            //    _ = Response.BodyWriter.FlushAsync();
            //}
            var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite);
            return File(fileStream, "application/octet-stream", filename);
           // return Redirect("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
