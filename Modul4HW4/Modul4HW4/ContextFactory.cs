using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Modul4HW4.DataAccess;
using Modul4HW4.Services;

namespace Modul4HW4
{
    public class ContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            var config = new AppConfigService();
            var dbContext = new DbContextOptionsBuilder<ApplicationContext>();
            dbContext.UseSqlServer(config.ConnectionString);

            return new ApplicationContext(dbContext.Options);
        }
    }
}
