
namespace PAS.Web.Data
{
    using Microsoft.EntityFrameworkCore;
    using PAS.Web.Data.Entities;
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Company> Companies { get; set; }

    }
}
