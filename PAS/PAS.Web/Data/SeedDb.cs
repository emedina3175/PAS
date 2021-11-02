
namespace PAS.Web.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;
    using Entities;

    public class SeedDb
    {

        private readonly DataContext context;
        public readonly UserManager<User> UserManager;
        private Random random;

        public SeedDb(DataContext context, UserManager<User> userManager)
        {
            this.context = context;
            this.UserManager = userManager;
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

                var company = context.Companies.Where(c => c.EmailAddress == "emedina3175@gmail.com").FirstOrDefault();

                var user = await this.UserManager.FindByEmailAsync("emedina3175@gmail.com");
                if(user == null)
                {
                    user = new User
                    {
                        IdentificationNumber = "00109066225",
                        FirstName = "Edward",
                        LastName = "Medina Guerrero",
                        Email = "emedina3175@gmail.com",
                        UserName = "emedina3175@gmail.com",
                        Company = company,
                        PhoneNumber = "8093739111"

                    };

                    var result = await this.UserManager.CreateAsync(user, "123456");
                    if (result != IdentityResult.Success)
                    {
                        throw new InvalidOperationException("Could not create the user in seeder");
                    }

                }
            }
        }

        private void AddCompany(Company company)
        {
            this.context.Companies.Add(company);

        }

    }
}
