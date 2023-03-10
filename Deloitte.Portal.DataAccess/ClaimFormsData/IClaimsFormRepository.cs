using Deloitte.Portal.Model.ClaimForms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deloitte.Portal.DataAccess.ClaimFormsData
{
    public interface IClaimsFormRepository
    {
        int InsertSectionOne(ClaimFormsModel claimFormsModel, int fileId);
        bool InsertSectionOneB(ClaimFormsModel claimFormsModel, int fileId);

        bool InsertSectionThree(ClaimFormsModel claimFormsModel, int fileId);
        bool InsertSectionFourA(ClaimFormsModel claimFormsModel);
        bool InsertSectionFourB(ClaimFormsModel model);
        bool InsertSectionFive(ClaimFormsModel claimFormsModel, int fileId);

        bool InsertLookupRecord(ReserveFormModel reserveFormModel);

        IEnumerable<ReserveFormModel> GetAllLookupRecord();

        bool InsertFirstNation(ClaimReserveForm claimReserveForm, int claimId);

        IEnumerable<ClaimReserveForm> GetReserveFormData(int claimId);

        ClaimFormsModel GetSectionOneB(int claimId);

        ClaimFormsModel GetFilledSectionDataForUpdate(int claimId);

        ClaimFormsModel GetAllDataofClaims(int claimId);
    }
}
