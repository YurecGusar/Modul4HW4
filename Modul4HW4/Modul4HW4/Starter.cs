using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul4HW4.Services;

namespace Modul4HW4
{
    public class Starter
    {
        private AppConfigService _config = new AppConfigService();
        public void Run()
        {
            Console.WriteLine(_config.ConnectionString);
        }
    }
}
