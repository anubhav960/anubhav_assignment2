using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace anubhav_assignment2.Controllers
{

    /// <summary>
    /// test code ......IGNORE THIS CONTROLLER !!!
    /// </summary>
    public class assignment2Controller : ApiController
    {
        [Route("api/assignment2/abc")]
        [HttpGet]
        public string Abc() { return "hello"; }
    }
}
