using Deloitte.Portal.Model.Account;
using Deloitte.Portal.Model.ClaimForms;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deloitte.Portal.DataAccess.Account
{
    public class SQLAccountRepository : ISQLAccountRepository
    {
        private readonly AppDbContext context;
        private readonly IConfiguration configuration;

        public SQLAccountRepository(AppDbContext context, IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }

        public IEnumerable<UserData> GetUserId(string email)
        {
            List<UserData> lstUserData = new List<UserData>();
            string connectionString = configuration.GetConnectionString("DatabaseConnection");
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Id, Email from AspNetUsers where Email = @email", con);
                cmd.Parameters.AddWithValue("@email", email);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    UserData userData = new UserData();
                    userData.UserId = Convert.ToString(dr["Id"]);
                    userData.UserEmail = Convert.ToString(dr["Email"]);
                    lstUserData.Add(userData);
                }
                con.Close();
            }
           return lstUserData;
        }
    }
   

}
