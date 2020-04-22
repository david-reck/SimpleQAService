using System.Threading.Tasks;
using iPas.Infrastructure.EventBus.Abstractions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Serilog.Context;
using QAService.IntegrationEvents.Events;
using QAService.Application.Commands;
using MediatR;
using System;
using Grpc.Net.Client;
using RegistrationService.API.Grpc;
using QAService.Application.Models.DTORaw;
using Newtonsoft.Json;
using System.Globalization;

namespace QAService.IntegrationEvents.EventHandling
{
    public class RegistrationReceivedIntegrationEventHandler :
        IIntegrationEventHandler<RegistrationReceivedIntegrationEvent>
    {
        private readonly IEventBus _eventBus;
        private readonly ILogger<RegistrationReceivedIntegrationEventHandler> _logger;
        private IMediator _mediatr;
        public RegistrationReceivedIntegrationEventHandler(
            IEventBus eventBus,
            ILogger<RegistrationReceivedIntegrationEventHandler> logger,
            IMediator mediatr
            )
        {
            _eventBus = eventBus;
            _logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
            _mediatr = mediatr ?? throw new ArgumentNullException(nameof(mediatr));
        }

        public async Task Handle(RegistrationReceivedIntegrationEvent @event)
        {
            using (LogContext.PushProperty("IntegrationEventContext", $"{@event.Id}-{Program.AppName}"))
            {
                _logger.LogInformation("----- Handling integration event: {IntegrationEventId} at {AppName} - ({@IntegrationEvent})", @event.Id, Program.AppName, @event);


                /*TODO: Check below should be verifying client subscribes to QA Module */
                if (@event.ClientId == 1)
                {

                    AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
                    var channel = GrpcChannel.ForAddress("http://127.0.0.1:5021");
                    var client = new RegistrationApiRetrieval.RegistrationApiRetrievalClient(channel);
                    var adtMessageRequest = new AdtMessageRequest { Id = @event.DocumentId, ClientId = @event.ClientId };
                    var reply = client.FindAdtMessageById(adtMessageRequest);

                    Hl7Adt message = JsonConvert.DeserializeObject<Hl7Adt>(reply.AdtMessage);
                    
                    bool commandResult = false;

                    string[] format = { "yyyyMMdd" };
                    DateTime date;

                    DateTime.TryParseExact(message.Hl7Message.Pid.Pid7.Pid71,
                                               format,
                                               System.Globalization.CultureInfo.InvariantCulture,
                                               System.Globalization.DateTimeStyles.None,
                                               out date);

                    var command = new RunRegistrationRulesCommand(message.Hl7Message.Pid.Pid5.Pid51, message.Hl7Message.Pid.Pid5.Pid52,
                       date, message.Hl7Message.Pid.Pid8.Pid81);

                    _logger.LogInformation("-----Sending command: RunRegistrationRulesCommand");

                    commandResult = await _mediatr.Send(command);
                }
                await Task.CompletedTask;
            }
        }
    }
}
