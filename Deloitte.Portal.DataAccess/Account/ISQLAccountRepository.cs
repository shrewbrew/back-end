using Deloitte.Portal.Model.Account;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deloitte.Portal.DataAccess.Account
{
    public interface ISQLAccountRepository
    {
        IEnumerable<UserData> GetUserId(string email);
    }
}
