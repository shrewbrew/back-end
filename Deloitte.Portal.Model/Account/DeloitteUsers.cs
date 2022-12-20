using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deloitte.Portal.Model.Account
{
    public class DeloitteUsers : IdentityUser
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}
