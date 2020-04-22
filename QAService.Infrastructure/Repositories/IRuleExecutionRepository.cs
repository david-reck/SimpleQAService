using System;
using System.Collections.Generic;
using System.Text;
using QAService.Domain.AggregatesModel.RuleExecutionAggregate;

namespace QAService.Infrastructure.Repositories
{
    public interface IRuleExecutionRepository : IRepository<RuleExecution>
    {
        RuleExecution Add(RuleExecution ruleExecution);

        RuleExecution Update(RuleExecution ruleExecution);

    }
}
