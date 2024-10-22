using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using PetsHistory.Application.Services.Interfaces;
using System;

namespace PetsHistory.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ConfigurationController : ControllerBase
    {
        private readonly IConfigurationService _configurationService;

        public ConfigurationController(IConfigurationService configurationService)
        {
            _configurationService = configurationService;
        }

        [HttpGet]
        public IActionResult GetConfiguration()
        {
            return Ok(_configurationService.GetConfiguration());
        }

        [HttpGet]
        public IActionResult GetConfigurationOwner()
        {
            var allConfiguration = _configurationService.GetConfiguration();
            var owner = allConfiguration.Where(kvp => kvp.Key == "Configuration:Owner").First().Value;
            return Ok(owner);
        }

        [HttpGet]
        public IActionResult GetSmth()
        {
            
            return Ok();
        }
    }
}
