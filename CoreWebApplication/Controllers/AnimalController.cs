using CatLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CoreWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private readonly ICat _cat;
        private readonly ILogger<AnimalController> _logger;

        public AnimalController(ICat cat, ILogger<AnimalController> logger)
        {
            _cat = cat;
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            _logger.LogInformation("Get is called on AnimalController");
            return _cat.MakeSound();            
        }
    }
}
