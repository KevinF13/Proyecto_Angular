using Agencia_Turismo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Agencia_Turismo.Controllers
{
    [EnableCors(origins: "*", headers:"*", methods:"GET, POST, PUT, DELETE, OPTIONS")]
    public class AgenciaController : ApiController
    {
        // GET: api/Agencia
        public IEnumerable<Agencia> Get()
        {
            GestorAgencia gAgencia = new GestorAgencia();
            return gAgencia.getAgencia();
        }

        // GET: api/Agencia/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Agencia
        public bool Post([FromBody]Agencia agencia)
        {
            GestorAgencia gAgencia = new GestorAgencia();
            bool res = gAgencia.addAgencia(agencia);

            return res;
        }

        // PUT: api/Agencia/5
        public bool Put(int id, [FromBody] Agencia agencia)
        {
            GestorAgencia gAgencia = new GestorAgencia();
            bool res = gAgencia.updateAgencia(id,agencia);

            return res;
        }

        // DELETE: api/Agencia/5
        public bool Delete(int id)
        {
            GestorAgencia gAgencia = new GestorAgencia();
            bool res = gAgencia.deleteAgencia(id);

            return res;
        }
    }
}
