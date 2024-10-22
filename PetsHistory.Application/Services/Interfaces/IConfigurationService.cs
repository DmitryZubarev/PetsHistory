using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsHistory.Application.Services.Interfaces
{
    public interface IConfigurationService
    {
        private const string ROOT = "Configuration";
        IEnumerable<KeyValuePair<string, string>> GetConfiguration(string section = ROOT);
    }
}
