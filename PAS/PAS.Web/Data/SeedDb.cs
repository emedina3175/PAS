
namespace PAS.Web.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Entities;

    public class SeedDb
    {

        private readonly DataContext context;
        private Random random;

        public SeedDb(DataContext context)
        {
            this.context = context;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();
            if (!this.context.Companies.Any())
            {
                Company c = new Company() {
                    IdentificationNumber = "00109066225",
                    Name = "Edward Medina Guerrero",
                    BusinessName = "EdSoft S.R.L.",
                    ImageUrl =  "",
                    FoundationDate = DateTime.Now,
                    OfficeNumber = "8492070176",
                    FaxNumber ="8092070176",
                    EmailAddress = "emedina3175@gmail.com",
                    Description = "Dedicada al software",
                    IsEnabled = true
                };
                AddCompany(c);
                await this.context.SaveChangesAsync();
            }
        }

        private void AddCompany(Company company)
        {
            this.context.Companies.Add(company);

        }

    }
}
