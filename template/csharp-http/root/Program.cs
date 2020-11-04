using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace template
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder( string[] args) =>
            Host.CreateDefaultBuilder( args )
                .ConfigureWebHostDefaults( webBuilder =>
                {
                    webBuilder.ConfigureAppConfiguration( configBuilder =>
                    {
                        configBuilder.AddEnvironmentVariables();
                        configBuilder.AddOpenFaaSSecrets();
                    } );

                    webBuilder.UseKestrel()
                        .UseStartup<Startup>()
                        .UseUrls( "http://localhost:5000" );
                } );
    }
}
