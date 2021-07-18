using DBTool.DB;
using DBTool.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DBTool.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDBContext _context;
        public HomeController(ILogger<HomeController> logger, IDBContext dBContext)
        {
            _logger = logger;
            _context = dBContext;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _context.QueryAsync<SyscatTable>("select TABSCHEMA,TABNAME from syscat.tables where TABSCHEMA='DB2ADMIN';");
            ViewBag.TempList = list;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
