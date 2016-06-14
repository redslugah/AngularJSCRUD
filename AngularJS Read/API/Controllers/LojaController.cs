using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace API.Controllers
{
    public class LojaController : ApiController
    {
        static List<Loja> listaLojas = new List<Loja>
        {
              new Loja {Id=1, Nome="Bar do Zé", Categoria= "Bar", Rua="Barmoleno Luiz", Numero= 451, Url= "https://media-cdn.tripadvisor.com/media/photo-s/06/26/f7/d8/bar-do-ze.jpg" },
              new Loja {Id=2, Nome="Old Dog", Categoria= "Dogueria", Rua="Marcelo Muniz", Numero= 2632, Url= "https://media-cdn.tripadvisor.com/media/photo-s/06/26/f7/d8/bar-do-ze.jpg" },
              new Loja {Id=3, Nome="Orly", Categoria= "Padaria", Rua="Presidente Venério", Numero= 75, Url= "https://media-cdn.tripadvisor.com/media/photo-s/06/26/f7/d8/bar-do-ze.jpg" }

        };
        public IHttpActionResult Get()
        {
            return Ok(listaLojas);
        }
        public IHttpActionResult Get(int id)
        {
            var loja = listaLojas.Find(x => x.Id == id);
            return Ok(loja);
        }
        // GET: api/Loja
        /*
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Loja/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Loja
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Loja/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Loja/5
        public void Delete(int id)
        {
        }
        */
    }
}
