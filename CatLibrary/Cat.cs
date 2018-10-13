using Microsoft.Extensions.Logging;

namespace CatLibrary
{
    public class Cat : ICat
    {
        private readonly ILogger<ICat> _logger;

        public Cat(ILogger<ICat> logger)
        {
            _logger = logger;
        }

        public string MakeSound()
        {
            _logger.LogInformation("MakeSound() Start.");
            return "Meow!";
        }
    }
}
