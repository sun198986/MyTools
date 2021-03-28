using EFCore.DB2.Demo.EFCore;
using EFCore.DB2.Demo.Entities;
using IBM.Data.DB2.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.DB2.Demo.Services
{
    public class CompanyRepository:ICompanyRepository
    {
        private readonly IBMDBContext _dbContext;
        public CompanyRepository(IBMDBContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task Add(Company company) {
            company.Id = Guid.NewGuid().ToString();
            company.CreateDate = DateTime.Now;
            company.Creator = "sun";

            _dbContext.ChangeTracker.AutoDetectChangesEnabled = false;
            await _dbContext.Companies.AddAsync(company);
            _dbContext.ChangeTracker.Entries();
            _dbContext.SaveChanges();
        }
    }
}
