using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QAService.Application.Models
{
    public class QARuleError
    {

        public Int64 RuleExecutionErrorId { get; set; }

        public Int64 RuleId { get; set; }

        public int RuleType { get; set; }

        public string RuleErrorDescription { get; set; }
    }
}
