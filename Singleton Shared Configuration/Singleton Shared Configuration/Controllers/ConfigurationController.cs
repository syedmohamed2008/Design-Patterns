using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Singleton_Shared_Configuration.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConfigurationController : ControllerBase
    {
        private readonly ApplicationSettings _settings;

        public ConfigurationController(ApplicationSettings settings)
        {
            _settings = settings;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                _settings.ApplicationName,
                _settings.SupportEmail,
                _settings.MaxUploadSizeMB,
                _settings.MaintenanceMode
            });
        }
    }
}
