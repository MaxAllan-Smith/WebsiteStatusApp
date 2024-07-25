namespace WebsiteStatus
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly string _connectionString;
        private readonly IHttpClientFactory _httpClientFactory;

        public Worker(ILogger<Worker> logger, ConfigurationManager configuration, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _connectionString = configuration.GetConnectionString("DefaultConnection");
            _httpClientFactory = httpClientFactory;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(5000, stoppingToken);
            }
        }
    }
}
