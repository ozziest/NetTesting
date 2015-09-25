using System.Collections.Generic;
using Microsoft.AspNet.Mvc;

namespace WebAPIApplication.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            Ozziest.ManagerClass myManager = new Ozziest.ManagerClass();
            myManager.Test();
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        
    }
}
