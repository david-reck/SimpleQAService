using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QAService.RuleEngine.Models
{
    public class QAExecutionResult
    {
        public QAExecutionResult()
        {
            RuleErrors = new List<QARuleError>();
        }

        public int ClientId { get; set; }

        public Int64 AccountId { get; set; }

        public string Event { get; set; }

        public List<QARuleError> RuleErrors { get; set; }
    }
}
