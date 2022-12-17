using System;
using System.Collections.Generic;
using System.Text;

namespace Deloitte.Portal.DataAccess.Test
{
    public interface ITestUser
    {
        void InsertRecord(string regnumber);
        string GetRegNumber();
    }
}
