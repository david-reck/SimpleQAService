using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QAService.Application.Models
{
    public class Adt
    {
        [JsonProperty(PropertyName = "id")]
        public string id { get; set; }
        public string message_type { get; set; }
        public Content content { get; set; }
        public Int64 PatientId { get; set; }
        public Int64 PatientVisitId { get; set; }
        public Int64 PatientTransactionId { get; set; }
        public Int64 ClientId { get; set; }
        public Int64 FacilityId { get; set; }
    }


    public class Content
    {
        public ACC[] ACC { get; set; }
        public AL1[] AL1 { get; set; }
        public DB1[] DB1 { get; set; }
        public DG1[] DG1 { get; set; }
        public DRG[] DRG { get; set; }
        public EVN[] EVN { get; set; }
        public GT1[] GT1 { get; set; }
        public IN1[] IN1 { get; set; }
        public MSH MSH { get; set; }
        public NK1[] NK1 { get; set; }
        public OBX[] OBX { get; set; }
        public PID[] PID { get; set; }
        public PV1[] PV1 { get; set; }
        public UB1[] UB1 { get; set; }
        public UB2[] UB2 { get; set; }
    }

    public class EVN
    {
        public string eventOccured { get; set; }
        public string eventReasonCode { get; set; }
        public string eventType { get; set; }
        public Operatorid operatorId { get; set; }
        public string plannedEventDateTime { get; set; }
        public string recordedDateTime { get; set; }
    }

    public class Operatorid
    {
        public Assigningauthority assigningAuthority { get; set; }
        public Assigningfacility assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string degree { get; set; }
        public string firstName { get; set; }
        public string id { get; set; }
        public string identifierCheckDigit { get; set; }
        public string identifierTypeCode { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string sourceTable { get; set; }
        public string suffix { get; set; }
    }

    public class Assigningauthority
    {
        public string id { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility
    {
        public string id { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class MSH
    {
        public string acceptAcknowledgmentType { get; set; }
        public string applicationAcknowledgmentType { get; set; }
        public string[] characterSet { get; set; }
        public string continuationPointer { get; set; }
        public string countryCode { get; set; }
        public string dateTimeOfMessage { get; set; }
        public string encodingCharacters { get; set; }
        public string fieldSeparator { get; set; }
        public string messageControlID { get; set; }
        public Messagetype messageType { get; set; }
        public Principallanguageofmessage principalLanguageOfMessage { get; set; }
        public Processingid processingID { get; set; }
        public Receivingapplication receivingApplication { get; set; }
        public Receivingfacility receivingFacility { get; set; }
        public string security { get; set; }
        public Sendingapplication sendingApplication { get; set; }
        public Sendingfacility sendingFacility { get; set; }
        public string sequenceNumber { get; set; }
        public string versionID { get; set; }
    }

    public class Messagetype
    {
        public string messageType { get; set; }
        public string triggerEvent { get; set; }
    }

    public class Principallanguageofmessage
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Processingid
    {
        public string processingID { get; set; }
        public string processingMode { get; set; }
    }

    public class Receivingapplication
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Receivingfacility
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Sendingapplication
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Sendingfacility
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class PID
    {
        public NTE[] NTE { get; set; }
        public PD1[] PD1 { get; set; }
        public Address[] address { get; set; }
        public Alias[] alias { get; set; }
        public Alternateid[] alternateId { get; set; }
        public string birthOrder { get; set; }
        public string birthPlace { get; set; }
        public Businessphone[] businessPhone { get; set; }
        public string[] citizenship { get; set; }
        public string countyCode { get; set; }
        public string dateTimeBirth { get; set; }
        public string deathDateTime { get; set; }
        public string deathIndicator { get; set; }
        public Driverslicensenumber driversLicenseNumber { get; set; }
        public string ethnicGroup { get; set; }
        public Externalid externalId { get; set; }
        public Homephone[] homePhone { get; set; }
        public Internalid[] internalId { get; set; }
        public string maritalStatus { get; set; }
        public Mothersid[] mothersId { get; set; }
        public Mothersmaidenname mothersMaidenName { get; set; }
        public string multipleBirthIndicator { get; set; }
        public Nationality nationality { get; set; }
        public Patientaccountnumber patientAccountNumber { get; set; }
        public Patientname[] patientName { get; set; }
        public Primarylanguage primaryLanguage { get; set; }
        public string race { get; set; }
        public string religion { get; set; }
        public string setId { get; set; }
        public string sex { get; set; }
        public string ssn { get; set; }
        public Veteranstatus veteranStatus { get; set; }
    }

    public class Driverslicensenumber
    {
        public string expirationDate { get; set; }
        public string issuingStateProvinceCountry { get; set; }
        public string licenseNumber { get; set; }
    }

    public class Externalid
    {
        public Assigningauthority1 assigningAuthority { get; set; }
        public Assigningfacility1 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string id { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
    }

    public class Assigningauthority1
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility1
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Mothersmaidenname
    {
        public string degree { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class Nationality
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Patientaccountnumber
    {
        public Assigningauthority2 assigningAuthority { get; set; }
        public Assigningfacility2 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string id { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
    }

    public class Assigningauthority2
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility2
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Primarylanguage
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Veteranstatus
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class NTE
    {
        public string[] comment { get; set; }
        public string setId { get; set; }
        public string sourceOfComment { get; set; }
    }

    public class PD1
    {
        public Duplicatepatient[] duplicatePatient { get; set; }
        public string handicap { get; set; }
        public string livingArrangement { get; set; }
        public string[] livingDependency { get; set; }
        public string livingWillCode { get; set; }
        public string organDonorCode { get; set; }
        public Patientprimaryfacility[] patientPrimaryFacility { get; set; }
        public Primarycareprovider[] primaryCareProvider { get; set; }
        public string protectionIndicator { get; set; }
        public Publicityindicator publicityIndicator { get; set; }
        public string separateBill { get; set; }
        public string studentIndicator { get; set; }
    }

    public class Publicityindicator
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Duplicatepatient
    {
        public Assigningauthority3 assigningAuthority { get; set; }
        public Assigningfacility3 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string id { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
    }

    public class Assigningauthority3
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility3
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Patientprimaryfacility
    {
        public Assigningauthority4 assigningAuthority { get; set; }
        public Assigningfacility4 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string idNumber { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
        public string organizationName { get; set; }
        public string organizationNameTypeCode { get; set; }
    }

    public class Assigningauthority4
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility4
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Primarycareprovider
    {
        public Assigningauthority5 assigningAuthority { get; set; }
        public Assigningfacility5 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string degree { get; set; }
        public string firstName { get; set; }
        public string id { get; set; }
        public string identifierCheckDigit { get; set; }
        public string identifierTypeCode { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string sourceTable { get; set; }
        public string suffix { get; set; }
    }

    public class Assigningauthority5
    {
        public string id { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility5
    {
        public string id { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Address
    {
        public string addressType { get; set; }
        public string censusTract { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string countyOrParishCode { get; set; }
        public string otherDesignation { get; set; }
        public string otherGeographicDesignation { get; set; }
        public string stateOrProvince { get; set; }
        public string streetAddress { get; set; }
        public string zip { get; set; }
    }

    public class Alias
    {
        public string degree { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class Alternateid
    {
        public Assigningauthority6 assigningAuthority { get; set; }
        public Assigningfacility6 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string id { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
    }

    public class Assigningauthority6
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility6
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Businessphone
    {
        public string areaCityCode { get; set; }
        public string countryCode { get; set; }
        public string emailAddress { get; set; }
        public string extension { get; set; }
        public string number { get; set; }
        public string phoneNumber { get; set; }
        public string telecommunicationEquipmentType { get; set; }
        public string telecommunicationUseCode { get; set; }
        public string text { get; set; }
    }

    public class Homephone
    {
        public string areaCityCode { get; set; }
        public string countryCode { get; set; }
        public string emailAddress { get; set; }
        public string extension { get; set; }
        public string number { get; set; }
        public string phoneNumber { get; set; }
        public string telecommunicationEquipmentType { get; set; }
        public string telecommunicationUseCode { get; set; }
        public string text { get; set; }
    }

    public class Internalid
    {
        public Assigningauthority7 assigningAuthority { get; set; }
        public Assigningfacility7 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string id { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
    }

    public class Assigningauthority7
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility7
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Mothersid
    {
        public Assigningauthority8 assigningAuthority { get; set; }
        public Assigningfacility8 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string id { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
    }

    public class Assigningauthority8
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility8
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Patientname
    {
        public string degree { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class PV1
    {
        public PV2[] PV2 { get; set; }
        public string accountStatus { get; set; }
        public string admissionType { get; set; }
        public string admitDateTime { get; set; }
        public string admitSource { get; set; }
        public Admittingdoctor[] admittingDoctor { get; set; }
        public Alternatevisitid alternateVisitID { get; set; }
        public string[] ambulatoryStatus { get; set; }
        public Assignedpatientlocation assignedPatientLocation { get; set; }
        public Attendingdoctor[] attendingDoctor { get; set; }
        public string badDebtAgencyCode { get; set; }
        public string badDebtRecoveryAmount { get; set; }
        public string badDebtTransferAmount { get; set; }
        public string bedStatus { get; set; }
        public string chargePriceIndicator { get; set; }
        public Consultingdoctor[] consultingDoctor { get; set; }
        public string[] contractAmount { get; set; }
        public string[] contractCode { get; set; }
        public string[] contractEffectiveDate { get; set; }
        public string[] contractPeriod { get; set; }
        public string courtesyCode { get; set; }
        public string creditRating { get; set; }
        public string currentPatientBalance { get; set; }
        public string deleteAccountDate { get; set; }
        public string deleteAccountIndicator { get; set; }
        public string dietType { get; set; }
        public string dischargeDateTime { get; set; }
        public string dischargeDisposition { get; set; }
        public Dischargedtolocation dischargedtoLocation { get; set; }
        public Financialclass financialClass { get; set; }
        public string hospitalService { get; set; }
        public string interestCode { get; set; }
        public Otherhealthcareprovider otherHealthcareProvider { get; set; }
        public string patientClass { get; set; }
        public string patientType { get; set; }
        public Pendinglocation pendingLocation { get; set; }
        public Preadmitnumber preadmitNumber { get; set; }
        public string preadmitTestIndicator { get; set; }
        public Priorpatientlocation priorPatientLocation { get; set; }
        public Priortemporarylocation priorTemporaryLocation { get; set; }
        public string readmissionIndicator { get; set; }
        public Referringdoctor[] referringDoctor { get; set; }
        public string servicingFacility { get; set; }
        public string setId { get; set; }
        public Temporarylocation temporaryLocation { get; set; }
        public string totalAdjustments { get; set; }
        public string totalCharges { get; set; }
        public string totalPayments { get; set; }
        public string transferToBadDebtCode { get; set; }
        public string transferToBadDebtDate { get; set; }
        public string vipIndicator { get; set; }
        public string visitIndicator { get; set; }
        public Visitnumber visitNumber { get; set; }
    }

    public class Alternatevisitid
    {
        public Assigningauthority9 assigningAuthority { get; set; }
        public Assigningfacility9 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string id { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
    }

    public class Assigningauthority9
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility9
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assignedpatientlocation
    {
        public string bed { get; set; }
        public string building { get; set; }
        public Facility facility { get; set; }
        public string floor { get; set; }
        public string locationDescription { get; set; }
        public string locationStatus { get; set; }
        public string personLocationType { get; set; }
        public string pointOfCare { get; set; }
        public string room { get; set; }
    }

    public class Facility
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Dischargedtolocation
    {
        public string dischargeLocation { get; set; }
        public string effectiveDate { get; set; }
    }

    public class Otherhealthcareprovider
    {
        public Assigningauthority10 assigningAuthority { get; set; }
        public Assigningfacility10 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string degree { get; set; }
        public string firstName { get; set; }
        public string id { get; set; }
        public string identifierCheckDigit { get; set; }
        public string identifierTypeCode { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string sourceTable { get; set; }
        public string suffix { get; set; }
    }

    public class Assigningauthority10
    {
        public string id { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility10
    {
        public string id { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Pendinglocation
    {
        public string bed { get; set; }
        public string building { get; set; }
        public Facility1 facility { get; set; }
        public string floor { get; set; }
        public string locationDescription { get; set; }
        public string locationStatus { get; set; }
        public string personLocationType { get; set; }
        public string pointOfCare { get; set; }
        public string room { get; set; }
    }

    public class Facility1
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Preadmitnumber
    {
        public Assigningauthority11 assigningAuthority { get; set; }
        public Assigningfacility11 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string id { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
    }

    public class Assigningauthority11
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility11
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Priorpatientlocation
    {
        public string bed { get; set; }
        public string building { get; set; }
        public Facility2 facility { get; set; }
        public string floor { get; set; }
        public string locationDescription { get; set; }
        public string locationStatus { get; set; }
        public string personLocationType { get; set; }
        public string pointOfCare { get; set; }
        public string room { get; set; }
    }

    public class Facility2
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Priortemporarylocation
    {
        public string bed { get; set; }
        public string building { get; set; }
        public Facility3 facility { get; set; }
        public string floor { get; set; }
        public string locationDescription { get; set; }
        public string locationStatus { get; set; }
        public string personLocationType { get; set; }
        public string pointOfCare { get; set; }
        public string room { get; set; }
    }

    public class Facility3
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Temporarylocation
    {
        public string bed { get; set; }
        public string building { get; set; }
        public Facility4 facility { get; set; }
        public string floor { get; set; }
        public string locationDescription { get; set; }
        public string locationStatus { get; set; }
        public string personLocationType { get; set; }
        public string pointOfCare { get; set; }
        public string room { get; set; }
    }

    public class Facility4
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Visitnumber
    {
        public Assigningauthority12 assigningAuthority { get; set; }
        public Assigningfacility12 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string id { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
    }

    public class Assigningauthority12
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility12
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class PV2
    {
        public Accommodationcode accommodationCode { get; set; }
        public string actualLengthInpatientStay { get; set; }
        public Admitreason admitReason { get; set; }
        public string babyDetainedIndicator { get; set; }
        public string billingMediaCode { get; set; }
        public Clinicorganizationname[] clinicOrganizationName { get; set; }
        public string employmentIllnessRelatedIndicator { get; set; }
        public string estimatedLengthInpatientStay { get; set; }
        public string expectedAdmitDateTime { get; set; }
        public string expectedDischargeDateTime { get; set; }
        public string expectedDischargeDisposition { get; set; }
        public string expectedNumInsurancePlans { get; set; }
        public string expectedSurgeryDateTime { get; set; }
        public string firstSimilarIllnessDate { get; set; }
        public string militaryNonAvailabilityCode { get; set; }
        public string militaryPartnershipCode { get; set; }
        public string newbornBabyIndicator { get; set; }
        public string patientChargeAdjustmentCode { get; set; }
        public string patientStatusCode { get; set; }
        public string[] patientValuables { get; set; }
        public string patientValuablesLocation { get; set; }
        public string previousServiceDate { get; set; }
        public string previousTreatmentDate { get; set; }
        public Priorpendinglocation priorPendingLocation { get; set; }
        public string purgeStatusCode { get; set; }
        public string purgeStatusDate { get; set; }
        public string recurringServiceCode { get; set; }
        public Referralsourcecode referralSourceCode { get; set; }
        public string retentionIndicator { get; set; }
        public string signatureOnFileDate { get; set; }
        public string specialProgramCode { get; set; }
        public Transferreason transferReason { get; set; }
        public string visitDescription { get; set; }
        public string visitPriorityCode { get; set; }
        public string visitProtectionIndicator { get; set; }
        public string visitPublicityCode { get; set; }
        public string visitUserCode { get; set; }
    }

    public class Accommodationcode
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Admitreason
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Priorpendinglocation
    {
        public string bed { get; set; }
        public string building { get; set; }
        public Facility5 facility { get; set; }
        public string floor { get; set; }
        public string locationDescription { get; set; }
        public string locationStatus { get; set; }
        public string personLocationType { get; set; }
        public string pointOfCare { get; set; }
        public string room { get; set; }
    }

    public class Facility5
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Referralsourcecode
    {
        public Assigningauthority13 assigningAuthority { get; set; }
        public Assigningfacility13 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string degree { get; set; }
        public string firstName { get; set; }
        public string id { get; set; }
        public string identifierCheckDigit { get; set; }
        public string identifierTypeCode { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string sourceTable { get; set; }
        public string suffix { get; set; }
    }

    public class Assigningauthority13
    {
        public string id { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility13
    {
        public string id { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Transferreason
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Clinicorganizationname
    {
        public Assigningauthority14 assigningAuthority { get; set; }
        public Assigningfacility14 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string idNumber { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
        public string organizationName { get; set; }
        public string organizationNameTypeCode { get; set; }
    }

    public class Assigningauthority14
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility14
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Admittingdoctor
    {
        public Assigningauthority15 assigningAuthority { get; set; }
        public Assigningfacility15 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string degree { get; set; }
        public string firstName { get; set; }
        public string id { get; set; }
        public string identifierCheckDigit { get; set; }
        public string identifierTypeCode { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string sourceTable { get; set; }
        public string suffix { get; set; }
    }

    public class Assigningauthority15
    {
        public string id { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility15
    {
        public string id { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Attendingdoctor
    {
        public Assigningauthority16 assigningAuthority { get; set; }
        public Assigningfacility16 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string degree { get; set; }
        public string firstName { get; set; }
        public string id { get; set; }
        public string identifierCheckDigit { get; set; }
        public string identifierTypeCode { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string sourceTable { get; set; }
        public string suffix { get; set; }
    }

    public class Assigningauthority16
    {
        public string id { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility16
    {
        public string id { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Consultingdoctor
    {
        public Assigningauthority17 assigningAuthority { get; set; }
        public Assigningfacility17 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string degree { get; set; }
        public string firstName { get; set; }
        public string id { get; set; }
        public string identifierCheckDigit { get; set; }
        public string identifierTypeCode { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string sourceTable { get; set; }
        public string suffix { get; set; }
    }

    public class Assigningauthority17
    {
        public string id { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility17
    {
        public string id { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Financialclass
    {
        public string effectiveDate { get; set; }
        public string financialClass { get; set; }
    }

    public class Referringdoctor
    {
        public Assigningauthority18 assigningAuthority { get; set; }
        public Assigningfacility18 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string degree { get; set; }
        public string firstName { get; set; }
        public string id { get; set; }
        public string identifierCheckDigit { get; set; }
        public string identifierTypeCode { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string sourceTable { get; set; }
        public string suffix { get; set; }
    }

    public class Assigningauthority18
    {
        public string id { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility18
    {
        public string id { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class ACC
    {
        public Accidentcode accidentCode { get; set; }
        public string accidentDateTime { get; set; }
        public string accidentDeathIndicator { get; set; }
        public string accidentJobRelatedIndicator { get; set; }
        public string accidentLocation { get; set; }
        public Autoaccidentstate autoAccidentState { get; set; }
    }

    public class Accidentcode
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Autoaccidentstate
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class AL1
    {
        public Allergycodemnemonicdescription allergyCodeMnemonicDescription { get; set; }
        public string allergyReaction { get; set; }
        public string allergySeverity { get; set; }
        public string allergyType { get; set; }
        public string identificationDate { get; set; }
        public string setId { get; set; }
    }

    public class Allergycodemnemonicdescription
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class DB1
    {
        public string disabilityEndDate { get; set; }
        public string disabilityReturnToWorkDate { get; set; }
        public string disabilityStartDate { get; set; }
        public string disabilityUnableToWorkDate { get; set; }
        public string disabledIndicator { get; set; }
        public string disabledPersonCode { get; set; }
        public Disabledpersonidentifier[] disabledPersonIdentifier { get; set; }
        public string setID { get; set; }
    }

    public class Disabledpersonidentifier
    {
        public Assigningauthority19 assigningAuthority { get; set; }
        public Assigningfacility19 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string id { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
    }

    public class Assigningauthority19
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility19
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class DG1
    {
        public string attestationDateTime { get; set; }
        public string confidentialIndicator { get; set; }
        public Diagnosingclinician[] diagnosingClinician { get; set; }
        public string diagnosisClassification { get; set; }
        public Diagnosiscode diagnosisCode { get; set; }
        public string diagnosisCodingMethod { get; set; }
        public string diagnosisDateTime { get; set; }
        public string diagnosisDescription { get; set; }
        public string diagnosisPriority { get; set; }
        public string diagnosisType { get; set; }
        public Diagnosticrelatedgroup diagnosticRelatedGroup { get; set; }
        public string drgApprovalIndicator { get; set; }
        public string drgGrouperReviewCode { get; set; }
        public string grouperVersionAndType { get; set; }
        public Majordiagnosticcategory majorDiagnosticCategory { get; set; }
        public Outliercost outlierCost { get; set; }
        public string outlierDays { get; set; }
        public Outliertype outlierType { get; set; }
        public string setId { get; set; }
    }

    public class Diagnosiscode
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Diagnosticrelatedgroup
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Majordiagnosticcategory
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Outliercost
    {
        public string fromValue { get; set; }
        public Price price { get; set; }
        public string priceType { get; set; }
        public Rangetype rangeType { get; set; }
        public string rangeUnits { get; set; }
        public string toValue { get; set; }
    }

    public class Price
    {
        public string denomination { get; set; }
        public string quantity { get; set; }
    }

    public class Rangetype
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Outliertype
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Diagnosingclinician
    {
        public Assigningauthority20 assigningAuthority { get; set; }
        public Assigningfacility20 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string degree { get; set; }
        public string firstName { get; set; }
        public string id { get; set; }
        public string identifierCheckDigit { get; set; }
        public string identifierTypeCode { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string sourceTable { get; set; }
        public string suffix { get; set; }
    }

    public class Assigningauthority20
    {
        public string id { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility20
    {
        public string id { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class DRG
    {
        public PR1[] PR1 { get; set; }
        public string confidentialIndicator { get; set; }
        public Diagnosticrelatedgroup1 diagnosticRelatedGroup { get; set; }
        public string drgApprovalIndicator { get; set; }
        public string drgAssignedDateTime { get; set; }
        public string drgGrouperReviewCode { get; set; }
        public string drgPayor { get; set; }
        public Outliercost1 outlierCost { get; set; }
        public string outlierDays { get; set; }
        public Outlierreimbursement outlierReimbursement { get; set; }
        public Outliertype1 outlierType { get; set; }
    }

    public class Diagnosticrelatedgroup1
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Outliercost1
    {
        public string fromValue { get; set; }
        public Price1 price { get; set; }
        public string priceType { get; set; }
        public Rangetype1 rangeType { get; set; }
        public string rangeUnits { get; set; }
        public string toValue { get; set; }
    }

    public class Price1
    {
        public string denomination { get; set; }
        public string quantity { get; set; }
    }

    public class Rangetype1
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Outlierreimbursement
    {
        public string fromValue { get; set; }
        public Price2 price { get; set; }
        public string priceType { get; set; }
        public Rangetype2 rangeType { get; set; }
        public string rangeUnits { get; set; }
        public string toValue { get; set; }
    }

    public class Price2
    {
        public string denomination { get; set; }
        public string quantity { get; set; }
    }

    public class Rangetype2
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Outliertype1
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class PR1
    {
        public ROL[] ROL { get; set; }
        public string anesthesiaCode { get; set; }
        public string anesthesiaMinutes { get; set; }
        public Anesthesiologist[] anesthesiologist { get; set; }
        public Associateddiagnosiscode associatedDiagnosisCode { get; set; }
        public Consentcode consentCode { get; set; }
        public Procedurecode procedureCode { get; set; }
        public string procedureCodingMethod { get; set; }
        public string procedureDateTime { get; set; }
        public string procedureDescription { get; set; }
        public string procedureFunctionalType { get; set; }
        public string procedureMinutes { get; set; }
        public Procedurepractitioner[] procedurePractitioner { get; set; }
        public string procedurePriority { get; set; }
        public string setId { get; set; }
        public Surgeon[] surgeon { get; set; }
    }

    public class Associateddiagnosiscode
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Consentcode
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Procedurecode
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class ROL
    {
        public string actionCode { get; set; }
        public Role role { get; set; }
        public Roleactionreason roleActionReason { get; set; }
        public string roleBeginDateTime { get; set; }
        public Roleduration roleDuration { get; set; }
        public string roleEndDateTime { get; set; }
        public Roleinstanceid roleInstanceID { get; set; }
        public Roleperson rolePerson { get; set; }
    }

    public class Role
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Roleactionreason
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Roleduration
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Roleinstanceid
    {
        public string id { get; set; }
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Roleperson
    {
        public Assigningauthority21 assigningAuthority { get; set; }
        public Assigningfacility21 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string degree { get; set; }
        public string firstName { get; set; }
        public string id { get; set; }
        public string identifierCheckDigit { get; set; }
        public string identifierTypeCode { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string sourceTable { get; set; }
        public string suffix { get; set; }
    }

    public class Assigningauthority21
    {
        public string id { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility21
    {
        public string id { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Anesthesiologist
    {
        public Assigningauthority22 assigningAuthority { get; set; }
        public Assigningfacility22 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string degree { get; set; }
        public string firstName { get; set; }
        public string id { get; set; }
        public string identifierCheckDigit { get; set; }
        public string identifierTypeCode { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string sourceTable { get; set; }
        public string suffix { get; set; }
    }

    public class Assigningauthority22
    {
        public string id { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility22
    {
        public string id { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Procedurepractitioner
    {
        public Assigningauthority23 assigningAuthority { get; set; }
        public Assigningfacility23 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string degree { get; set; }
        public string firstName { get; set; }
        public string id { get; set; }
        public string identifierCheckDigit { get; set; }
        public string identifierTypeCode { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string sourceTable { get; set; }
        public string suffix { get; set; }
    }

    public class Assigningauthority23
    {
        public string id { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility23
    {
        public string id { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Surgeon
    {
        public Assigningauthority24 assigningAuthority { get; set; }
        public Assigningfacility24 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string degree { get; set; }
        public string firstName { get; set; }
        public string id { get; set; }
        public string identifierCheckDigit { get; set; }
        public string identifierTypeCode { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string sourceTable { get; set; }
        public string suffix { get; set; }
    }

    public class Assigningauthority24
    {
        public string id { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility24
    {
        public string id { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class GT1
    {
        public string ambulatoryStatus { get; set; }
        public string citizenship { get; set; }
        public Contactpersonsname[] contactPersonsName { get; set; }
        public Contactpersonstelephonenumber[] contactPersonsTelephoneNumber { get; set; }
        public Contactreason contactReason { get; set; }
        public string contactRelationship { get; set; }
        public string employmentStopDate { get; set; }
        public string ethnicGroup { get; set; }
        public Guarantoraddress[] guarantorAddress { get; set; }
        public string guarantorBillingHoldFlag { get; set; }
        public Guarantorchargeadjustmentcode guarantorChargeAdjustmentCode { get; set; }
        public Guarantorcreditratingcode guarantorCreditRatingCode { get; set; }
        public string guarantorDateBegin { get; set; }
        public string guarantorDateEnd { get; set; }
        public string guarantorDatetimeOfBirth { get; set; }
        public string guarantorDeathDateAndTime { get; set; }
        public string guarantorDeathFlag { get; set; }
        public Guarantoremployeeidnumber[] guarantorEmployeeIDNumber { get; set; }
        public Guarantoremployeraddress[] guarantorEmployerAddress { get; set; }
        public Guarantoremployeridnumber[] guarantorEmployerIDNumber { get; set; }
        public Guarantoremployername[] guarantorEmployerName { get; set; }
        public Guarantoremployerphonenumber[] guarantorEmployerPhoneNumber { get; set; }
        public Guarantoremployersorganization[] guarantorEmployersOrganization { get; set; }
        public string guarantorEmploymentStatus { get; set; }
        public Guarantorfinancialclass guarantorFinancialClass { get; set; }
        public string guarantorHireEffectiveDate { get; set; }
        public Guarantorhouseholdannualincome guarantorHouseholdAnnualIncome { get; set; }
        public string guarantorHouseholdSize { get; set; }
        public string guarantorMaritalStatusCode { get; set; }
        public Guarantorname[] guarantorName { get; set; }
        public Guarantornumber[] guarantorNumber { get; set; }
        public Guarantororganizationname[] guarantorOrganizationName { get; set; }
        public Guarantorphnumbusiness[] guarantorPhNumBusiness { get; set; }
        public Guarantorphnumhome[] guarantorPhNumHome { get; set; }
        public string guarantorPriority { get; set; }
        public string guarantorRace { get; set; }
        public string guarantorRelationship { get; set; }
        public string guarantorSSN { get; set; }
        public string guarantorSex { get; set; }
        public Guarantorspousename[] guarantorSpouseName { get; set; }
        public string guarantorType { get; set; }
        public string handicap { get; set; }
        public Jobcodeclass jobCodeClass { get; set; }
        public string jobStatus { get; set; }
        public string jobTitle { get; set; }
        public string livingArrangement { get; set; }
        public string livingDependency { get; set; }
        public Mothersmaidenname1 mothersMaidenName { get; set; }
        public Nationality1 nationality { get; set; }
        public Primarylanguage1 primaryLanguage { get; set; }
        public string protectionIndicator { get; set; }
        public Publicityindicator1 publicityIndicator { get; set; }
        public string religion { get; set; }
        public string setId { get; set; }
        public string studentIndicator { get; set; }
    }

    public class Contactreason
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Guarantorchargeadjustmentcode
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Guarantorcreditratingcode
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Guarantorfinancialclass
    {
        public string effectiveDate { get; set; }
        public string financialClass { get; set; }
    }

    public class Guarantorhouseholdannualincome
    {
        public string fromValue { get; set; }
        public Price3 price { get; set; }
        public string priceType { get; set; }
        public Rangetype3 rangeType { get; set; }
        public string rangeUnits { get; set; }
        public string toValue { get; set; }
    }

    public class Price3
    {
        public string denomination { get; set; }
        public string quantity { get; set; }
    }

    public class Rangetype3
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Jobcodeclass
    {
        public string jobClass { get; set; }
        public string jobCode { get; set; }
    }

    public class Mothersmaidenname1
    {
        public string degree { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class Nationality1
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Primarylanguage1
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Publicityindicator1
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Contactpersonsname
    {
        public string degree { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class Contactpersonstelephonenumber
    {
        public string areaCityCode { get; set; }
        public string countryCode { get; set; }
        public string emailAddress { get; set; }
        public string extension { get; set; }
        public string number { get; set; }
        public string phoneNumber { get; set; }
        public string telecommunicationEquipmentType { get; set; }
        public string telecommunicationUseCode { get; set; }
        public string text { get; set; }
    }

    public class Guarantoraddress
    {
        public string addressType { get; set; }
        public string censusTract { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string countyOrParishCode { get; set; }
        public string otherDesignation { get; set; }
        public string otherGeographicDesignation { get; set; }
        public string stateOrProvince { get; set; }
        public string streetAddress { get; set; }
        public string zip { get; set; }
    }

    public class Guarantoremployeeidnumber
    {
        public Assigningauthority25 assigningAuthority { get; set; }
        public Assigningfacility25 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string id { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
    }

    public class Assigningauthority25
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility25
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Guarantoremployeraddress
    {
        public string addressType { get; set; }
        public string censusTract { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string countyOrParishCode { get; set; }
        public string otherDesignation { get; set; }
        public string otherGeographicDesignation { get; set; }
        public string stateOrProvince { get; set; }
        public string streetAddress { get; set; }
        public string zip { get; set; }
    }

    public class Guarantoremployeridnumber
    {
        public Assigningauthority26 assigningAuthority { get; set; }
        public Assigningfacility26 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string id { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
    }

    public class Assigningauthority26
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility26
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Guarantoremployername
    {
        public string degree { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class Guarantoremployerphonenumber
    {
        public string areaCityCode { get; set; }
        public string countryCode { get; set; }
        public string emailAddress { get; set; }
        public string extension { get; set; }
        public string number { get; set; }
        public string phoneNumber { get; set; }
        public string telecommunicationEquipmentType { get; set; }
        public string telecommunicationUseCode { get; set; }
        public string text { get; set; }
    }

    public class Guarantoremployersorganization
    {
        public Assigningauthority27 assigningAuthority { get; set; }
        public Assigningfacility27 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string idNumber { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
        public string organizationName { get; set; }
        public string organizationNameTypeCode { get; set; }
    }

    public class Assigningauthority27
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility27
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Guarantorname
    {
        public string degree { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class Guarantornumber
    {
        public Assigningauthority28 assigningAuthority { get; set; }
        public Assigningfacility28 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string id { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
    }

    public class Assigningauthority28
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility28
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Guarantororganizationname
    {
        public Assigningauthority29 assigningAuthority { get; set; }
        public Assigningfacility29 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string idNumber { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
        public string organizationName { get; set; }
        public string organizationNameTypeCode { get; set; }
    }

    public class Assigningauthority29
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility29
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Guarantorphnumbusiness
    {
        public string areaCityCode { get; set; }
        public string countryCode { get; set; }
        public string emailAddress { get; set; }
        public string extension { get; set; }
        public string number { get; set; }
        public string phoneNumber { get; set; }
        public string telecommunicationEquipmentType { get; set; }
        public string telecommunicationUseCode { get; set; }
        public string text { get; set; }
    }

    public class Guarantorphnumhome
    {
        public string areaCityCode { get; set; }
        public string countryCode { get; set; }
        public string emailAddress { get; set; }
        public string extension { get; set; }
        public string number { get; set; }
        public string phoneNumber { get; set; }
        public string telecommunicationEquipmentType { get; set; }
        public string telecommunicationUseCode { get; set; }
        public string text { get; set; }
    }

    public class Guarantorspousename
    {
        public string degree { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class IN1
    {
        public IN2[] IN2 { get; set; }
        public IN3[] IN3 { get; set; }
        public string assignmentOfBenefits { get; set; }
        public Authorizationinformation authorizationInformation { get; set; }
        public string billingStatus { get; set; }
        public Companyaddress[] companyAddress { get; set; }
        public Companycontactperson[] companyContactPerson { get; set; }
        public Companyid[] companyId { get; set; }
        public Companyname[] companyName { get; set; }
        public Companyphonenumber[] companyPhoneNumber { get; set; }
        public string companyPlanCode { get; set; }
        public string coordinationOfBenefits { get; set; }
        public string coverageType { get; set; }
        public string delayBeforeLrDay { get; set; }
        public Groupempid[] groupEmpId { get; set; }
        public Groupempname[] groupEmpName { get; set; }
        public Groupname[] groupName { get; set; }
        public string groupNumber { get; set; }
        public string handicap { get; set; }
        public Insuredaddress[] insuredAddress { get; set; }
        public string insuredDob { get; set; }
        public Insuredemployeraddress[] insuredEmployerAddress { get; set; }
        public Insuredemploymentstatus insuredEmploymentStatus { get; set; }
        public Insuredidnumber[] insuredIdNumber { get; set; }
        public Insuredname[] insuredName { get; set; }
        public string insuredRelationshipToPatient { get; set; }
        public string insuredSex { get; set; }
        public string lifetimeReserveDays { get; set; }
        public string noticeOfAdmissionDate { get; set; }
        public string noticeOfAdmissionFlag { get; set; }
        public string planEffectiveDate { get; set; }
        public string planExpirationDate { get; set; }
        public Planid planId { get; set; }
        public string planType { get; set; }
        public Policydeductible policyDeductible { get; set; }
        public Policylimitamount policyLimitAmount { get; set; }
        public string policyLimitDays { get; set; }
        public string policyNumber { get; set; }
        public string preAdmitCert { get; set; }
        public string priorInsurancePlanId { get; set; }
        public string releaseInformationCode { get; set; }
        public string reportOfEligibilityDate { get; set; }
        public string reportOfEligibilityFlag { get; set; }
        public Roomrateprivate roomRatePrivate { get; set; }
        public Roomratesemiprivate roomRateSemiPrivate { get; set; }
        public string setId { get; set; }
        public string typeOfAgreementCode { get; set; }
        public Verificationby verificationBy { get; set; }
        public string verificationDateTime { get; set; }
        public string verificationStatus { get; set; }
    }

    public class Authorizationinformation
    {
        public string authorizationNumber { get; set; }
        public string date { get; set; }
        public string source { get; set; }
    }

    public class Insuredemploymentstatus
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Planid
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Policydeductible
    {
        public string fromValue { get; set; }
        public Price4 price { get; set; }
        public string priceType { get; set; }
        public Rangetype4 rangeType { get; set; }
        public string rangeUnits { get; set; }
        public string toValue { get; set; }
    }

    public class Price4
    {
        public string denomination { get; set; }
        public string quantity { get; set; }
    }

    public class Rangetype4
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Policylimitamount
    {
        public string fromValue { get; set; }
        public Price5 price { get; set; }
        public string priceType { get; set; }
        public Rangetype5 rangeType { get; set; }
        public string rangeUnits { get; set; }
        public string toValue { get; set; }
    }

    public class Price5
    {
        public string denomination { get; set; }
        public string quantity { get; set; }
    }

    public class Rangetype5
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Roomrateprivate
    {
        public string fromValue { get; set; }
        public Price6 price { get; set; }
        public string priceType { get; set; }
        public Rangetype6 rangeType { get; set; }
        public string rangeUnits { get; set; }
        public string toValue { get; set; }
    }

    public class Price6
    {
        public string denomination { get; set; }
        public string quantity { get; set; }
    }

    public class Rangetype6
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Roomratesemiprivate
    {
        public string fromValue { get; set; }
        public Price7 price { get; set; }
        public string priceType { get; set; }
        public Rangetype7 rangeType { get; set; }
        public string rangeUnits { get; set; }
        public string toValue { get; set; }
    }

    public class Price7
    {
        public string denomination { get; set; }
        public string quantity { get; set; }
    }

    public class Rangetype7
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Verificationby
    {
        public Assigningauthority30 assigningAuthority { get; set; }
        public Assigningfacility30 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string degree { get; set; }
        public string firstName { get; set; }
        public string id { get; set; }
        public string identifierCheckDigit { get; set; }
        public string identifierTypeCode { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string sourceTable { get; set; }
        public string suffix { get; set; }
    }

    public class Assigningauthority30
    {
        public string id { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility30
    {
        public string id { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class IN2
    {
        public string ambulatoryStatus { get; set; }
        public string babyCoverage { get; set; }
        public string bloodDeductible { get; set; }
        public string champusIdNumber { get; set; }
        public string champusNonAvailCertOnFile { get; set; }
        public string champusOrganization { get; set; }
        public string champusRankGrade { get; set; }
        public string champusRetireDate { get; set; }
        public string champusService { get; set; }
        public Champussponsorname[] champusSponsorName { get; set; }
        public string champusStation { get; set; }
        public string champusStatus { get; set; }
        public string citizenship { get; set; }
        public string combineBabyBill { get; set; }
        public string copayLimitFlag { get; set; }
        public Dailydeductible dailyDeductible { get; set; }
        public Dependentofchampusrecipient dependentOfChampusRecipient { get; set; }
        public string eligibilitySource { get; set; }
        public Employercontactpersonname[] employerContactPersonName { get; set; }
        public Employercontactpersonphone[] employerContactPersonPhone { get; set; }
        public string employerContactReason { get; set; }
        public string employerInfoData { get; set; }
        public string ethnicGroup { get; set; }
        public string guarantorRelationshipToInsured { get; set; }
        public Hcfapatientrelationshiptoinsured hcfaPatientRelationshipToInsured { get; set; }
        public Insurancecocontactphone insuranceCoContactPhone { get; set; }
        public string insuranceCoContactReason { get; set; }
        public Insuredemployeeid[] insuredEmployeeId { get; set; }
        public Insuredemployername[] insuredEmployerName { get; set; }
        public Insuredemployerorganizationnameandid[] insuredEmployerOrganizationNameAndID { get; set; }
        public Insuredemployerphone[] insuredEmployerPhone { get; set; }
        public string insuredEmploymentStartDate { get; set; }
        public string insuredEmploymentStopDate { get; set; }
        public Insuredhomephone[] insuredHomePhone { get; set; }
        public Insuredorganizationnameandid[] insuredOrganizationNameAndID { get; set; }
        public string insuredSSN { get; set; }
        public Insuredscontactpersonname[] insuredsContactPersonName { get; set; }
        public Insuredscontactpersonphone[] insuredsContactPersonPhone { get; set; }
        public string[] insuredsContactReason { get; set; }
        public Jobcodeclass1 jobCodeClass { get; set; }
        public string jobStatus { get; set; }
        public string jobTitle { get; set; }
        public string livingArrangement { get; set; }
        public string livingDependency { get; set; }
        public string[] mailClaimParty { get; set; }
        //public Maritalstatu maritalStatus { get; set; }
        public string[] maritalStatus { get; set; }
        public Medicaidcasename[] medicaidCaseName { get; set; }
        public string medicaidCaseNumber { get; set; }
        public string medicareHealthInsCardNumber { get; set; }
        public Militaryhandicappedprogram militaryHandicappedProgram { get; set; }
        public Mothermaidenname motherMaidenName { get; set; }
        public Nationality2 nationality { get; set; }
        public string[] nonCoveredInsuranceCode { get; set; }
        public Patientmembernumber[] patientMemberNumber { get; set; }
        public Payorid[] payorId { get; set; }
        public Payorsubscriberid[] payorSubscriberId { get; set; }
        public string policyScope { get; set; }
        public string policySource { get; set; }
        public Policytypeamount[] policyTypeAmount { get; set; }
        public Primarylanguage2 primaryLanguage { get; set; }
        public string protectionIndicator { get; set; }
        public Publicityindicator2 publicityIndicator { get; set; }
        public string race { get; set; }
        public string relationshipToPersonStartDate { get; set; }
        public string[] relationshipToPersonStopDate { get; set; }
        public string religion { get; set; }
        public Roomcoveragetypeamount[] roomCoverageTypeAmount { get; set; }
        public Specialcoverageapprovalname[] specialCoverageApprovalName { get; set; }
        public string specialCoverageApprovalTitle { get; set; }
        public string stoplossLimitFlag { get; set; }
        public string studentIndicator { get; set; }
        public string suspendFlag { get; set; }
    }

    public class Dailydeductible
    {
        public string amount { get; set; }
        public string delayDays { get; set; }
        public string numberOfDays { get; set; }
    }

    public class Dependentofchampusrecipient
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Hcfapatientrelationshiptoinsured
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Insurancecocontactphone
    {
        public string areaCityCode { get; set; }
        public string countryCode { get; set; }
        public string emailAddress { get; set; }
        public string extension { get; set; }
        public string number { get; set; }
        public string phoneNumber { get; set; }
        public string telecommunicationEquipmentType { get; set; }
        public string telecommunicationUseCode { get; set; }
        public string text { get; set; }
    }

    public class Jobcodeclass1
    {
        public string jobClass { get; set; }
        public string jobCode { get; set; }
    }

    public class Militaryhandicappedprogram
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Mothermaidenname
    {
        public string degree { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class Nationality2
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Patientmembernumber
    {
        public Assigningauthority31 assigningAuthority { get; set; }
        public Assigningfacility31 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string id { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
    }

    public class Assigningauthority31
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility31
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Primarylanguage2
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Publicityindicator2
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Champussponsorname
    {
        public string degree { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class Employercontactpersonname
    {
        public string degree { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class Employercontactpersonphone
    {
        public string areaCityCode { get; set; }
        public string countryCode { get; set; }
        public string emailAddress { get; set; }
        public string extension { get; set; }
        public string number { get; set; }
        public string phoneNumber { get; set; }
        public string telecommunicationEquipmentType { get; set; }
        public string telecommunicationUseCode { get; set; }
        public string text { get; set; }
    }

    public class Insuredemployeeid
    {
        public Assigningauthority32 assigningAuthority { get; set; }
        public Assigningfacility32 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string id { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
    }

    public class Assigningauthority32
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility32
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Insuredemployername
    {
        public Assigningauthority33 assigningAuthority { get; set; }
        public Assigningfacility33 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string degree { get; set; }
        public string firstName { get; set; }
        public string id { get; set; }
        public string identifierCheckDigit { get; set; }
        public string identifierTypeCode { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string sourceTable { get; set; }
        public string suffix { get; set; }
    }

    public class Assigningauthority33
    {
        public string id { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility33
    {
        public string id { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Insuredemployerorganizationnameandid
    {
        public Assigningauthority34 assigningAuthority { get; set; }
        public Assigningfacility34 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string idNumber { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
        public string organizationName { get; set; }
        public string organizationNameTypeCode { get; set; }
    }

    public class Assigningauthority34
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility34
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Insuredemployerphone
    {
        public string areaCityCode { get; set; }
        public string countryCode { get; set; }
        public string emailAddress { get; set; }
        public string extension { get; set; }
        public string number { get; set; }
        public string phoneNumber { get; set; }
        public string telecommunicationEquipmentType { get; set; }
        public string telecommunicationUseCode { get; set; }
        public string text { get; set; }
    }

    public class Insuredhomephone
    {
        public string areaCityCode { get; set; }
        public string countryCode { get; set; }
        public string emailAddress { get; set; }
        public string extension { get; set; }
        public string number { get; set; }
        public string phoneNumber { get; set; }
        public string telecommunicationEquipmentType { get; set; }
        public string telecommunicationUseCode { get; set; }
        public string text { get; set; }
    }

    public class Insuredorganizationnameandid
    {
        public Assigningauthority35 assigningAuthority { get; set; }
        public Assigningfacility35 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string idNumber { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
        public string organizationName { get; set; }
        public string organizationNameTypeCode { get; set; }
    }

    public class Assigningauthority35
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility35
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Insuredscontactpersonname
    {
        public string degree { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class Insuredscontactpersonphone
    {
        public string areaCityCode { get; set; }
        public string countryCode { get; set; }
        public string emailAddress { get; set; }
        public string extension { get; set; }
        public string number { get; set; }
        public string phoneNumber { get; set; }
        public string telecommunicationEquipmentType { get; set; }
        public string telecommunicationUseCode { get; set; }
        public string text { get; set; }
    }

    public class Maritalstatu
    {
    }

    public class Medicaidcasename
    {
        public string degree { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class Payorid
    {
        public Assigningauthority36 assigningAuthority { get; set; }
        public Assigningfacility36 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string id { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
    }

    public class Assigningauthority36
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility36
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Payorsubscriberid
    {
        public Assigningauthority37 assigningAuthority { get; set; }
        public Assigningfacility37 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string id { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
    }

    public class Assigningauthority37
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility37
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Policytypeamount
    {
        public string amount { get; set; }
        public string amountClass { get; set; }
        public string policyType { get; set; }
    }

    public class Roomcoveragetypeamount
    {
        public string amountType { get; set; }
        public string coverageAmount { get; set; }
        public string roomType { get; set; }
    }

    public class Specialcoverageapprovalname
    {
        public string degree { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class IN3
    {
        public string ambulatoryStatus { get; set; }
        public string babyCoverage { get; set; }
        public string bloodDeductible { get; set; }
        public string champusIdNumber { get; set; }
        public string champusNonAvailCertOnFile { get; set; }
        public string champusOrganization { get; set; }
        public string champusRankGrade { get; set; }
        public string champusRetireDate { get; set; }
        public string champusService { get; set; }
        public Champussponsorname1[] champusSponsorName { get; set; }
        public string champusStation { get; set; }
        public string champusStatus { get; set; }
        public string citizenship { get; set; }
        public string combineBabyBill { get; set; }
        public string copayLimitFlag { get; set; }
        public Dailydeductible1 dailyDeductible { get; set; }
        public Dependentofchampusrecipient1 dependentOfChampusRecipient { get; set; }
        public string eligibilitySource { get; set; }
        public Employercontactpersonname1[] employerContactPersonName { get; set; }
        public Employercontactpersonphone1[] employerContactPersonPhone { get; set; }
        public string employerContactReason { get; set; }
        public string employerInfoData { get; set; }
        public string ethnicGroup { get; set; }
        public string guarantorRelationshipToInsured { get; set; }
        public Hcfapatientrelationshiptoinsured1 hcfaPatientRelationshipToInsured { get; set; }
        public Insurancecocontactphone1 insuranceCoContactPhone { get; set; }
        public string insuranceCoContactReason { get; set; }
        public Insuredemployeeid1[] insuredEmployeeId { get; set; }
        public Insuredemployername1[] insuredEmployerName { get; set; }
        public Insuredemployerorganizationnameandid1[] insuredEmployerOrganizationNameAndID { get; set; }
        public Insuredemployerphone1[] insuredEmployerPhone { get; set; }
        public string insuredEmploymentStartDate { get; set; }
        public string insuredEmploymentStopDate { get; set; }
        public Insuredhomephone1[] insuredHomePhone { get; set; }
        public Insuredorganizationnameandid1[] insuredOrganizationNameAndID { get; set; }
        public string insuredSSN { get; set; }
        public Insuredscontactpersonname1[] insuredsContactPersonName { get; set; }
        public Insuredscontactpersonphone1[] insuredsContactPersonPhone { get; set; }
        public string[] insuredsContactReason { get; set; }
        public Jobcodeclass2 jobCodeClass { get; set; }
        public string jobStatus { get; set; }
        public string jobTitle { get; set; }
        public string livingArrangement { get; set; }
        public string livingDependency { get; set; }
        public string[] mailClaimParty { get; set; }
        public Maritalstatu1[] maritalStatus { get; set; }
        public Medicaidcasename1[] medicaidCaseName { get; set; }
        public string medicaidCaseNumber { get; set; }
        public string medicareHealthInsCardNumber { get; set; }
        public Militaryhandicappedprogram1 militaryHandicappedProgram { get; set; }
        public Mothermaidenname1 motherMaidenName { get; set; }
        public Nationality3 nationality { get; set; }
        public string[] nonCoveredInsuranceCode { get; set; }
        public Patientmembernumber1 patientMemberNumber { get; set; }
        public Payorid1[] payorId { get; set; }
        public Payorsubscriberid1[] payorSubscriberId { get; set; }
        public string policyScope { get; set; }
        public string policySource { get; set; }
        public Policytypeamount1[] policyTypeAmount { get; set; }
        public Primarylanguage3 primaryLanguage { get; set; }
        public string protectionIndicator { get; set; }
        public Publicityindicator3 publicityIndicator { get; set; }
        public string race { get; set; }
        public string relationshipToPersonStartDate { get; set; }
        public string[] relationshipToPersonStopDate { get; set; }
        public string religion { get; set; }
        public Roomcoveragetypeamount1[] roomCoverageTypeAmount { get; set; }
        public Specialcoverageapprovalname1[] specialCoverageApprovalName { get; set; }
        public string specialCoverageApprovalTitle { get; set; }
        public string stoplossLimitFlag { get; set; }
        public string studentIndicator { get; set; }
        public string suspendFlag { get; set; }
    }

    public class Dailydeductible1
    {
        public string amount { get; set; }
        public string delayDays { get; set; }
        public string numberOfDays { get; set; }
    }

    public class Dependentofchampusrecipient1
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Hcfapatientrelationshiptoinsured1
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Insurancecocontactphone1
    {
        public string areaCityCode { get; set; }
        public string countryCode { get; set; }
        public string emailAddress { get; set; }
        public string extension { get; set; }
        public string number { get; set; }
        public string phoneNumber { get; set; }
        public string telecommunicationEquipmentType { get; set; }
        public string telecommunicationUseCode { get; set; }
        public string text { get; set; }
    }

    public class Jobcodeclass2
    {
        public string jobClass { get; set; }
        public string jobCode { get; set; }
    }

    public class Militaryhandicappedprogram1
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Mothermaidenname1
    {
        public string degree { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class Nationality3
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Patientmembernumber1
    {
        public Assigningauthority38 assigningAuthority { get; set; }
        public Assigningfacility38 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string id { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
    }

    public class Assigningauthority38
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility38
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Primarylanguage3
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Publicityindicator3
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Champussponsorname1
    {
        public string degree { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class Employercontactpersonname1
    {
        public string degree { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class Employercontactpersonphone1
    {
        public string areaCityCode { get; set; }
        public string countryCode { get; set; }
        public string emailAddress { get; set; }
        public string extension { get; set; }
        public string number { get; set; }
        public string phoneNumber { get; set; }
        public string telecommunicationEquipmentType { get; set; }
        public string telecommunicationUseCode { get; set; }
        public string text { get; set; }
    }

    public class Insuredemployeeid1
    {
        public Assigningauthority39 assigningAuthority { get; set; }
        public Assigningfacility39 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string id { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
    }

    public class Assigningauthority39
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility39
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Insuredemployername1
    {
        public Assigningauthority40 assigningAuthority { get; set; }
        public Assigningfacility40 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string degree { get; set; }
        public string firstName { get; set; }
        public string id { get; set; }
        public string identifierCheckDigit { get; set; }
        public string identifierTypeCode { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string sourceTable { get; set; }
        public string suffix { get; set; }
    }

    public class Assigningauthority40
    {
        public string id { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility40
    {
        public string id { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Insuredemployerorganizationnameandid1
    {
        public Assigningauthority41 assigningAuthority { get; set; }
        public Assigningfacility41 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string idNumber { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
        public string organizationName { get; set; }
        public string organizationNameTypeCode { get; set; }
    }

    public class Assigningauthority41
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility41
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Insuredemployerphone1
    {
        public string areaCityCode { get; set; }
        public string countryCode { get; set; }
        public string emailAddress { get; set; }
        public string extension { get; set; }
        public string number { get; set; }
        public string phoneNumber { get; set; }
        public string telecommunicationEquipmentType { get; set; }
        public string telecommunicationUseCode { get; set; }
        public string text { get; set; }
    }

    public class Insuredhomephone1
    {
        public string areaCityCode { get; set; }
        public string countryCode { get; set; }
        public string emailAddress { get; set; }
        public string extension { get; set; }
        public string number { get; set; }
        public string phoneNumber { get; set; }
        public string telecommunicationEquipmentType { get; set; }
        public string telecommunicationUseCode { get; set; }
        public string text { get; set; }
    }

    public class Insuredorganizationnameandid1
    {
        public Assigningauthority42 assigningAuthority { get; set; }
        public Assigningfacility42 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string idNumber { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
        public string organizationName { get; set; }
        public string organizationNameTypeCode { get; set; }
    }

    public class Assigningauthority42
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility42
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Insuredscontactpersonname1
    {
        public string degree { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class Insuredscontactpersonphone1
    {
        public string areaCityCode { get; set; }
        public string countryCode { get; set; }
        public string emailAddress { get; set; }
        public string extension { get; set; }
        public string number { get; set; }
        public string phoneNumber { get; set; }
        public string telecommunicationEquipmentType { get; set; }
        public string telecommunicationUseCode { get; set; }
        public string text { get; set; }
    }

    public class Maritalstatu1
    {
    }

    public class Medicaidcasename1
    {
        public string degree { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class Payorid1
    {
        public Assigningauthority43 assigningAuthority { get; set; }
        public Assigningfacility43 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string id { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
    }

    public class Assigningauthority43
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility43
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Payorsubscriberid1
    {
        public Assigningauthority44 assigningAuthority { get; set; }
        public Assigningfacility44 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string id { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
    }

    public class Assigningauthority44
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility44
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Policytypeamount1
    {
        public string amount { get; set; }
        public string amountClass { get; set; }
        public string policyType { get; set; }
    }

    public class Roomcoveragetypeamount1
    {
        public string amountType { get; set; }
        public string coverageAmount { get; set; }
        public string roomType { get; set; }
    }

    public class Specialcoverageapprovalname1
    {
        public string degree { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class Companyaddress
    {
        public string addressType { get; set; }
        public string censusTract { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string countyOrParishCode { get; set; }
        public string otherDesignation { get; set; }
        public string otherGeographicDesignation { get; set; }
        public string stateOrProvince { get; set; }
        public string streetAddress { get; set; }
        public string zip { get; set; }
    }

    public class Companycontactperson
    {
        public string degree { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class Companyid
    {
        public Assigningauthority45 assigningAuthority { get; set; }
        public Assigningfacility45 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string id { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
    }

    public class Assigningauthority45
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility45
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Companyname
    {
        public Assigningauthority46 assigningAuthority { get; set; }
        public Assigningfacility46 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string idNumber { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
        public string organizationName { get; set; }
        public string organizationNameTypeCode { get; set; }
    }

    public class Assigningauthority46
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility46
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Companyphonenumber
    {
        public string areaCityCode { get; set; }
        public string countryCode { get; set; }
        public string emailAddress { get; set; }
        public string extension { get; set; }
        public string number { get; set; }
        public string phoneNumber { get; set; }
        public string telecommunicationEquipmentType { get; set; }
        public string telecommunicationUseCode { get; set; }
        public string text { get; set; }
    }

    public class Groupempid
    {
        public Assigningauthority47 assigningAuthority { get; set; }
        public Assigningfacility47 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string id { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
    }

    public class Assigningauthority47
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility47
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Groupempname
    {
        public Assigningauthority48 assigningAuthority { get; set; }
        public Assigningfacility48 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string idNumber { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
        public string organizationName { get; set; }
        public string organizationNameTypeCode { get; set; }
    }

    public class Assigningauthority48
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility48
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Groupname
    {
        public Assigningauthority49 assigningAuthority { get; set; }
        public Assigningfacility49 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string idNumber { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
        public string organizationName { get; set; }
        public string organizationNameTypeCode { get; set; }
    }

    public class Assigningauthority49
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility49
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Insuredaddress
    {
        public string addressType { get; set; }
        public string censusTract { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string countyOrParishCode { get; set; }
        public string otherDesignation { get; set; }
        public string otherGeographicDesignation { get; set; }
        public string stateOrProvince { get; set; }
        public string streetAddress { get; set; }
        public string zip { get; set; }
    }

    public class Insuredemployeraddress
    {
        public string addressType { get; set; }
        public string censusTract { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string countyOrParishCode { get; set; }
        public string otherDesignation { get; set; }
        public string otherGeographicDesignation { get; set; }
        public string stateOrProvince { get; set; }
        public string streetAddress { get; set; }
        public string zip { get; set; }
    }

    public class Insuredidnumber
    {
        public Assigningauthority50 assigningAuthority { get; set; }
        public Assigningfacility50 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string id { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
    }

    public class Assigningauthority50
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility50
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Insuredname
    {
        public string degree { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class NK1
    {
        public Address1[] address { get; set; }
        public string[] ambulatoryStatus { get; set; }
        public Businessphone1[] businessPhone { get; set; }
        public string[] citizenship { get; set; }
        public string contactPersonSocialSecurityNumber { get; set; }
        public Contactpersonsaddress[] contactPersonsAddress { get; set; }
        public Contactpersonsname1[] contactPersonsName { get; set; }
        public Contactpersonstelephonenumber1[] contactPersonsTelephoneNumber { get; set; }
        public Contactreason1[] contactReason { get; set; }
        public Contactrole contactRole { get; set; }
        public string dateTimeofBirth { get; set; }
        public string endDate { get; set; }
        public string ethnicGroup { get; set; }
        public string handicap { get; set; }
        public string id { get; set; }
        public string jobStatus { get; set; }
        public string livingArrangement { get; set; }
        public string[] livingDependency { get; set; }
        public string maritalStatus { get; set; }
        public Mothersmaidenname2 mothersMaidenName { get; set; }
        public Name[] name { get; set; }
        public Nationality4 nationality { get; set; }
        public Nextofkinassociatedpartiesemployeenumber nextOfKinAssociatedPartiesEmployeeNumber { get; set; }
        public Nextofkinassociatedpartiesjobcodeclass nextOfKinAssociatedPartiesJobCodeClass { get; set; }
        public string nextOfKinAssociatedPartiesJobTitle { get; set; }
        public Nextofkinassociatedpartysidentifier[] nextOfKinAssociatedPartysIdentifiers { get; set; }
        public Organizationname[] organizationName { get; set; }
        public Phone[] phone { get; set; }
        public Primarylanguage4 primaryLanguage { get; set; }
        public string protectionIndicator { get; set; }
        public Publicityindicator4 publicityIndicator { get; set; }
        public string race { get; set; }
        public Relationship relationship { get; set; }
        public string religion { get; set; }
        public string sex { get; set; }
        public string startDate { get; set; }
        public string studentIndicator { get; set; }
    }

    public class Contactrole
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Mothersmaidenname2
    {
        public string degree { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class Nationality4
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Nextofkinassociatedpartiesemployeenumber
    {
        public Assigningauthority51 assigningAuthority { get; set; }
        public Assigningfacility51 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string id { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
    }

    public class Assigningauthority51
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility51
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Nextofkinassociatedpartiesjobcodeclass
    {
        public string jobClass { get; set; }
        public string jobCode { get; set; }
    }

    public class Primarylanguage4
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Publicityindicator4
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Relationship
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Address1
    {
        public string addressType { get; set; }
        public string censusTract { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string countyOrParishCode { get; set; }
        public string otherDesignation { get; set; }
        public string otherGeographicDesignation { get; set; }
        public string stateOrProvince { get; set; }
        public string streetAddress { get; set; }
        public string zip { get; set; }
    }

    public class Businessphone1
    {
        public string areaCityCode { get; set; }
        public string countryCode { get; set; }
        public string emailAddress { get; set; }
        public string extension { get; set; }
        public string number { get; set; }
        public string phoneNumber { get; set; }
        public string telecommunicationEquipmentType { get; set; }
        public string telecommunicationUseCode { get; set; }
        public string text { get; set; }
    }

    public class Contactpersonsaddress
    {
        public string addressType { get; set; }
        public string censusTract { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string countyOrParishCode { get; set; }
        public string otherDesignation { get; set; }
        public string otherGeographicDesignation { get; set; }
        public string stateOrProvince { get; set; }
        public string streetAddress { get; set; }
        public string zip { get; set; }
    }

    public class Contactpersonsname1
    {
        public string degree { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class Contactpersonstelephonenumber1
    {
        public string areaCityCode { get; set; }
        public string countryCode { get; set; }
        public string emailAddress { get; set; }
        public string extension { get; set; }
        public string number { get; set; }
        public string phoneNumber { get; set; }
        public string telecommunicationEquipmentType { get; set; }
        public string telecommunicationUseCode { get; set; }
        public string text { get; set; }
    }

    public class Contactreason1
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Name
    {
        public string degree { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class Nextofkinassociatedpartysidentifier
    {
        public Assigningauthority52 assigningAuthority { get; set; }
        public Assigningfacility52 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string id { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
    }

    public class Assigningauthority52
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility52
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Organizationname
    {
        public Assigningauthority53 assigningAuthority { get; set; }
        public Assigningfacility53 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string idNumber { get; set; }
        public string idTypeCode { get; set; }
        public string identifierCheckDigit { get; set; }
        public string organizationName { get; set; }
        public string organizationNameTypeCode { get; set; }
    }

    public class Assigningauthority53
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility53
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Phone
    {
        public string areaCityCode { get; set; }
        public string countryCode { get; set; }
        public string emailAddress { get; set; }
        public string extension { get; set; }
        public string number { get; set; }
        public string phoneNumber { get; set; }
        public string telecommunicationEquipmentType { get; set; }
        public string telecommunicationUseCode { get; set; }
        public string text { get; set; }
    }

    public class OBX
    {
        public NTE1[] NTE { get; set; }
        public string[] abnormalFlag { get; set; }
        public string definedAccessChecks { get; set; }
        public string effectiveDateLastNormalValue { get; set; }
        public Identifier identifier { get; set; }
        public string[] natureOfAbnormal { get; set; }
        public string observationDateTime { get; set; }
        public Observationmethod[] observationMethod { get; set; }
        public string[] observationValue { get; set; }
        public string observeResultStatus { get; set; }
        public string probability { get; set; }
        public Producersid producersId { get; set; }
        public string referenceRange { get; set; }
        public Responsibleobserver responsibleObserver { get; set; }
        public string setId { get; set; }
        public string subId { get; set; }
        public Units units { get; set; }
        public string valueType { get; set; }
    }

    public class Identifier
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Producersid
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Responsibleobserver
    {
        public Assigningauthority54 assigningAuthority { get; set; }
        public Assigningfacility54 assigningFacility { get; set; }
        public string codeIdentifyingCheckDigitScheme { get; set; }
        public string degree { get; set; }
        public string firstName { get; set; }
        public string id { get; set; }
        public string identifierCheckDigit { get; set; }
        public string identifierTypeCode { get; set; }
        public string lastName { get; set; }
        public string middleInitOrName { get; set; }
        public string nameTypeCode { get; set; }
        public string prefix { get; set; }
        public string sourceTable { get; set; }
        public string suffix { get; set; }
    }

    public class Assigningauthority54
    {
        public string id { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Assigningfacility54
    {
        public string id { get; set; }
        public string universalId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Units
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class NTE1
    {
        public string[] comment { get; set; }
        public string setId { get; set; }
        public string sourceOfComment { get; set; }
    }

    public class Observationmethod
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class UB1
    {
        public PSROURApprovalindicator PSROURapprovalIndicator { get; set; }
        public string PSROURapprovedStayFrom { get; set; }
        public string PSROURapprovedStayTo { get; set; }
        public string UB82Locator2 { get; set; }
        public string UB82Locator27 { get; set; }
        public string UB82Locator45 { get; set; }
        public string UB82Locator9 { get; set; }
        public string bloodDeductible { get; set; }
        public string bloodFurnishedPints { get; set; }
        public string bloodNotReplacedPints { get; set; }
        public string bloodReplacedPints { get; set; }
        public string coinsuranceDates { get; set; }
        public string[] conditionCode { get; set; }
        public string coveredDays { get; set; }
        public string nonCoveredDays { get; set; }
        public string numberOfGraceDays { get; set; }
        public Occurrence[] occurrence { get; set; }
        public Occurrencespan occurrenceSpan { get; set; }
        public string occurrenceSpanEndDate { get; set; }
        public string occurrenceSpanStartDate { get; set; }
        public string setId { get; set; }
        public Specprogramindicator specProgramIndicator { get; set; }
        public Valueamountandcode[] valueAmountAndCode { get; set; }
    }

    public class PSROURApprovalindicator
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Occurrencespan
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Specprogramindicator
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Occurrence
    {
        public string occurrenceCode { get; set; }
        public string occurrenceDate { get; set; }
    }

    public class Valueamountandcode
    {
        public string valueAmount { get; set; }
        public string valueCode { get; set; }
    }

    public class UB2
    {
        public string[] UB92Locator11 { get; set; }
        public string[] UB92Locator2 { get; set; }
        public string UB92Locator31 { get; set; }
        public string[] UB92Locator49 { get; set; }
        public string[] UB92Locator56 { get; set; }
        public string UB92Locator57 { get; set; }
        public string[] UB92Locator78 { get; set; }
        public string coinsuranceDays { get; set; }
        public string[] conditionCode { get; set; }
        public string coveredDays { get; set; }
        public string[] documentControlNumber { get; set; }
        public string nonCoveredDays { get; set; }
        public Occurrence1[] occurrence { get; set; }
        public Occurrencespancodeanddate[] occurrenceSpanCodeAndDate { get; set; }
        public string setId { get; set; }
        public string specialVisitCount { get; set; }
        public Valueamountandcode1[] valueAmountAndCode { get; set; }
    }

    public class Occurrence1
    {
        public Occurrencecode occurrenceCode { get; set; }
        public string occurrenceDate { get; set; }
    }

    public class Occurrencecode
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Occurrencespancodeanddate
    {
        public Occurrencespancode occurrenceSpanCode { get; set; }
        public string occurrenceSpanEndDate { get; set; }
        public string occurrenceSpanStartDate { get; set; }
    }

    public class Occurrencespancode
    {
        public string altCodingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string codingSystem { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Valueamountandcode1
    {
        public string valueAmount { get; set; }
        public string valueCode { get; set; }
    }


}
