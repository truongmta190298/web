using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BTL_WED.Models.Emty;
using BTL_WED.Models.Function;
namespace BTL_WED.Controllers
{
    public class DefaultController : ApiController
    {
        // GET: api/Default
        
        public IEnumerable<Host> GetListHost()
        {
            return new F_Host().DS_Host.ToList();
        }

        // GET: api/Default/5
        public Host GetHost (int id)
        {
            return new F_Host().FindEntity(id);
        }

        // POST: api/Default
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Default/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Default/5
        public void Delete(int id)
        {
        }
    }
}
