using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PL.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        [Route("api/empl/test")]
        public HttpResponseMessage Get()
        {
            try
            {
                
                return Request.CreateResponse(HttpStatusCode.OK,"Ebrahim");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
