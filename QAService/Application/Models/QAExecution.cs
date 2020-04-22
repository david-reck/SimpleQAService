using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QAService.Application.Models
{
    public class QAExecution
    {
        public QAExecution()
        {
            RuleErrors = new List<QARuleError>();
        }

        public int ClientId { get; set; }

        public Int64 AccountId { get; set; }

        public string Event { get; set; }

        public List<QARuleError> RuleErrors { get; set; }
    }
}
