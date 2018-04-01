using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace prueba_rest.Controllers
{
    public class GeneralPlController : ApiController
    {
        // GET: api/GeneralPl
        public IEnumerable<string> Get()
        {
            return new string[] { "Persona1", "Persona2" };
        }

        // GET: api/GeneralPl/5
        public string Get(int id)
        {
            return "Alguna Persona según Id";
        }

        // POST: api/GeneralPl
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/GeneralPl/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/GeneralPl/5
        public void Delete(int id)
        {
        }
    }
}
