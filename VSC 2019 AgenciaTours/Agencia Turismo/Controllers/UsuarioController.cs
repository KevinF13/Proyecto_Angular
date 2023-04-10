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
    [EnableCors(origins: "*", headers: "*", methods: "GET, POST, PUT, DELETE, OPTIONS")]
    public class UsuarioController : ApiController
    {
        // GET: api/Usuario
        public IEnumerable<Usuario> Get()
        {
            IngresoDeUsuarios ingresoDeUsuarios = new IngresoDeUsuarios();
            return ingresoDeUsuarios.getUsuarios();
        }

        // GET: api/Usuario/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Usuario
        public bool Post([FromBody]Usuario usuario)
        {
            IngresoDeUsuarios ingresoDeUsuarios = new IngresoDeUsuarios();
            bool res = ingresoDeUsuarios.addUsuario(usuario);

            return res;
        }

        // PUT: api/Usuario/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Usuario/5
        public void Delete(int id)
        {
        }
    }
}
