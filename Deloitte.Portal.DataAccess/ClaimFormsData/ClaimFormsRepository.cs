using Deloitte.Portal.Model.ClaimForms;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Deloitte.Portal.DataAccess.ClaimFormsData
{
    public class ClaimFormsRepository : IClaimsFormRepository
    {
        private readonly AppDbContext context;
        private readonly IConfiguration configuration;

        public ClaimFormsRepository(AppDbContext context, IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }

        public IEnumerable<ReserveFormModel> GetAllLookupRecord()
        {
            return context.Reserve;
        }

        public IEnumerable<ClaimReserveForm> GetReserveFormData(int claimId)
        {
            string connectionString = configuration.GetConnectionString("DatabaseConnection");
            List<ClaimReserveForm> lstClaimReserveForm = new List<ClaimReserveForm>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();


                SqlCommand cmd = new SqlCommand("SELECT * FROM ClaimReserve where claimID = @claimId", con);
                cmd.Parameters.AddWithValue("@claimId", claimId);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ClaimReserveForm claimReserveForm = new ClaimReserveForm();
                    claimReserveForm.CRId = Convert.ToInt32(dr["CRId"]);
                    //claimReserveForm.ClaimId = (ClaimFormsModel)(dr["ClaimId"]);
                    //claimReserveForm.reserveId = (ReserveFormModel)(dr["reserveId"]);
                    claimReserveForm.nameOfFirstNation = Convert.ToString(dr["nameOfFirstNation"]);
                    claimReserveForm.provinceOrTerritory = Convert.ToString(dr["provinceOrTerritory"]);
                    claimReserveForm.firstNationBandNumber = Convert.ToString(dr["firstNationBandNumber"]);
                    claimReserveForm.waterAdvisoryStartDate = Convert.ToDateTime(dr["waterAdvisoryStartDate"]);
                    claimReserveForm.waterAdvisoryEndDate = Convert.ToDateTime(dr["waterAdvisoryEndDate"]);
                    claimReserveForm.fromMonth = Convert.ToString(dr["fromMonth"]);
                    claimReserveForm.fromYear = Convert.ToInt32(dr["fromYear"]);
                    claimReserveForm.toMonth = Convert.ToString(dr["toMonth"]);
                    claimReserveForm.toYear = Convert.ToInt32(dr["toYear"]);
                    lstClaimReserveForm.Add(claimReserveForm);
                }
                con.Close();
                return lstClaimReserveForm;
            }
        }

        public bool InsertFirstNation(ClaimReserveForm claimReserveForm)
        {
            try
            {
                context.Add(claimReserveForm);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool InsertLookupRecord(ReserveFormModel reserveFormModel)
        {
            try
            {
                context.Add(reserveFormModel);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertSectionOne(ClaimFormsModel claimFormsModel, int fileId)
        {
            try { 
            context.Add(claimFormsModel);
            context.SaveChanges();

                int claimId = GetClaimId(claimFormsModel);
                if (fileId != 0)
                {
                    var status = InsertDataToClaimFiles(claimId, fileId);
                }
                return claimId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetClaimId(ClaimFormsModel model)
        {
           return context.Claims.Where(x => x.userClaimID == model.userClaimID).Select(z => z.claimID).FirstOrDefault();
        }

        public ClaimFormsModel GetAllDataofClaims(int claimId)
        {
            return context.Claims.Find(claimId);
        }

        private bool InsertDataToClaimFiles(int claimId, int fileId)
        {
            string connectionString = configuration.GetConnectionString("DatabaseConnection");
            int i = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand("Insert into ClaimFiles values (@claimId,@fileId)", con);
                cmd.Parameters.AddWithValue("@claimId", claimId);
                cmd.Parameters.AddWithValue("@fileId", fileId);
                con.Open();
                i = cmd.ExecuteNonQuery();
                con.Close();

            }
            if(i > 0)
                return true; else return false;
        }

       public ClaimFormsModel GetFilledSectionDataForUpdate(int claimId)
        {
            return context.Claims.Find(claimId);
        }

        public bool InsertSectionOneB(ClaimFormsModel claimFormsModel)
        {
            try
            {
                var data = context.Claims.Attach(claimFormsModel);
                context.Entry(claimFormsModel).Property(x => x.chequeOrDepositFormFile).IsModified= true;
                //data.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool InsertSectionThree(ClaimFormsModel claimFormsModel)
        {
            try
            {
                var data = context.Claims.Attach(claimFormsModel);
                context.Entry(claimFormsModel).Property(x => x.authorizationFile).IsModified = true;
                //data.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool InsertSectionFourA(ClaimFormsModel claimFormsModel)
        {
            try
            {
                var data = context.Claims.Attach(claimFormsModel);
                context.Entry(claimFormsModel).Property(x => x.willYouBeClaimingSpecifiedInjuries).IsModified = true;
                //data.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ClaimFormsModel GetSectionOneB(int claimId)
        {
            return context.Claims.Find(claimId);
        }
    }
}
