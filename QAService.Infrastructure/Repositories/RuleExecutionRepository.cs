using QAService.Domain.AggregatesModel.RuleExecutionAggregate;
using System;

namespace QAService.Infrastructure.Repositories
{
    public class RuleExecutionRepository : IRuleExecutionRepository
    {
        private readonly RuleExecutionContext _context;
        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _context;
            }
        }

        public RuleExecutionRepository(RuleExecutionContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public RuleExecution Add(RuleExecution ruleExecution)
        {
            throw new NotImplementedException();
        }

        public RuleExecution Update(RuleExecution ruleExecution)
        {
            throw new NotImplementedException();
        }
    }
}
