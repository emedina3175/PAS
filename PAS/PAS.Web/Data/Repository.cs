
namespace PAS.Web.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Entities;

    public class Repository : IRepository
    {
        private readonly DataContext context;

        public Repository(DataContext context)
        {
            this.context = context;
        }

        public IEnumerable<Company> GetCompanies()
        {
            return context.Companies.OrderBy(p => p.Name);
        }

        public Company GetCompany(int companyid)
        {
            return context.Companies.Find(companyid);
        }

        public void AddCompany(Company company)
        {
            context.Companies.Add(company);
        }

        public void UpdateCompany(Company company)
        {
            context.Companies.Update(company);
        }

        public void RemoveCompany(Company company)
        {
            context.Companies.Remove(company);
        }

        public async Task<bool> SaveAllAsync()
        {
            return await context.SaveChangesAsync() > 0;
        }

        public bool CompanyExists(int companyid)
        {
            return context.Companies.Any(c => c.CompanyId == companyid);
        }

    }
}
