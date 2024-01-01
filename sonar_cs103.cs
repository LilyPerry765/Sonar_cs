//(cwe117), (cwe532)
using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore;

namespace MvcApp
{
    public class ProgramLogging
    {
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureLogging((hostingContext, logging) => // Sensitive
                {
                    // ...
                })
                .UseStartup<StartupLogging>();
    }

    public class StartupLogging
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging(logging => // Sensitive
            {
                // ...
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            IConfiguration config = null;
            LogLevel level = LogLevel.Critical;
            Boolean includeScopes = false;
            Func<string,Microsoft.Extensions.Logging.LogLevel,bool> filter = null;
            Microsoft.Extensions.Logging.Console.IConsoleLoggerSettings consoleSettings = null;
            Microsoft.Extensions.Logging.AzureAppServices.AzureAppServicesDiagnosticsSettings azureSettings = null;
            Microsoft.Extensions.Logging.EventLog.EventLogSettings eventLogSettings = null;

            // An issue will be raised for each call to an ILoggerFactory extension methods adding loggers.
            loggerFactory.AddAzureWebAppDiagnostics(); // Sensitive
            loggerFactory.AddAzureWebAppDiagnostics(azureSettings); // Sensitive
            loggerFactory.AddConsole(); // Sensitive
            loggerFactory.AddConsole(level); // Sensitive
            loggerFactory.AddConsole(level, includeScopes); // Sensitive
            loggerFactory.AddConsole(filter); // Sensitive
            loggerFactory.AddConsole(filter, includeScopes); // Sensitive
            loggerFactory.AddConsole(config); // Sensitive
            loggerFactory.AddConsole(consoleSettings); // Sensitive
            loggerFactory.AddDebug(); // Sensitive
            loggerFactory.AddDebug(level); // Sensitive
            loggerFactory.AddDebug(filter); // Sensitive
            loggerFactory.AddEventLog(); // Sensitive
            loggerFactory.AddEventLog(eventLogSettings); // Sensitive
            loggerFactory.AddEventLog(level); // Sensitive
            loggerFactory.AddEventSourceLogger(); // Sensitive

            IEnumerable<ILoggerProvider> providers = null;
            LoggerFilterOptions filterOptions1 = null;
            IOptionsMonitor<LoggerFilterOptions> filterOptions2 = null;

            LoggerFactory factory = new LoggerFactory(); // Sensitive
            new LoggerFactory(providers); // Sensitive
            new LoggerFactory(providers, filterOptions1); // Sensitive
            new LoggerFactory(providers, filterOptions2); // Sensitive
        }
    }
}