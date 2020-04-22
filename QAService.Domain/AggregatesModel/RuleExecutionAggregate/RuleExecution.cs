using System;
using System.Collections.Generic;
using System.Text;

namespace QAService.Domain.AggregatesModel.RuleExecutionAggregate
{
    public class RuleExecution
    {
        public RuleExecution()
        {
            RuleExecutionErrors = new List<RuleExecutionError>();
        }

        public Int64 RuleExecutionId { get; set; }

        public int ClientId { get; set; }

        public Int64 AccountId { get; set; }

        public string Event { get; set; }

        public List<RuleExecutionError> RuleExecutionErrors { get; set; }
    }
}
