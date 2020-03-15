using System;
using System.Threading.Tasks;
using AIT.Devices;
using Microsoft.Azure.Devices.Client;
using Microsoft.Azure.Devices.Shared;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace aggregator
{
    public class Startup
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

        public Task ConnectionStatusChangesAsync(ConnectionStatus status, ConnectionStatusChangeReason reason)
        {
            Log.Information("ConnectionStatusChangesAsync");
            return Task.CompletedTask;
        }

        public Task DesiredPropertyUpdateAsync(TwinCollection desiredProperties)
        {
            Log.Information("DesiredPropertyUpdateAsync");
            return Task.CompletedTask;
        }
    }
}