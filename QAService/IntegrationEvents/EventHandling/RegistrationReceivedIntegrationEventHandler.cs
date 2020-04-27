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
using ClientService.API.Grpc;
using QAService.Application.Models.DTORaw;
using Newtonsoft.Json;
using System.Globalization;
using QAService.Grpc;

namespace QAService.IntegrationEvents.EventHandling
{
    public class RegistrationReceivedIntegrationEventHandler :
        IIntegrationEventHandler<RegistrationReceivedIntegrationEvent>
    {
        private readonly IEventBus _eventBus;
        private readonly ILogger<RegistrationReceivedIntegrationEventHandler> _logger;
        private IMediator _mediatr;
        private IClientGRPCClientService _grpcClientService;
        private IRegistrationGRPCClientService _grpcRegistrationService;
        public RegistrationReceivedIntegrationEventHandler(
            IEventBus eventBus,
            ILogger<RegistrationReceivedIntegrationEventHandler> logger,
            IMediator mediatr,
            IClientGRPCClientService clientService,
            IRegistrationGRPCClientService registrationService
            )
        {
            _eventBus = eventBus;
            _logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
            _mediatr = mediatr ?? throw new ArgumentNullException(nameof(mediatr));
            _grpcClientService = clientService ?? throw new ArgumentNullException(nameof(clientService));
            _grpcRegistrationService = registrationService ?? throw new ArgumentNullException(nameof(registrationService));
        }

        public async Task Handle(RegistrationReceivedIntegrationEvent @event)
        {
            using (LogContext.PushProperty("IntegrationEventContext", $"{@event.Id}-{Program.AppName}"))
            {
                _logger.LogInformation("----- Handling integration event: {IntegrationEventId} at {AppName} - ({@IntegrationEvent})", @event.Id, Program.AppName, @event);


                if (await _grpcClientService.ClientFacilitySubscribesToModule(@event.ClientId, "DAL"))
                {

                    Hl7Adt message = await _grpcRegistrationService.RegistrationDataById(@event.DocumentId, @event.ClientId);

            
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
