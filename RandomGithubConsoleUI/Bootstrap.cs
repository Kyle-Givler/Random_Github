using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RandomGithubLibrary;

namespace RandomGithubConsoleUI
{
    public class Bootstrap
    {
        public static IServiceProvider Initialize(string[] args)
        {
            IConfigurationBuilder configBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true);

            IConfiguration config = configBuilder.Build();

            IServiceCollection serviceCollection = new ServiceCollection();
            IServiceProvider serviceProvider = serviceCollection
                .AddSingleton<IConfiguration>(config)
                .AddSingleton<IGithubAPI, GithubAPI>()
                .BuildServiceProvider();

            return serviceProvider;
        }
    }
}
