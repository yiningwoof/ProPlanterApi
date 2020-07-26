using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ProPlanter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyPlantsController : ControllerBase // instead of Controller b/c is controller without view support
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetString()
        {
            return new string[] {"this", "is", "hard", "coded"};
        }
    }
}