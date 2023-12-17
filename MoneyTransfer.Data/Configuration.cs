
using Microsoft.Extensions.Configuration;

namespace MoneyTransfer.Data
{
    static class Configuration
    {
        public static string SQLConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../MoneyTransfer.WebApi"));
                configurationManager.AddJsonFile("appsettings.json");

                return configurationManager.GetConnectionString("SQLConnection");
            }
        }
    }
}
