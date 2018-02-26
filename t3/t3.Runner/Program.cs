using Microsoft.Extensions.Configuration;

namespace t3.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            
            
        }
    }
}
