using RevisoHomework.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Routing;

namespace RevisoHomeworkWeb.Controllers
{
    public class WorkController : ApiController
    {
        // GET: api/Work
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Work/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Work
        public void Post([FromBody] Work work)
        {
            var helper = new UrlHelper(Request);
        }

        // PUT: api/Work/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Work/5
        public void Delete(int id)
        {
        }
    }
}
