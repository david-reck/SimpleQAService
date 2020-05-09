using System.Threading.Tasks;
using iPas.Infrastructure.EventBus.Abstractions;
using Microsoft.Extensions.Logging;
using Serilog.Context;
using QAService.IntegrationEvents.Events;
using QAService.Application.Commands;
using MediatR;
using System;
using QAService.Grpc;
using QAService.Application.Models;

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


                if (await _grpcClientService.ClientFacilitySubscribesToModuleByFacilityId(@event.ClientId, @event.FacilityId))
                {
                    try
                    {
                        Adt adt = await _grpcRegistrationService.RegistrationDataById(@event.DocumentId, @event.ClientId);

                        
                        bool commandResult = false;

                        string[] format = { "yyyyMMdd" };
                        DateTime date;

                        DateTime.TryParseExact(adt.content.PID[0].dateTimeBirth,
                                               format,
                                               System.Globalization.CultureInfo.InvariantCulture,
                                               System.Globalization.DateTimeStyles.None,
                                               out date);

                    var command = new RunRegistrationRulesCommand(adt.content.PID[0].patientName[0].firstName,
                       adt.content.PID[0].patientName[0].lastName,
                       date,
                       adt.content.PID[0].sex);

                    _logger.LogInformation("-----Sending command: RunRegistrationRulesCommand");

                    commandResult = await _mediatr.Send(command);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error: " + e.Message);
                    }
                }
                await Task.CompletedTask;
            }
        }
    }
}
