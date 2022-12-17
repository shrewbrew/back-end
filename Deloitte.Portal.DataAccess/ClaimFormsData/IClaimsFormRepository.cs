using Deloitte.Portal.Model.ClaimForms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deloitte.Portal.DataAccess.ClaimFormsData
{
    public interface IClaimsFormRepository
    {
        int InsertSectionOne(ClaimFormsModel claimFormsModel, int fileId);
        bool InsertSectionOneB(ClaimFormsModel claimFormsModel);

        bool InsertSectionThree(ClaimFormsModel claimFormsModel);
        bool InsertSectionFourA(ClaimFormsModel claimFormsModel);

        bool InsertLookupRecord(ReserveFormModel reserveFormModel);

        IEnumerable<ReserveFormModel> GetAllLookupRecord();

        bool InsertFirstNation(ClaimReserveForm claimReserveForm);

        IEnumerable<ClaimReserveForm> GetReserveFormData(int claimId);

        ClaimFormsModel GetSectionOneB(int claimId);

        ClaimFormsModel GetFilledSectionDataForUpdate(int claimId);

        ClaimFormsModel GetAllDataofClaims(int claimId);
    }
}
