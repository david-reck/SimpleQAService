using MediatR;
using QAService.Domain.AggregatesModel.RuleExecutionAggregate;
using QAService.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace QAService.Application.Commands
{
    public class RecordQAResultsCommandHandler : IRequestHandler<RecordQAResultsCommand, bool>
    {
        private readonly RuleExecutionContext _ruleExecutionContext;
        private readonly IMediator _mediator;

        public RecordQAResultsCommandHandler(RuleExecutionContext ruleExecution, IMediator mediator)
        {
            _ruleExecutionContext = ruleExecution;
            _mediator = mediator;
        }

        public async Task<bool> Handle(RecordQAResultsCommand message, CancellationToken cancellationToken)
        {
            var ruleExecution = new RuleExecution();
            ruleExecution.AccountId = message.AccountId;
            ruleExecution.ClientId = message.ClientId;
            ruleExecution.Event = message.Event;

            foreach (var item in message.ExecutionErrors)
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
