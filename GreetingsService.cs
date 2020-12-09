using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ConsoleApplicationBoilerplate
{
    public class GreetingsService : IGreetingsService
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<GreetingsService> _logger;

        public GreetingsService(IConfiguration configuration, ILogger<GreetingsService> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public void Run()
        {
            var runTimesFromConfigFile = _configuration.GetValue<int>("LoopTimes");

            for (int i = 0; i < runTimesFromConfigFile; i++)
            {
                _logger.LogInformation("Run number {runNumber}", i);
            }
        }
    }
}
