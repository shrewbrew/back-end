using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deloitte.Portal.Model.ClaimForms
{
    public  class SectionOneModel
    {
        public int claimID { get; set; }
        public string userClaimID { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string otherName { get; set; }
        public string dateOfBirth { get; set; }
        public string socialInsuranceNumber { get; set; }
        public string indianStatusCardNumber { get; set; }
        public string bandRegistrationNumber { get; set; }
        public string bandNameMemberOf { get; set; }
        public string provinceBandLocated { get; set; }
        public string streetNameAndNumber { get; set; }
        public string UnitNumber { get; set; }
        public string poBox { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string province { get; set; }
        public string postalCode { get; set; }
        public string telephoneNumber { get; set; }
        public string mobileNumber { get; set; }
        public string email { get; set; }
        public string nameOfNation { get; set; }
        public string firstNationNameOfContactAddress { get; set; }
        public string COname { get; set; }
        public string IsGovernmentIssuedID { get; set; }
        public IFormFile GovernmentIDFile { get; set; }
    }
}
