using EFCore.DB2.Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.DB2.Demo.Services
{
    public interface ICompanyRepository
    {

        Task<IEnumerable<CompanyExtend>> GetCompanyExtends();

        Task Add(Company company);

        Task AddEmployee(Employee employee);

        Task AddPoint(Point point);

        Task AddCompanyDoc(CompanyDoc companyDoc);
    }
}
