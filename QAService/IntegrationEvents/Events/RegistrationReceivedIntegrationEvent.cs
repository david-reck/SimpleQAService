using System;
using iPas.Infrastructure.EventBus.Events;

namespace QAService.IntegrationEvents.Events
{
    public class RegistrationReceivedIntegrationEvent : IntegrationEvent
    {
        public int ClientId { get; set; }
        public int FacilityId { get; set; }
        public string AccountNumber { get; set; }
        public string MedicalRecordNumber { get; set; }
        public string DocumentId { get; set; }

        //******************
        //TO BE REMOVED AFTER ADDING GRPC INTEGRATION
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public RegistrationReceivedIntegrationEvent(int clientId, int facilityId, string accountNumber, string medicalRecordNumber, string documentId,
                DateTime birthDate, string gender, string firstName, string middleName, string lastName)
        {
            ClientId = clientId;
            FacilityId = facilityId;
            AccountNumber = accountNumber;
            MedicalRecordNumber = medicalRecordNumber;
            DocumentId = documentId;
            BirthDate = birthDate;
            Gender = gender;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }
    }
}
