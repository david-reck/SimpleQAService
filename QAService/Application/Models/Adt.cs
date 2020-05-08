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
        public MSH MSH { get; set; }
        public EVN[] EVN { get; set; }
        public PID[] PID { get; set; }
        public NK1[] NK1 { get; set; }
        public PV1[] PV1 { get; set; }
        public DB1[] DB1 { get; set; }
        public OBX[] OBX { get; set; }
        public AL1[] AL1 { get; set; }
        public DG1[] DG1 { get; set; }
        public DRG[] DRG { get; set; }
        public GT1[] GT1 { get; set; }
        public IN1[] IN1 { get; set; }
        public ACC[] ACC { get; set; }
    }

    public class MSH
    {
        public Sendingapplication sendingApplication { get; set; }
        public Sendingfacility sendingFacility { get; set; }
        public Receivingapplication receivingApplication { get; set; }
        public Receivingfacility receivingFacility { get; set; }
        public string dateTimeOfMessage { get; set; }
        public Messagetype messageType { get; set; }
        public string messageControlID { get; set; }
        public Processingid processingID { get; set; }
        public string versionID { get; set; }
    }

    public class Sendingapplication
    {
        public string namespaceId { get; set; }
        public string universalId { get; set; }
    }

    public class Sendingfacility
    {
        public string namespaceId { get; set; }
        public string universalIdType { get; set; }
    }

    public class Receivingapplication
    {
        public string namespaceId { get; set; }
    }

    public class Receivingfacility
    {
        public string namespaceId { get; set; }
    }

    public class Messagetype
    {
        public string messageType { get; set; }
        public string triggerEvent { get; set; }
    }

    public class Processingid
    {
        public string processingID { get; set; }
    }

    public class EVN
    {
        public string eventType { get; set; }
        public string recordedDateTime { get; set; }
        public string plannedEventDateTime { get; set; }
        public string eventReasonCode { get; set; }
        public Operatorid operatorId { get; set; }
        public string eventOccurred { get; set; }
    }

    public class Operatorid
    {
        public string id { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
    }

    public class PID
    {
        public string setId { get; set; }
        public Externalid externalId { get; set; }
        public Internalid[] internalId { get; set; }
        public Alternateid[] alternateId { get; set; }
        public Patientname[] patientName { get; set; }
        public Mothersmaidenname mothersMaidenName { get; set; }
        public string dateTimeBirth { get; set; }
        public string sex { get; set; }
        public Alias[] alias { get; set; }
        public string race { get; set; }
        public Address[] address { get; set; }
        public string countyCode { get; set; }
        public Homephone[] homePhone { get; set; }
        public Businessphone[] businessPhone { get; set; }
        public Primarylanguage primaryLanguage { get; set; }
        public string maritalStatus { get; set; }
        public string religion { get; set; }
        public Patientaccountnumber patientAccountNumber { get; set; }
        public Driverslicensenumber driversLicenseNumber { get; set; }
        public string ethnicGroup { get; set; }
        public string birthPlace { get; set; }
        public string multipleBirthIndicator { get; set; }
        public string birthOrder { get; set; }
        public object[] citizenship { get; set; }
        public Nationality nationality { get; set; }
        public string deathIndicator { get; set; }
        public PD1[] PD1 { get; set; }
    }

    public class Externalid
    {
        public string id { get; set; }
    }

    public class Mothersmaidenname
    {
        public string lastName { get; set; }
    }

    public class Primarylanguage
    {
        public string id { get; set; }
    }

    public class Patientaccountnumber
    {
        public string id { get; set; }
    }

    public class Driverslicensenumber
    {
        public string licenseNumber { get; set; }
    }

    public class Nationality
    {
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Internalid
    {
        public string id { get; set; }
    }

    public class Alternateid
    {
        public string id { get; set; }
    }

    public class Patientname
    {
        public string lastName { get; set; }
        public string firstName { get; set; }
    }

    public class Alias
    {
        public string lastName { get; set; }
    }

    public class Address
    {
        public string streetAddress { get; set; }
        public string stateOrProvince { get; set; }
        public string zip { get; set; }
    }

    public class Homephone
    {
        public string number { get; set; }
    }

    public class Businessphone
    {
        public string number { get; set; }
    }

    public class PD1
    {
        public string[] livingDependency { get; set; }
        public string livingArrangement { get; set; }
        public Patientprimaryfacility[] patientPrimaryFacility { get; set; }
        public Primarycareprovider[] primaryCareProvider { get; set; }
        public string studentIndicator { get; set; }
        public string livingWillCode { get; set; }
        public string organDonorCode { get; set; }
        public string separateBill { get; set; }
        public Publicityindicator publicityIndicator { get; set; }
        public string protectionIndicator { get; set; }
    }

    public class Publicityindicator
    {
        public string id { get; set; }
    }

    public class Patientprimaryfacility
    {
        public string organizationName { get; set; }
        public string idNumber { get; set; }
        public Assigningauthority assigningAuthority { get; set; }
    }

    public class Assigningauthority
    {
        public string namespaceId { get; set; }
    }

    public class Primarycareprovider
    {
        public string id { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string middleInitOrName { get; set; }
        public string prefix { get; set; }
    }

    public class NK1
    {
        public string id { get; set; }
        public Name[] name { get; set; }
        public Relationship relationship { get; set; }
        public Address1[] address { get; set; }
        public Phone[] phone { get; set; }
        public Businessphone1[] businessPhone { get; set; }
        public Contactrole contactRole { get; set; }
        public string startDate { get; set; }
        public string nextOfKinAssociatedPartiesJobTitle { get; set; }
        public string maritalStatus { get; set; }
        public string sex { get; set; }
        public string dateTimeofBirth { get; set; }
        public string[] livingDependency { get; set; }
        public string[] ambulatoryStatus { get; set; }
        public string[] citizenship { get; set; }
        public Primarylanguage1 primaryLanguage { get; set; }
        public string livingArrangement { get; set; }
        public Publicityindicator1 publicityIndicator { get; set; }
        public string protectionIndicator { get; set; }
        public string studentIndicator { get; set; }
        public string religion { get; set; }
        public Mothersmaidenname1 mothersMaidenName { get; set; }
        public Nationality1 nationality { get; set; }
        public string ethnicGroup { get; set; }
        public Nextofkinassociatedpartysidentifier[] nextOfKinAssociatedPartysIdentifiers { get; set; }
        public string jobStatus { get; set; }
        public string race { get; set; }
        public string contactPersonSocialSecurityNumber { get; set; }
    }

    public class Relationship
    {
        public string id { get; set; }
    }

    public class Contactrole
    {
        public string id { get; set; }
    }

    public class Primarylanguage1
    {
        public string id { get; set; }
    }

    public class Publicityindicator1
    {
        public string id { get; set; }
    }

    public class Mothersmaidenname1
    {
        public string lastName { get; set; }
    }

    public class Nationality1
    {
        public string id { get; set; }
    }

    public class Name
    {
        public string lastName { get; set; }
        public string firstName { get; set; }
    }

    public class Address1
    {
        public string streetAddress { get; set; }
        public string stateOrProvince { get; set; }
        public string zip { get; set; }
    }

    public class Phone
    {
        public string number { get; set; }
    }

    public class Businessphone1
    {
        public string number { get; set; }
    }

    public class Nextofkinassociatedpartysidentifier
    {
        public string id { get; set; }
    }

    public class PV1
    {
        public string setId { get; set; }
        public string patientClass { get; set; }
        public Assignedpatientlocation assignedPatientLocation { get; set; }
        public string admissionType { get; set; }
        public Preadmitnumber preadmitNumber { get; set; }
        public Priorpatientlocation priorPatientLocation { get; set; }
        public Attendingdoctor[] attendingDoctor { get; set; }
        public Referringdoctor[] referringDoctor { get; set; }
        public Consultingdoctor[] consultingDoctor { get; set; }
        public string hospitalService { get; set; }
        public Temporarylocation temporaryLocation { get; set; }
        public string preadmitTestIndicator { get; set; }
        public string admitSource { get; set; }
        public string[] ambulatoryStatus { get; set; }
        public Admittingdoctor[] admittingDoctor { get; set; }
        public string patientType { get; set; }
        public Visitnumber visitNumber { get; set; }
        public Financialclass financialClass { get; set; }
        public string chargePriceIndicator { get; set; }
        public string courtesyCode { get; set; }
        public string creditRating { get; set; }
        public string[] contractCode { get; set; }
        public string[] contractEffectiveDate { get; set; }
        public string[] contractAmount { get; set; }
        public string[] contractPeriod { get; set; }
        public string interestCode { get; set; }
        public string transferToBadDebtCode { get; set; }
        public PV2[] PV2 { get; set; }
    }

    public class Assignedpatientlocation
    {
        public string pointOfCare { get; set; }
        public string room { get; set; }
        public string bed { get; set; }
        public Facility facility { get; set; }
    }

    public class Facility
    {
        public string nameSpaceId { get; set; }
    }

    public class Preadmitnumber
    {
        public string id { get; set; }
    }

    public class Priorpatientlocation
    {
        public string pointOfCare { get; set; }
        public string room { get; set; }
        public string bed { get; set; }
        public Facility1 facility { get; set; }
    }

    public class Facility1
    {
        public string nameSpaceId { get; set; }
    }

    public class Temporarylocation
    {
        public string pointOfCare { get; set; }
        public string room { get; set; }
        public string bed { get; set; }
        public Facility2 facility { get; set; }
    }

    public class Facility2
    {
        public string nameSpaceId { get; set; }
    }

    public class Visitnumber
    {
        public string id { get; set; }
    }

    public class Financialclass
    {
        public string financialClass { get; set; }
    }

    public class Attendingdoctor
    {
        public string id { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string prefix { get; set; }
    }

    public class Referringdoctor
    {
        public string id { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string middleInitOrName { get; set; }
        public string prefix { get; set; }
    }

    public class Consultingdoctor
    {
        public string id { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string middleInitOrName { get; set; }
        public string prefix { get; set; }
    }

    public class Admittingdoctor
    {
        public string id { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string middleInitOrName { get; set; }
        public string prefix { get; set; }
    }

    public class PV2
    {
        public Priorpendinglocation priorPendingLocation { get; set; }
        public Accommodationcode accommodationCode { get; set; }
        public Admitreason admitReason { get; set; }
        public string[] patientValuables { get; set; }
        public string patientValuablesLocation { get; set; }
    }

    public class Priorpendinglocation
    {
        public string pointOfCare { get; set; }
        public string room { get; set; }
        public string bed { get; set; }
        public Facility3 facility { get; set; }
    }

    public class Facility3
    {
        public string nameSpaceId { get; set; }
    }

    public class Accommodationcode
    {
        public string id { get; set; }
    }

    public class Admitreason
    {
        public string id { get; set; }
        public string text { get; set; }
        public string codingSystem { get; set; }
    }

    public class DB1
    {
        public string setID { get; set; }
        public string disabledPersonCode { get; set; }
        public Disabledpersonidentifier[] disabledPersonIdentifier { get; set; }
        public string disabledIndicator { get; set; }
        public string disabilityStartDate { get; set; }
        public string disabilityEndDate { get; set; }
        public string disabilityReturnToWorkDate { get; set; }
    }

    public class Disabledpersonidentifier
    {
        public string id { get; set; }
        public Assigningauthority1 assigningAuthority { get; set; }
    }

    public class Assigningauthority1
    {
    }

    public class OBX
    {
        public string setId { get; set; }
        public string valueType { get; set; }
        public Identifier identifier { get; set; }
        public string[] observationValue { get; set; }
        public Units units { get; set; }
        public string referenceRange { get; set; }
        public string[] natureOfAbnormal { get; set; }
        public string observeResultStatus { get; set; }
        public string effectiveDateLastNormalValue { get; set; }
        public string observationDateTime { get; set; }
        public Producersid producersId { get; set; }
    }

    public class Identifier
    {
        public string id { get; set; }
        public string text { get; set; }
        public string codingSystem { get; set; }
        public string altId { get; set; }
        public string altText { get; set; }
        public string altCodingSystem { get; set; }
    }

    public class Units
    {
        public string id { get; set; }
    }

    public class Producersid
    {
        public string id { get; set; }
        public string text { get; set; }
    }

    public class AL1
    {
        public string setId { get; set; }
        public string allergyType { get; set; }
        public Allergycodemnemonicdescription allergyCodeMnemonicDescription { get; set; }
        public string allergySeverity { get; set; }
        public string allergyReaction { get; set; }
        public string identificationDate { get; set; }
    }

    public class Allergycodemnemonicdescription
    {
        public string id { get; set; }
        public string text { get; set; }
        public string altId { get; set; }
    }

    public class DG1
    {
        public string setId { get; set; }
        public Diagnosiscode diagnosisCode { get; set; }
        public string diagnosisDateTime { get; set; }
        public string diagnosisType { get; set; }
    }

    public class Diagnosiscode
    {
        public string id { get; set; }
        public string text { get; set; }
        public string codingSystem { get; set; }
    }

    public class DRG
    {
        public PR1[] PR1 { get; set; }
    }

    public class PR1
    {
        public string setId { get; set; }
        public Procedurecode procedureCode { get; set; }
        public string procedureDateTime { get; set; }
        public string procedureMinutes { get; set; }
        public ROL[] ROL { get; set; }
    }

    public class Procedurecode
    {
        public string id { get; set; }
        public string text { get; set; }
        public string codingSystem { get; set; }
    }

    public class ROL
    {
        public Roleinstanceid roleInstanceID { get; set; }
        public string actionCode { get; set; }
        public Role role { get; set; }
        public Roleperson rolePerson { get; set; }
    }

    public class Roleinstanceid
    {
        public string id { get; set; }
    }

    public class Role
    {
        public string id { get; set; }
    }

    public class Roleperson
    {
        public string id { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string middleInitOrName { get; set; }
        public string prefix { get; set; }
    }

    public class GT1
    {
        public string setId { get; set; }
        public Guarantornumber[] guarantorNumber { get; set; }
        public Guarantorname[] guarantorName { get; set; }
        public Guarantoraddress[] guarantorAddress { get; set; }
        public Guarantorphnumhome[] guarantorPhNumHome { get; set; }
        public Guarantorphnumbusiness[] guarantorPhNumBusiness { get; set; }
        public string guarantorDatetimeOfBirth { get; set; }
        public string guarantorSex { get; set; }
        public string guarantorSSN { get; set; }
        public string guarantorDateBegin { get; set; }
        public string guarantorPriority { get; set; }
        public Guarantoremployeeidnumber[] guarantorEmployeeIDNumber { get; set; }
        public string guarantorEmploymentStatus { get; set; }
        public string guarantorBillingHoldFlag { get; set; }
        public string guarantorDeathFlag { get; set; }
        public Guarantoremployeridnumber[] guarantorEmployerIDNumber { get; set; }
        public string guarantorMaritalStatusCode { get; set; }
        public Primarylanguage2 primaryLanguage { get; set; }
        public string livingArrangement { get; set; }
        public string protectionIndicator { get; set; }
        public string studentIndicator { get; set; }
        public string religion { get; set; }
        public Mothersmaidenname2 mothersMaidenName { get; set; }
        public Nationality2 nationality { get; set; }
        public string ethnicGroup { get; set; }
        public string jobTitle { get; set; }
        public string jobStatus { get; set; }
        public string guarantorRace { get; set; }
    }

    public class Primarylanguage2
    {
        public string id { get; set; }
    }

    public class Mothersmaidenname2
    {
        public string lastName { get; set; }
    }

    public class Nationality2
    {
        public string id { get; set; }
    }

    public class Guarantornumber
    {
        public string id { get; set; }
    }

    public class Guarantorname
    {
        public string lastName { get; set; }
        public string firstName { get; set; }
    }

    public class Guarantoraddress
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string stateOrProvince { get; set; }
        public string zip { get; set; }
    }

    public class Guarantorphnumhome
    {
        public string number { get; set; }
    }

    public class Guarantorphnumbusiness
    {
        public string number { get; set; }
    }

    public class Guarantoremployeeidnumber
    {
        public string id { get; set; }
    }

    public class Guarantoremployeridnumber
    {
        public string id { get; set; }
    }

    public class IN1
    {
        public string setId { get; set; }
        public Planid planId { get; set; }
        public Companyid[] companyId { get; set; }
        public Companyname[] companyName { get; set; }
        public Companyaddress[] companyAddress { get; set; }
        public Companyphonenumber[] companyPhoneNumber { get; set; }
        public string groupNumber { get; set; }
        public Groupname[] groupName { get; set; }
        public Groupempid[] groupEmpId { get; set; }
        public Groupempname[] groupEmpName { get; set; }
        public string planEffectiveDate { get; set; }
        public Authorizationinformation authorizationInformation { get; set; }
        public string planType { get; set; }
        public Insuredname[] insuredName { get; set; }
        public string insuredRelationshipToPatient { get; set; }
        public string insuredDob { get; set; }
        public Insuredaddress[] insuredAddress { get; set; }
        public string assignmentOfBenefits { get; set; }
        public string coordinationOfBenefits { get; set; }
        public string coordinationOfBenefitsPriority { get; set; }
        public string noticeOfAdmissionFlag { get; set; }
        public string reportOfEligibilityFlag { get; set; }
        public string releaseInformationCode { get; set; }
        public string verificationDateTime { get; set; }
        public string typeOfAgreementCode { get; set; }
        public string policyNumber { get; set; }
        public Policydeductible policyDeductible { get; set; }
        public Insuredemploymentstatus insuredEmploymentStatus { get; set; }
        public string insuredSex { get; set; }
        public Insuredemployeraddress[] insuredEmployerAddress { get; set; }
        public string priorInsurancePlanId { get; set; }
        public string coverageType { get; set; }
        public Insuredidnumber[] insuredIdNumber { get; set; }
        public IN2[] IN2 { get; set; }
        public IN3[] IN3 { get; set; }
    }

    public class Planid
    {
        public string id { get; set; }
    }

    public class Authorizationinformation
    {
        public string authorizationNumber { get; set; }
    }

    public class Policydeductible
    {
        public Price price { get; set; }
    }

    public class Price
    {
        public string quantity { get; set; }
    }

    public class Insuredemploymentstatus
    {
        public string id { get; set; }
    }

    public class Companyid
    {
        public string id { get; set; }
    }

    public class Companyname
    {
        public string organizationName { get; set; }
    }

    public class Companyaddress
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string stateOrProvince { get; set; }
        public string zip { get; set; }
    }

    public class Companyphonenumber
    {
        public string number { get; set; }
    }

    public class Groupname
    {
        public string organizationName { get; set; }
    }

    public class Groupempid
    {
        public string id { get; set; }
    }

    public class Groupempname
    {
        public string organizationName { get; set; }
    }

    public class Insuredname
    {
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string middleInitOrName { get; set; }
    }

    public class Insuredaddress
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string stateOrProvince { get; set; }
        public string zip { get; set; }
    }

    public class Insuredemployeraddress
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string stateOrProvince { get; set; }
        public string zip { get; set; }
    }

    public class Insuredidnumber
    {
        public string id { get; set; }
    }

    public class IN2
    {
        public Insuredemployeeid[] insuredEmployeeId { get; set; }
        public string insuredSSN { get; set; }
        public Insuredemployername[] insuredEmployerName { get; set; }
        public string[] mailClaimParty { get; set; }
        public string babyCoverage { get; set; }
        public string combineBabyBill { get; set; }
        public Payorid[] payorId { get; set; }
        public Payorsubscriberid[] payorSubscriberId { get; set; }
        public string eligibilitySource { get; set; }
        public Dailydeductible dailyDeductible { get; set; }
        public string livingDependency { get; set; }
        public string ambulatoryStatus { get; set; }
        public string citizenship { get; set; }
        public Primarylanguage3 primaryLanguage { get; set; }
        public string livingArrangement { get; set; }
        public Publicityindicator2 publicityIndicator { get; set; }
        public string protectionIndicator { get; set; }
        public string studentIndicator { get; set; }
        public string religion { get; set; }
        public Mothermaidenname motherMaidenName { get; set; }
        public Nationality3 nationality { get; set; }
        public string ethnicGroup { get; set; }
        public string[] maritalStatus { get; set; }
        public string insuredEmploymentStartDate { get; set; }
        public string jobTitle { get; set; }
        public string jobStatus { get; set; }
        public Patientmembernumber[] patientMemberNumber { get; set; }
        public string guarantorRelationshipToInsured { get; set; }
        public Insuredhomephone[] insuredHomePhone { get; set; }
        public Insuredemployerphone[] insuredEmployerPhone { get; set; }
        public string suspendFlag { get; set; }
        public string copayLimitFlag { get; set; }
        public string stoplossLimitFlag { get; set; }
        public string race { get; set; }
        public Hcfapatientrelationshiptoinsured hcfaPatientRelationshipToInsured { get; set; }
    }

    public class Dailydeductible
    {
        public string delayDays { get; set; }
        public string amount { get; set; }
        public string numberOfDays { get; set; }
    }

    public class Primarylanguage3
    {
        public string id { get; set; }
    }

    public class Publicityindicator2
    {
        public string id { get; set; }
    }

    public class Mothermaidenname
    {
        public string lastName { get; set; }
    }

    public class Nationality3
    {
        public string id { get; set; }
    }

    public class Hcfapatientrelationshiptoinsured
    {
        public string id { get; set; }
    }

    public class Insuredemployeeid
    {
        public string id { get; set; }
    }

    public class Insuredemployername
    {
        public string id { get; set; }
    }

    public class Payorid
    {
        public string id { get; set; }
    }

    public class Payorsubscriberid
    {
        public string id { get; set; }
    }

    public class Patientmembernumber
    {
        public string id { get; set; }
    }

    public class Insuredhomephone
    {
        public string number { get; set; }
    }

    public class Insuredemployerphone
    {
        public string number { get; set; }
    }

    public class IN3
    {
        public string setID { get; set; }
        public Certificationnumber certificationNumber { get; set; }
        public Certifiedby[] certifiedBy { get; set; }
        public string certificationRequired { get; set; }
        public string certificationDateTime { get; set; }
        public Operator[] _operator { get; set; }
        public string certificationBeginDate { get; set; }
        public Physicianreviewer[] physicianReviewer { get; set; }
        public string certificationContact { get; set; }
        public Certificationcontactphonenumber[] certificationContactPhoneNumber { get; set; }
        public Certificationagency certificationAgency { get; set; }
        public Certificationagencyphonenumber[] certificationAgencyPhoneNumber { get; set; }
        public Precertificationreqwindow[] preCertificationReqWindow { get; set; }
        public string caseManager { get; set; }
        public Secondopinionphysician[] secondOpinionPhysician { get; set; }
    }

    public class Certificationnumber
    {
        public string id { get; set; }
    }

    public class Certificationagency
    {
        public string id { get; set; }
    }

    public class Certifiedby
    {
        public string id { get; set; }
    }

    public class Operator
    {
        public string id { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string middleInitOrName { get; set; }
        public string prefix { get; set; }
    }

    public class Physicianreviewer
    {
        public string id { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string middleInitOrName { get; set; }
        public string prefix { get; set; }
    }

    public class Certificationcontactphonenumber
    {
        public string number { get; set; }
    }

    public class Certificationagencyphonenumber
    {
        public string number { get; set; }
    }

    public class Precertificationreqwindow
    {
        public string preCertificationPatientType { get; set; }
    }

    public class Secondopinionphysician
    {
        public string id { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string middleInitOrName { get; set; }
        public string prefix { get; set; }
    }

    public class ACC
    {
        public string accidentDateTime { get; set; }
        public Accidentcode accidentCode { get; set; }
        public string accidentLocation { get; set; }
        public Autoaccidentstate autoAccidentState { get; set; }
        public string accidentDeathIndicator { get; set; }
    }

    public class Accidentcode
    {
        public string id { get; set; }
        public string text { get; set; }
        public string codingSystem { get; set; }
    }

    public class Autoaccidentstate
    {
        public string id { get; set; }
    }

}
