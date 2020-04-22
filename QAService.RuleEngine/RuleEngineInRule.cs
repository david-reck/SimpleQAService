using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using QAService.RuleEngine.Models;
using RestSharp;
using System;

namespace QAService.RuleEngine
{
    public class RuleEngineInRule : IRuleEngine
    {
        public string _restClient { get; set; }
        public string _authorizationKey { get; set; }
        public string _password { get; set; }
        public string _userName { get; set; }
        public string _ruleRepository { get; set; }
        public RuleEngineInRule()
        { }
        public QAExecutionResult ExecuteRules(string DomainAggregate, string SerializedAggregate)
        {
            var client = new RestClient(_restClient);
            var request = new RestRequest("ApplyRules", Method.POST);
            request.AddHeader("Authorization", _authorizationKey);
            request.AddHeader("Accept", "application/json");
            RuleAppHeader rah = new RuleAppHeader();

            rah.RuleApp = new RuleApp(_password, _userName, new RepositoryRuleAppRevisionSpec(_ruleRepository));
            rah.RuleEngineServiceOutputTypes = new RuleEngineServiceOutputTypes(true, true, true, true, true);
            rah.EntityName = DomainAggregate;
            rah.EntityState = SerializedAggregate;

            request.AddJsonBody(rah);
            IRestResponse response = client.Execute(request);
            dynamic apiResponse = JObject.Parse(response.Content);
            string entity = apiResponse.EntityState;
            return JsonConvert.DeserializeObject<QAExecutionResult>(entity);

        }
    }
}
