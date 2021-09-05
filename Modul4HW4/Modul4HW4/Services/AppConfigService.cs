using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Modul4HW4.Configs;

namespace Modul4HW4.Services
{
    public class AppConfigService
    {
        public AppConfigService()
        {
            var config = GetConfig();
            ConnectionString = config.ConnectionString;
        }

        public string ConnectionString { get; }

        private AppConfig GetConfig()
        {
            var json = File.ReadAllText("config.json");
            var config = JsonConvert.DeserializeObject<AppConfig>(json);
            return config;
        }
    }
}
