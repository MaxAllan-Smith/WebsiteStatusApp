using System.Data.SqlClient;
using Dapper;
using WebsiteStatus.Models;
using System.Data;

namespace WebsiteStatus
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly string _connectionString;
        private readonly IHttpClientFactory _httpClientFactory;

        public Worker(ILogger<Worker> logger, IConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _connectionString = configuration.GetConnectionString("DefaultConnection");
            _httpClientFactory = httpClientFactory;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var httoClient = _httpClientFactory.CreateClient();
                var result = await httoClient.GetAsync("https://www.ms-dev.co.uk");

                var logEntry = new LogEntry
                {
                    TimeStamp = DateTime.Now,
                    StatusCode = (int)result.StatusCode,
                    Message = result.IsSuccessStatusCode ? "The website is up" : "The website is down"
                };

                using (var connection = new SqlConnection(_connectionString))
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("Timestamp", logEntry.TimeStamp);
                    p.Add("StatusCode", logEntry.StatusCode);
                    p.Add("Message", logEntry.Message);

                    await connection.ExecuteAsync("spAddLogEntry", p, commandType: CommandType.StoredProcedure);
                }

                await Task.Delay(5000, stoppingToken);
            }
        }
    }
}
