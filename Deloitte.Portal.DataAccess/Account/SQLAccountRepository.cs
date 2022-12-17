using System;
using System.Collections.Generic;
using System.Text;

namespace Deloitte.Portal.DataAccess.Account
{
    public class SQLAccountRepository : ISQLAccountRepository
    {
        private readonly AppDbContext context;

        public SQLAccountRepository(AppDbContext context)
        {
            this.context = context;
        }
    }
}
