using System;
using System.Threading.Tasks;
using AIT.Devices;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace aggregator
{
    public class Startup : IStartup
    {
        public Task ConfigureAsync(IModuleClient moduleClient)
        {
            Log.Information("Configure");
            return Task.CompletedTask;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            Log.Information("ConfigureServices");
        }        
    }
}