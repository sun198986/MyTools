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

        public async Task<IEnumerable<CompanyExtend>> GetCompanyExtends()
        {
            //var list = from com in _dbContext.Companies.Include(p=>p.Employees).ThenInclude(p=>p.Points)
            //            select new CompanyExtend
            //            {
            //                CompanyName = com.Name,
            //                EmployeeNames = string.Join(',', com.Employees.Select(p => p.FirstName)),
            //                Points =string.Join(',', com.Employees.SelectMany(x => x.Points, (a, b) => b.HeightPoint.ToString()))
            //            };
            var list = from com in _dbContext.CompanyDocs.AsNoTracking()
                       select new CompanyExtend
                       {
                           CompanyName = com.Content,
                           EmployeeNames = string.Join(',',com.Company.Employees.Select(p=>p.FirstName))

                       };


            var result = await list.ToListAsync();
            return result;
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

        public async Task AddEmployee(Employee employee)
        {
            employee.Id = Guid.NewGuid().ToString();
            employee.CreateDate = DateTime.Now;
            employee.Creator = "sun";

            _dbContext.ChangeTracker.AutoDetectChangesEnabled = false;
            await _dbContext.Employees.AddAsync(employee);
            _dbContext.ChangeTracker.AutoDetectChangesEnabled = true;
            _dbContext.ChangeTracker.Entries();
            _dbContext.SaveChanges();
        }

        public async Task AddPoint(Point point)
        {
            point.Id = Guid.NewGuid().ToString();

            _dbContext.ChangeTracker.AutoDetectChangesEnabled = false;
            await _dbContext.Points.AddAsync(point);
            _dbContext.ChangeTracker.AutoDetectChangesEnabled = true;
            _dbContext.ChangeTracker.Entries();
            _dbContext.SaveChanges();
        }

        public async Task AddCompanyDoc(CompanyDoc companyDoc)
        {
            companyDoc.Id = Guid.NewGuid().ToString();

            _dbContext.ChangeTracker.AutoDetectChangesEnabled = false;
            await _dbContext.CompanyDocs.AddAsync(companyDoc);
            _dbContext.ChangeTracker.AutoDetectChangesEnabled = true;
            _dbContext.ChangeTracker.Entries();
            _dbContext.SaveChanges();
        }
    }
}
