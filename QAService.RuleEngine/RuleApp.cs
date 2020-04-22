using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace QAService.RuleEngine
{
   
    public class RepositoryRuleAppRevisionSpec
    {
        public RepositoryRuleAppRevisionSpec(string ruleApplicationName)
        {
            this.RuleApplicationName = ruleApplicationName;
        }
        [JsonProperty("RuleApplicationName")]
        public string RuleApplicationName { get; set; }
    }

    public class RuleApp
    {
        public RuleApp(string password, string userName, RepositoryRuleAppRevisionSpec repositoryRuleAppRevisionSpec)
        {
            this.Password = password;
            this.UserName = userName;
            this.RepositoryRuleAppRevisionSpec = repositoryRuleAppRevisionSpec;
        }
        [JsonProperty("Password")]
        public string Password { get; set; }

        [JsonProperty("RepositoryRuleAppRevisionSpec")]
        public RepositoryRuleAppRevisionSpec RepositoryRuleAppRevisionSpec { get; set; }

        [JsonProperty("UserName")]
        public string UserName { get; set; }
    }

    public class RuleEngineServiceOutputTypes
    {
        public RuleEngineServiceOutputTypes(bool activeNotifications, bool activeValidations, bool entityState, bool overrides, bool ruleExecutionLog)
        {
            this.ActiveNotifications = activeNotifications;
            this.ActiveValidations = ActiveValidations;
            this.EntityState = entityState;
            this.Overrides = overrides;
            this.RuleExecutionLog = ruleExecutionLog;
        }

        [JsonProperty("ActiveNotifications")]
        public bool ActiveNotifications { get; set; }

        [JsonProperty("ActiveValidations")]
        public bool ActiveValidations { get; set; }

        [JsonProperty("EntityState")]
        public bool EntityState { get; set; }

        [JsonProperty("Overrides")]
        public bool Overrides { get; set; }

        [JsonProperty("RuleExecutionLog")]
        public bool RuleExecutionLog { get; set; }
    }

    public class RuleAppHeader
    {

        [JsonProperty("RuleApp")]
        public RuleApp RuleApp { get; set; }

        [JsonProperty("RuleEngineServiceOutputTypes")]
        public RuleEngineServiceOutputTypes RuleEngineServiceOutputTypes { get; set; }

        [JsonProperty("EntityName")]
        public string EntityName { get; set; }

        [JsonProperty("EntityState")]
        public string EntityState { get; set; }
    }

}
