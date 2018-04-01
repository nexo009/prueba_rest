using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using prueba_rest.Models;

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
        public GeneralPl Get(int id)
        {
            GeneralPl pl = new GeneralPl();
            pl.EXPEDIENTE = "EXPEDIENTE";
            pl.NOMBRE1 = "Smith";
            pl.PATERNO = "Sam";


            return pl;
        }

        // POST: api/GeneralPl
        public void Post([FromBody]GeneralPl value)
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
