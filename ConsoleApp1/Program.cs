using System;
using RestSharp;
using Newtonsoft.Json;
using RestSharp.Serialization.Xml;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("https://trial-99kjw9-632-execute.inrulecloud.com/HttpService.svc/");
            var request = new RestRequest("ApplyRules", Method.POST);
            request.AddHeader("Authorization", "APIKEY 06455cc83a334b8cb88d6784a0b56b15");
            request.AddHeader("Accept", "application/json");
            RuleAppHeader rah = new RuleAppHeader();

            rah.RuleApp = new RuleApp("UYJTfM7W", "dreck", new RepositoryRuleAppRevisionSpec("iPas"));
            rah.RuleEngineServiceOutputTypes = new RuleEngineServiceOutputTypes(true, true, true, true, true);
            rah.EntityName = "Patient";
            rah.EntityState = "{ \"firstName\": \"David\", \"lastName\": \"Re\", \"middleName\": \"Joseph\",  \"birthDate\": \"1990-11-21T00:00:00\", \"gender\": \"M\"}";

            request.AddJsonBody(rah);
            IRestResponse response = client.Execute(request);
            dynamic apiResponse = JObject.Parse(response.Content);
            string entity = apiResponse.EntityState;
            dynamic entityResponse = JObject.Parse(entity);
            //RuleError [] re  = entityResponse.RuleErrors;
            RuleErrorList re  = JsonConvert.DeserializeObject<RuleErrorList>(entity);
           
        }
    }
}

//string apiKey = " Bearer yourAPI";
//string apiServer = "your server address";
//var client = new RestClient(apiServer);
//var request = new RestRequest("yourResource");
//request.AddHeader("Authorization", apiKey);
//var queryResult = client.Execute(request);