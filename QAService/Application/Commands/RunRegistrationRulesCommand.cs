using MediatR;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace QAService.Application.Commands
{
    [DataContract]
    public class RunRegistrationRulesCommand : IRequest<bool>
    {

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string MiddleName { get; set; }

        [DataMember]
        public DateTime BirthDate { get; set; }

        [DataMember]
        public string Gender { get; set; }

        [DataMember]
        public List<PatientAddress> PatientAddresses { get; set; }

        [DataMember]
        public List<RuleError> RuleErrors { get; set; }


        public RunRegistrationRulesCommand()
        {

        }

        public RunRegistrationRulesCommand(string firstName, string lastName, DateTime birthDate, string gender)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Gender = gender;
        }
        public RunRegistrationRulesCommand(string firstName, string middleName,string lastName, DateTime birthDate, string gender)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            BirthDate = birthDate;
            Gender = gender;
        }

    }

    public class PatientAddress
    {
        [DataMember]
        public string Street { get; set; }

        [DataMember]
        public string Street2 { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string State { get; set; }

        [DataMember]
        public string Zip { get; set; }

    }

    public class RuleError
    {
        [DataMember]
        public int RuleId { get; set; }

        [DataMember]
        public string RuleErrorDescription { get; set; }

        [DataMember]
        public string RuleType { get; set; }
    }
}

