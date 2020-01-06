using System.Text.Json;
using System.Threading.Tasks;
using AIT.Devices;
using Microsoft.Azure.Devices.Client;
using Serilog;

namespace aggregator
{
    [MessageHandler]
    public class MessageHandler : IMessageHandler
    {
        private readonly IModuleClient _moduleClient;

        public MessageHandler(IModuleClient moduleClient)
        {
            _moduleClient = moduleClient;
        }

        public async Task<MessageResponse> HandleMessageAsync(Message message)
        {
            message.Properties["original-connection-module-id"] = message.ConnectionModuleId;

            //await _moduleClient.SendEventAsync(message);
            
            var json = await JsonDocument.ParseAsync(message.BodyStream);
            Log.Information("Received message: {Message}", json.RootElement.ToString());

            return MessageResponse.Completed;
        }
    }
}