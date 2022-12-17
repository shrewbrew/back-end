using System;
using System.Collections.Generic;
using System.Text;

namespace Deloitte.Portal.Model.ViewModels
{
    public class CLaimFormsViewModel
    {
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
    }
}
