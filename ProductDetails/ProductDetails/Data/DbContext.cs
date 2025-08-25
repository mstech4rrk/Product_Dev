using Microsoft.AspNetCore.SignalR;
using ProductDetails.Interfaces;
using Microsoft.Extensions.Configuration;

namespace ProductDetails.Data
{
    public class DbContext: IDbContext
    {
        private readonly IConfiguration _configuration;
        public DbContext(IConfiguration configuration)
        {
            _configuration = configuration;
            GetConfigValues();
        }
        public string DatabaseName { get; set; } 
        public string ServerName { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string GetConnectionString()
        {
            return $"Server={ServerName};Database={DatabaseName};User Id={UserId};Password={Password};";
        }

        private void GetConfigValues()
        {
            ServerName = _configuration["DatabaseSettings:ServerName"];
            DatabaseName = _configuration["DatabaseSettings:DatabaseName"];
            UserId = _configuration["DatabaseSettings:UserId"];
            Password = _configuration["DatabaseSettings:Password"];
        }   

    }
}
