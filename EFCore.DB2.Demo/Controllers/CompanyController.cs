using EFCore.DB2.Demo.Entities;
using EFCore.DB2.Demo.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.DB2.Demo.Controllers
{
    [ApiController]
    [Route("api/company")]
    public class CompanyController:ControllerBase
    {
        private readonly ICompanyRepository _companyRepository;
        public CompanyController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }
        /// <summary>
        /// get
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Index() {

            return BadRequest();
        }

        [HttpPost]
        public async void Add(Company company) {
            await _companyRepository.Add(company);
        }
    }
}
;