using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using MediatR;
using QAService.Application.Models;

namespace QAService.Application.Commands
{
    [DataContract]
    public class RecordQAResultsCommand : IRequest<bool>
    {
        [DataMember]
        private readonly List<RuleExecutionErrorDTO> _executionErrors;

        [DataMember]
        public Int64 RuleExecutionId { get; set; }

        [DataMember]
        public int ClientId { get; set; }

        [DataMember]
        public Int64 AccountId { get; set; }
        [DataMember]
        public string Event { get; set; }


        [DataMember]
        public IEnumerable<RuleExecutionErrorDTO> ExecutionErrors => _executionErrors;

        public RecordQAResultsCommand()
        {
            _executionErrors = new List<RuleExecutionErrorDTO>();
        }

        public RecordQAResultsCommand(int clientId, Int64 accountId, string eventEvaluated, List<QARuleError> errors)
        {
            this.ClientId = clientId;
            this.AccountId = accountId;
            this.Event = eventEvaluated;
            this._executionErrors = ToRuleExecutionErrorsDTO(errors).ToList();
        }

        private IEnumerable<RuleExecutionErrorDTO> ToRuleExecutionErrorsDTO(IEnumerable<QARuleError> qaErrors)
        {
            foreach (var item in qaErrors)
            {
                yield return ToRuleExecutionErrorDTO(item);
            }
        }

        private RuleExecutionErrorDTO ToRuleExecutionErrorDTO(QARuleError item)
        {
            return new RuleExecutionErrorDTO()
            {
                RuleId = item.RuleId,
                RuleType = item.RuleType,
                RuleErrorDescription = item.RuleErrorDescription

            };
        }
    }

    public class RuleExecutionErrorDTO
    {
        public Int64 RuleExecutionErrorId { get; set; }

        public Int64 RuleId { get; set; }

        public int RuleType { get; set; }

        public string RuleErrorDescription { get; set; }

    }
}

