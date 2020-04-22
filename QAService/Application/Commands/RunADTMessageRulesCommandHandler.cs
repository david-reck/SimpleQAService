using MediatR;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using QAService.Domain.AggregatesModel.RuleExecutionAggregate;
using QAService.Infrastructure;
using QAService.RuleEngine;
using QAService.RuleEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace QAService.Application.Commands
{
    public class RunADTMessageRulesCommandHandler : IRequestHandler<RunADTMessageRulesCommand, bool>
    {
        private readonly RuleExecutionContext _ruleExecutionContext;
        private readonly IMediator _mediator;
        private readonly IOptions<RuleExecutionSettings> _settings;
        public RunADTMessageRulesCommandHandler(RuleExecutionContext ruleExecution, IMediator mediator, IOptions<RuleExecutionSettings> settings)
        {
            _ruleExecutionContext = ruleExecution;
            _mediator = mediator;
            _settings = settings;
        }

        public async Task<bool> Handle(RunADTMessageRulesCommand message, CancellationToken cancellationToken)
        {

            RuleEngineInRule ruleEngine = new RuleEngineInRule();

            ruleEngine._authorizationKey = _settings.Value.AuthorizationKey;
            ruleEngine._password = _settings.Value.Password;
            ruleEngine._restClient = _settings.Value.RestClient;
            ruleEngine._ruleRepository = _settings.Value.RegistrationRuleRepository;
            ruleEngine._userName = _settings.Value.UserName;
            string entity = JsonConvert.SerializeObject(message);
            QAExecutionResult results = ruleEngine.ExecuteRules("Patient", entity);


            var ruleExecution = new RuleExecution();
            ruleExecution.AccountId = 1;
            ruleExecution.ClientId = 1;
            ruleExecution.Event = "RegistrationReceived";

            foreach (var item in results.RuleErrors)
            {
                ruleExecution.RuleExecutionErrors
                .Add(new RuleExecutionError()
                {
                    RuleId = item.RuleId,
                    RuleErrorDescription = item.RuleErrorDescription,
                    RuleType = item.RuleType
                }
                );
            }

            _ruleExecutionContext.Add(ruleExecution);

            return await _ruleExecutionContext.SaveEntitiesAsync(cancellationToken);

        }
    }
}

