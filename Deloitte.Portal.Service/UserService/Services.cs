using Deloitte.Portal.DataAccess;
using Deloitte.Portal.Model.ClaimForms;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Microsoft.AspNetCore.HttpOverrides;

namespace Deloitte.Portal.Service.UserService
{
    public class Services : IServices
    {
        private readonly IConfiguration configuration;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly AppDbContext context;

        public Services(IConfiguration configuration, IHttpContextAccessor httpContextAccessor, AppDbContext context)
        {
            this.configuration = configuration;
            this.httpContextAccessor = httpContextAccessor;
            this.context = context;
        }

        public string GetConnectionString()
        {
            string connectionString = configuration.GetConnectionString("DatabaseConnection");
            return connectionString;
        }
        public  string GetUserMachineIpAddres()
        {
          string hostName =   Dns.GetHostName();
          string userIP =  httpContextAccessor.HttpContext?.Connection?.RemoteIpAddress?.ToString();
          return userIP;
        }
        public string FileUploadLocation()
        {
            return @"\\isilon\Relativity\Prod\Staging\Portal POC";
        }

        public bool IsAuthenticated()
        {
          return  httpContextAccessor.HttpContext.User.Identity.IsAuthenticated;
        }

        public string GetUserEmail()
        {
            return httpContextAccessor.HttpContext.User.Identity.Name;
        }

        public IEnumerable<fileDataCollection> ProcessToUploadChequeAndDeposit(PaymentInformationSectionOne model)
        {
            List<fileDataCollection> lstfile = new List<fileDataCollection>();
            fileDataCollection fileDataCollection = new fileDataCollection();
            string filename = null;
            if (model.CheckorDepositFile != null)
            {
                string uploadFileLocation = FileUploadLocation();
                filename = Guid.NewGuid().ToString()+"_deposit_"+ model.CheckorDepositFile.FileName;
                string filePath = Path.Combine(uploadFileLocation, filename);
                using (var filestream = new FileStream(filePath, FileMode.Create))
                {
                    model.CheckorDepositFile.CopyTo(filestream);

                    Deloitte.Portal.Model.ClaimForms.File filetype = new Model.ClaimForms.File();
                    filetype.fileName = filename;
                    filetype.fileLocation = filePath;
                    filetype.fileSize = Convert.ToString(model.CheckorDepositFile.Length);
                    filetype.documentType = "Deposit";
                    filetype.fileExtension = Path.GetExtension(model.CheckorDepositFile.FileName);
                    context.Add(filetype);
                    context.SaveChanges();
                }
                int fileId = GetInsertedFileID(filename);
                fileDataCollection.filename = filename;
                fileDataCollection.fileId = fileId;
                lstfile.Add(fileDataCollection);
            }
            return lstfile;
        }
        public IEnumerable<fileDataCollection> ProcessToUploadSwornFile(SectionFiveModel model)
        {
            List<fileDataCollection> lstfile = new List<fileDataCollection>();
            fileDataCollection fileDataCollection = new fileDataCollection();
            string filename = null;
            if (model.swornFile != null)
            {
                string uploadFileLocation = FileUploadLocation();
                filename = Guid.NewGuid().ToString() + "_SwornAffirmation_" + model.swornFile.FileName;
                string filePath = Path.Combine(uploadFileLocation, filename);
                using (var filestream = new FileStream(filePath, FileMode.Create))
                {
                    model.swornFile.CopyTo(filestream);

                    Deloitte.Portal.Model.ClaimForms.File filetype = new Model.ClaimForms.File();
                    filetype.fileName = filename;
                    filetype.fileLocation = filePath;
                    filetype.fileSize = Convert.ToString(model.swornFile.Length);
                    filetype.documentType = "Sworn Affirmation";
                    filetype.fileExtension = Path.GetExtension(model.swornFile.FileName);
                    context.Add(filetype);
                    context.SaveChanges();
                }
                int fileId = GetInsertedFileID(filename);
                fileDataCollection.filename = filename;
                fileDataCollection.fileId = fileId;
                lstfile.Add(fileDataCollection);
            }
            return lstfile;
        }
        public IEnumerable<fileDataCollection> ProcessToUploadAuthorizationFile(SectionThreeModel model)
        {
            List<fileDataCollection> lstfile = new List<fileDataCollection>();
            fileDataCollection fileDataCollection = new fileDataCollection();
            string filename = null;
            if (model.AuthorizationFile != null)
            {
                string uploadFileLocation = FileUploadLocation();
                filename = Guid.NewGuid().ToString() + "_Authorization_" + model.AuthorizationFile.FileName;
                string filePath = Path.Combine(uploadFileLocation, filename);
                using (var filestream = new FileStream(filePath, FileMode.Create))
                {
                    model.AuthorizationFile.CopyTo(filestream);

                    Deloitte.Portal.Model.ClaimForms.File filetype = new Model.ClaimForms.File();
                    filetype.fileName = filename;
                    filetype.fileLocation = filePath;
                    filetype.fileSize = Convert.ToString(model.AuthorizationFile.Length);
                    filetype.documentType = "Authorization";
                    filetype.fileExtension = Path.GetExtension(model.AuthorizationFile.FileName);
                    context.Add(filetype);
                    context.SaveChanges();
                }
                int fileId = GetInsertedFileID(filename);
                fileDataCollection.filename = filename;
                fileDataCollection.fileId = fileId;
                lstfile.Add(fileDataCollection);
            }
            return lstfile;
        }
        public class fileDataCollection
        {
            public int fileId { get; set; }
            public string filename { get; set; }
        }
        public IEnumerable<fileDataCollection> ProcessToUploadGovernmentID(SectionOneModel model, string requestId)
        {
            List<fileDataCollection> lstfile = new List<fileDataCollection>();
            fileDataCollection fileDataCollection= new fileDataCollection();
            string filename = null;
            if (model.GovernmentIDFile != null)
            {
                string uploadFileLocation = FileUploadLocation();
                filename = Guid.NewGuid().ToString() + "_" + requestId +"_"+ model.GovernmentIDFile.FileName;
                string filePath = Path.Combine(uploadFileLocation, filename);
                using (var filestream = new FileStream(filePath, FileMode.Create))
                {
                    model.GovernmentIDFile.CopyTo(filestream);

                    Deloitte.Portal.Model.ClaimForms.File filetype = new Model.ClaimForms.File();
                    filetype.fileName = filename;
                    filetype.fileLocation = filePath;
                    filetype.fileSize = Convert.ToString(model.GovernmentIDFile.Length);
                    filetype.documentType = "Government ID";
                    filetype.fileExtension = Path.GetExtension(model.GovernmentIDFile.FileName);
                    context.Add(filetype);
                    context.SaveChanges();
                }
                int fileId = GetInsertedFileID(filename);
                fileDataCollection.filename = filename;
                fileDataCollection.fileId = fileId;
                lstfile.Add(fileDataCollection);
                
            }
            return lstfile;
        }

        private int GetInsertedFileID(string filenames)
        {
          int data =  context.Files.Where(x => x.fileName == filenames).Select(y => y.fileId).FirstOrDefault();
            return data;
        }

        public string GetRegNumber()
        {
            string regNumberPrefix = "REQ000";
            int Id = context.Claims.Max(p => p.claimID);
            int newId = Id + 1;
            string regNumber = regNumberPrefix+ newId;
            return regNumber;

        }
    }
}
