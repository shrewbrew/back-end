using Deloitte.Portal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Deloitte.Portal.DataAccess.Test
{
    public class TestUser : ITestUser
    {
        private readonly AppDbContext context;

        public TestUser(AppDbContext context)
        {
            this.context = context;
        }

        public string GetRegNumber()
        {
            throw new NotImplementedException();
        }

        //public string GetRegNumber()
        //{
        //    int Id = context.DemoTable.Max(p => p.Id);
        //    string regnumber = context.DemoTable.Where(x => x.Id == Id).Select(x => x.RegNumber).FirstOrDefault();
        //    if(!string.IsNullOrEmpty(regnumber))
        //        {
        //        return regnumber;
        //    }
        //    return null;
        //}

        public void InsertRecord(string regnumber)
        {
            Regex re = new Regex(@"([a-zA-Z]+)(\d+)");
            Match result = re.Match(regnumber);

            string Partone = result.Groups[1].Value;
            string numberPart = result.Groups[2].Value;
            int val = Convert.ToInt32(numberPart);
            int s = val + 1;
            string Parttwo = s.ToString().PadLeft(3, '0');
            string newRegnumber = Partone + Parttwo ;

            Model.Demo model = new Model.Demo();
            model.RegNumber = newRegnumber;
            model.Name= "Sourav";

            context.Add(model);
            context.SaveChanges();
        }
    }
}
