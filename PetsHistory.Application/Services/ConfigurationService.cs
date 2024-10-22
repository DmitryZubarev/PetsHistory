using Microsoft.Extensions.Configuration;
using PetsHistory.Application.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsHistory.Application.Services
{
    public class ConfigurationService : IConfigurationService
    {
        private const string ROOT = "Configuration";
        private IConfiguration _configuration;
        public ConfigurationService(IConfiguration configuration) 
        {
            _configuration = configuration;
        }

        public IEnumerable<KeyValuePair<string, string>> GetConfiguration(string section = ROOT)
        {
            var result = _configuration.AsEnumerable();
            return result;
        }
    }
}
