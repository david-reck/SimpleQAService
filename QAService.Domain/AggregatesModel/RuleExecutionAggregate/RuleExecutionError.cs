using System;
using System.Collections.Generic;
using System.Text;

namespace QAService.Domain.AggregatesModel.RuleExecutionAggregate
{
    public class RuleExecutionError
    {

        public RuleExecutionError()
        {
           
        }

        public Int64 RuleExecutionErrorId { get; set; }

        public Int64 RuleId { get; set; }

        public int RuleType { get; set; }

        public string RuleErrorDescription { get; set; }

        public Int64 RuleExecutionId { get; set; }
    }
}
