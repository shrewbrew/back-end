using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Deloitte.Portal.Model.ClaimForms
{
    public class ClaimFormsModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int claimID { get; set; }
        public string userClaimID { get; set; }
        public string userId { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string otherName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public long socialInsuranceNumber { get; set; }
        public long indianStatusCardNumber { get; set; }
        public long bandRegistrationNumber { get; set; }
        public string bandNameMemberOf { get; set; }
        public string provinceBandLocated { get; set; }
        public string streetNameAndNumber { get; set; }
        public string UnitNumber { get; set; }
        public string poBox { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string province { get; set; }
        public string postalCode { get; set; }
        public long telephoneNumber { get; set; }
        public long mobileNumber { get; set; }
        public string email { get; set; }
        public bool nameOfNation { get; set; }
        public string firstNationNameOfContactAddress { get; set; }
        public string COname { get; set; }
        public bool IsGovernmentIssuedID { get; set; }
        public string GovernmentIDFile { get; set; }
        public bool modeOfPayment { get; set; }
        public string chequeOrDepositFormFile { get; set; }
        public string authorizationFile { get; set; }
        public string authorizationDocumentType { get; set; }
        public bool willYouBeClaimingSpecifiedInjuries { get; set; }
        public string swornAffirmationDeclarationFile { get; set; }

        //Navigation Properties
        public virtual ICollection<ClaimReserveForm> ClaimReserve { get; set; }
        public virtual ICollection<ClaimFile> ClaimFiles { get; set; }

        //Specified Injuries section
        public string digestiveInjuries { get; set; }
        public string digestiveLevel { get; set; }
        public string digestiveNameOfPractitioner { get; set; }
        public string digestiveHarmHealthPractitionerType { get; set; }

        public string respiratoryInjuries { get; set; }
        public string respiratoryLevel { get; set; }
        public string respiratoryNameOfPractitioner { get; set; }
        public string respiratoryPractitionerType { get; set; }

        public string dermatologicalInjuries { get; set; }
        public string dermatologicalLevel { get; set; }
        public string dermatologicalNameOfPractitioner { get; set; }
        public string dermatologicalPractitionerType { get; set; }

        public string liverInjuries { get; set; }
        public string liverLevel { get; set; }
        public string liverNameOfPractitioner { get; set; }
        public string liverPractitionerType { get; set; }

        public string neurologicalInjuries { get; set; }
        public string neurologicalLevel { get; set; }
        public string neurologicalNameOfPractitioner { get; set; }
        public string neurologicalPractitionerType { get; set; }

        public string bloodStreamInjuries { get; set; }
        public string bloodStreamLevel { get; set; }
        public string bloodStreamNameOfPractitioner { get; set; }
        public string bloodStreamPractitionerType { get; set; }

        public string kidneyInjuries { get; set; }
        public string kidneyLevel { get; set; }
        public string kidneyNameOfPractitioner { get; set; }
        public string kidneyPractitionerType { get; set; }

        public string tumorOrCancerInjuries { get; set; }
        public string tumorOrCancerLevel { get; set; }
        public string tumorOrCancerNameOfPractitioner { get; set; }
        public string tumorOrCancerPractitionerType { get; set; }

        //Depression
        public string mentalHealthDepression { get; set; }
        public string mentalHealthDepressionLevel { get; set; }
        public string mentalHealthDepressionNameOfPractitioner { get; set; }
        public string mentalHealthDepressionPractitionerType { get; set; }

        //Panic Disorder
        public string mentalHealthPanicDisorder { get; set; }
        public string mentalHealthPanicDisorderLevel { get; set; }
        public string mentalHealthPanicDisorderNameOfPractitioner { get; set; }
        public string mentalHealthPanicDisorderPractitionerType { get; set; }

        //Substance Addiction
        public string mentalHealthSubstanceAddiction { get; set; }
        public string mentalHealthSubstanceAddictionLevel { get; set; }
        public string mentalHealthSubstanceAddictionNameOfPractitioner { get; set; }
        public string mentalHealthSubstanceAddictionPractitionerType { get; set; }

        //Post Traumatic
        public string mentalHealthPostTraumatic { get; set; }
        public string mentalHealthPostTraumaticLevel { get; set; }
        public string mentalHealthPostTraumaticNameOfPractitioner { get; set; }
        public string mentalHealthPostTraumaticPractitionerType { get; set; }

        //Specific Phobia
        public string mentalHealthSpecificPhobia { get; set; }
        public string mentalHealthSpecificPhobiaLevel { get; set; }
        public string mentalHealthSpecificPhobiaNameOfPractitioner { get; set; }
        public string mentalHealthSpecificPhobiaPractitionerType { get; set; }

        //Adjustment Disorder
        public string mentalHealthAdjustmentDisorder { get; set; }
        public string mentalHealthAdjustmentDisorderLevel { get; set; }
        public string mentalHealthAdjustmentDisorderNameOfPractitioner { get; set; }
        public string mentalHealthAdjustmentDisorderPractitionerType { get; set; }

        //Generalized Anxiety Disorder
        public string mentalHealthAnxietyDisorder { get; set; }
        public string mentalHealthAnxietyDisorderLevel { get; set; }
        public string mentalHealthAnxietyDisorderNameOfPractitioner { get; set; }
        public string mentalHealthAnxietyDisorderPractitionerType { get; set; }
    }
}
