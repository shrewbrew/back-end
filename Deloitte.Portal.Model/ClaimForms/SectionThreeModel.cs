using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deloitte.Portal.Model.ClaimForms
{
    public class SectionThreeModel : ClaimFormsModel
    {
        public IFormFile AuthorizationFile { get; set; }
    }
}
