using MediatR;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace QAService.Application.Commands
{
    [DataContract]
    public class RunADTMessageRulesCommand : IRequest<bool>
    {

        [DataMember]
        public int ClientId { get; set; }
        [DataMember]
        public int FacilityId { get; set; }
        [DataMember]
        public string AccountNumber { get; set; }
        [DataMember]
        public string MedicalRecordNumber { get; set; }

        [DataMember]
        public string ADTMessage { get; set; }

        [DataMember]
        public List<RuleError> RuleErrors { get; set; }




        public RunADTMessageRulesCommand(int clientId, int facilityId, string accountNumber, string medicalRecordNumber, string adtMessage)
        {
            ClientId = clientId;
            FacilityId = facilityId;
            AccountNumber = accountNumber;
            MedicalRecordNumber = medicalRecordNumber;
            ADTMessage = adtMessage;
        }
        

    }

   
   
}

