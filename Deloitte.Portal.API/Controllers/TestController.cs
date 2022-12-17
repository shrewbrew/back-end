using Deloitte.Portal.DataAccess.Test;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Deloitte.Portal.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ITestUser testUser;

        public TestController(ITestUser testUser)
        {
            this.testUser = testUser;
        }
        [HttpGet]

        public IActionResult InsertRecord()
        {
            string RegNumber = testUser.GetRegNumber();
            testUser.InsertRecord(RegNumber);
            return Ok();
        }
    }
}
