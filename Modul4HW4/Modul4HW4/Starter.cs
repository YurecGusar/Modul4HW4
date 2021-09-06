using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Modul4HW4.DataAccess;
using Modul4HW4.Services;

namespace Modul4HW4
{
    public class Starter
    {
        private AppConfigService _config = new AppConfigService();
        public void Run()
        {
            var options = new DbContextOptionsBuilder<ApplicationContext>();
            options.UseSqlServer(_config.ConnectionString);

            using (var db = new ApplicationContext(options.Options))
            {
            }
        }
    }
}
