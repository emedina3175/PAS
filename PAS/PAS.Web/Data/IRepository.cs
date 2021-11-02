
namespace PAS.Web.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Entities;

    public interface IRepository
    {
        void AddCompany(Company company);

        bool CompanyExists(int companyid);

        IEnumerable<Company> GetCompanies();

        Company GetCompany(int companyid);

        void RemoveCompany(Company company);

        Task<bool> SaveAllAsync();

        void UpdateCompany(Company company);
    }
}