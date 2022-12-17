using Deloitte.Portal.DataAccess.ClaimFormsData;
using Deloitte.Portal.Model.ClaimForms;
using Deloitte.Portal.Model.Test;
using Deloitte.Portal.Model.ViewModels;
using Deloitte.Portal.Service.UserService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Deloitte.Portal.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [EnableCors]
    public class ClaimManagementController : ControllerBase
    {
        private readonly IClaimsFormRepository claimsFormRepository;
        private readonly IServices services;

        public ClaimManagementController(IClaimsFormRepository claimsFormRepository, IServices services)
        {
            this.claimsFormRepository = claimsFormRepository;
            this.services = services;
        }
        #region Part One

        #region Section One A
        [HttpGet]
        public IActionResult SectionOne()
        {
            string users = User.Identity.Name;
            string user = services.GetUserEmail();
            return Ok(user);
        }

        [HttpPost]
        public IActionResult SectionOne([FromForm] SectionOneModel model)
        {
            string IpAddress = services.GetUserMachineIpAddres();
            if(ModelState.IsValid)
            { 
                try 
                {
                    string userClaimIds = services.GetRegNumber();
                    string GovernmentIDFileName = string.Empty;
                    int fileId = 0;
                    var fileData = services.ProcessToUploadGovernmentID(model, userClaimIds);
                   foreach(var item in fileData)
                    {
                        GovernmentIDFileName = item.filename;
                        fileId = item.fileId;
                    }
                    string userIDs = services.GetUserEmail();
                    ClaimFormsModel claimFormsModel = new ClaimFormsModel()
            {
                 claimID = model.claimID,
                 userClaimID= userClaimIds,
                 userId = services.GetUserEmail(),
                 firstName = model.firstName,
                 middleName = model.middleName,
                 lastName = model.lastName,
                 otherName = model.otherName,
                 dateOfBirth = Convert.ToDateTime(model.dateOfBirth),
                 socialInsuranceNumber = (long)Convert.ToDouble(model.socialInsuranceNumber),
                 indianStatusCardNumber = (long)Convert.ToDouble(model.indianStatusCardNumber),
                 bandRegistrationNumber = (long)Convert.ToDouble(model.bandRegistrationNumber),
                 bandNameMemberOf = model.bandNameMemberOf,
                 provinceBandLocated = model.provinceBandLocated,
                 streetNameAndNumber = model.streetNameAndNumber,
                 UnitNumber = model.UnitNumber,
                 poBox = model.poBox,
                 city = model.city,
                 country = model.country,
                 province = model.province,
                 postalCode = model.postalCode,
                 telephoneNumber = (long)Convert.ToDouble(model.telephoneNumber),
                 mobileNumber = (long)Convert.ToDouble(model.mobileNumber),
                 email = model.email,
                 nameOfNation = model.nameOfNation == "Yes" ? true : false,
                 firstNationNameOfContactAddress = model.firstNationNameOfContactAddress,
                 COname = model.COname,
                 IsGovernmentIssuedID = model.IsGovernmentIssuedID == "Yes" ? true : false ,
                 GovernmentIDFile = GovernmentIDFileName,

             };
                    
                    int claimId = claimsFormRepository.InsertSectionOne(claimFormsModel, fileId);
                    HttpContext.Session.SetString("sessionInsertClaimId",Convert.ToString(claimId));
                    if (claimId != 0)
                        return Ok();
                   
                }
                catch (Exception ex) 
                {
                    return BadRequest(ex);
                }
            }
            IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
            return BadRequest(allErrors);
                
        }
        [HttpGet]
        public IActionResult LoadSectionOne(int claimId)
        {
            var data = claimsFormRepository.GetFilledSectionDataForUpdate(claimId);
            ClaimFormsModel model = new ClaimFormsModel();

            model.claimID= data.claimID;
            model.userClaimID = data.userClaimID;
            data.userId = data.userId;
            model.firstName= data.firstName;
            model.middleName=data.middleName;
            model.lastName= data.lastName;
            model.otherName= data.otherName;
            model.dateOfBirth= data.dateOfBirth;
            model.socialInsuranceNumber= data.socialInsuranceNumber;
            model.indianStatusCardNumber= data.indianStatusCardNumber;
            model.bandRegistrationNumber= data.bandRegistrationNumber;
            model.bandNameMemberOf=data.bandNameMemberOf;
            model.provinceBandLocated= data.provinceBandLocated;
            model.streetNameAndNumber= data.streetNameAndNumber;
            model.UnitNumber=data.UnitNumber;
            model.city= data.city;
            model.poBox= data.poBox;
            model.country= data.country;
            model.province = data.province;
            model.postalCode= data.postalCode;
            model.telephoneNumber= data.telephoneNumber;
            model.mobileNumber= data.mobileNumber;
            model.email= data.email;
            model.nameOfNation = data.nameOfNation;
            model.firstNationNameOfContactAddress= data.firstNationNameOfContactAddress;
            model.COname= data.COname;
            model.IsGovernmentIssuedID=data.IsGovernmentIssuedID;
            model.GovernmentIDFile= data.GovernmentIDFile;

            return Ok(model);
        }
        #endregion

        #region Section One B
        [HttpGet]
        public IActionResult SectionOneB(int claimId)
        {
            
            var data = claimsFormRepository.GetSectionOneB(claimId);
            var paymentinfo = data.chequeOrDepositFormFile;
            return Ok(paymentinfo);
        }

        [HttpPut]
        public IActionResult SectionOneB([FromForm] PaymentInformationSectionOne model)
        {
            string sessionInsertClaimId = HttpContext.Session.GetString("sessionInsertClaimId");

            int claimId = Convert.ToInt32(sessionInsertClaimId);

            string chequefile =  services.ProcessToUploadChequeAndDeposit(model);

            ClaimFormsModel claimFormsModel = new ClaimFormsModel()
            {
                claimID = claimId,
                chequeOrDepositFormFile = chequefile,
    };

          var status =  claimsFormRepository.InsertSectionOneB(claimFormsModel);
            if(status)
            return Ok(status);
            else
                return BadRequest();
        }

        #endregion

        #endregion

        #region Part Two
        [HttpGet]
        public IActionResult SectionTwo(int claimID)
        {
            var data = claimsFormRepository.GetReserveFormData(claimID);
            return Ok(data);
        }


        #endregion

        #region Lookup Records
        [HttpGet]
        public IActionResult LookUpRecords()
        {
            var model = claimsFormRepository.GetAllLookupRecord();
            return Ok(model);
        }

        [HttpPost]
        public IActionResult LookUpRecords(LookupRecords model)
        {
            ReserveFormModel reserveFormModel = new ReserveFormModel()
            {
                Name = model.Name,
                Proviences = model.Proviences,
                firstNationBandNumber = model.firstNationBandNumber,
                startDateOfWaterAdvisory = Convert.ToDateTime(model.startDateOfWaterAdvisory),
                endDateOfWaterAdvisory = Convert.ToDateTime(model.endDateOfWaterAdvisory)
            };
            bool status = claimsFormRepository.InsertLookupRecord(reserveFormModel);
            if (status)
                return Ok();
            else
                return BadRequest();
        }
        #endregion

        #region Add First Nation

        [HttpPost]
        public IActionResult AddFirstNation(ClaimReserveFormViewModel model)
        {
            ClaimReserveForm claimReserveForm = new ClaimReserveForm()
            {
                nameOfFirstNation=model.nameOfFirstNation,
                provinceOrTerritory=model.provinceOrTerritory,
                firstNationBandNumber=model.firstNationBandNumber,
                waterAdvisoryStartDate= Convert.ToDateTime(model.waterAdvisoryStartDate),
                waterAdvisoryEndDate = Convert.ToDateTime(model.waterAdvisoryEndDate),
                fromMonth=model.fromMonth,  
                fromYear = Convert.ToInt32(model.fromYear),
                toMonth=model.toMonth,
                toYear=Convert.ToInt32(model.toYear),
            };

            bool status = claimsFormRepository.InsertFirstNation(claimReserveForm);
            if (status) return Ok();
            else return BadRequest();
        }

        #endregion

        [HttpPut]
        public IActionResult SectionThree([FromForm] SectionThreeModel model)
        {
            string sessionInsertClaimId = HttpContext.Session.GetString("sessionInsertClaimId");

            int claimId = Convert.ToInt32(sessionInsertClaimId);

            string authorizationFilename = services.ProcessToUploadAuthorizationFile(model);

            ClaimFormsModel claimFormsModel = new ClaimFormsModel()
            {
                claimID = claimId,
                authorizationFile = authorizationFilename,
            };
            bool status = claimsFormRepository.InsertSectionThree(claimFormsModel);
            if (status) return Ok();
            else return BadRequest();
        }

        [HttpPut]
        public IActionResult SectionFourA(SectionFourA model)
        {
            ClaimFormsModel claimFormsModel = new ClaimFormsModel()
            {
                willYouBeClaimingSpecifiedInjuries = model.WillYouBeClaimingSpecifiedInjuries == "Yes" ? true : false
            };

            bool status = claimsFormRepository.InsertSectionFourA(claimFormsModel);
            if (status) return Ok();
            else return BadRequest();
        }

        //        [HttpPut]
        //        public IActionResult SectionFourB()
    }
}
