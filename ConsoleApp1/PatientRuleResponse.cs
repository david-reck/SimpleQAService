using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class PatientRuleResponse
    {
       
            [JsonProperty("FirstName")]
            public string FirstName { get; set; }

            [JsonProperty("LastName")]
            public string LastName { get; set; }

            [JsonProperty("MiddleName")]
            public string MiddleName { get; set; }

            [JsonProperty("BirthDate")]
            public DateTime BirthDate { get; set; }

            [JsonProperty("Gender")]
            public string Gender { get; set; }

            [JsonProperty("PatientAddresses")]
            public List<PatientAddress> PatientAddresses { get; set; }

            [JsonProperty("RuleErrors")]
            public List<RuleError> RuleErrors { get; set; }

        
    }

    public class PatientAddress
    {
        [JsonProperty("Street")]
        public string Street { get; set; }

        [JsonProperty("Street2")]
        public string Street2 { get; set; }

        [JsonProperty("City")]
        public string City { get; set; }

        [JsonProperty("State")]
        public string State { get; set; }

        [JsonProperty("Zip")]
        public string Zip { get; set; }

    }


    public  class RuleErrorList
    {

        public List<RuleError> RuleErrors { get; set; }

        public RuleErrorList()
        {

        }
    }
    public class RuleError
    {
        [JsonProperty("RuleId")]
        public int RuleId { get; set; }

        [JsonProperty("RuleErrorDescription")]
        public string RuleErrorDescription { get; set; }

        [JsonProperty("RuleType")]
        public string RuleType { get; set; }
    }
}
