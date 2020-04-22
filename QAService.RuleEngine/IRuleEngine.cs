using QAService.RuleEngine.Models;

namespace QAService.RuleEngine
{
    public interface IRuleEngine
    {
        QAExecutionResult ExecuteRules(string DomainAggregate, string SerializedAggregate);
    }
}
