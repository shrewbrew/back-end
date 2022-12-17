using Deloitte.Portal.Model.ClaimForms;
using System;
using System.Collections.Generic;
using System.Text;
using static Deloitte.Portal.Service.UserService.Services;

namespace Deloitte.Portal.Service.UserService
{
    public interface IServices
    {
        bool IsAuthenticated();
        string GetConnectionString();
        string GetUserEmail();

        string FileUploadLocation();

       IEnumerable<fileDataCollection> ProcessToUploadGovernmentID(SectionOneModel model, string requestId);


        string ProcessToUploadChequeAndDeposit(PaymentInformationSectionOne model);
        string ProcessToUploadAuthorizationFile(SectionThreeModel model);
        string GetRegNumber();

        string GetUserMachineIpAddres();
    }
}
