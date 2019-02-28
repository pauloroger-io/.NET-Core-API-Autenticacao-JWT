using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AutenticacaoJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            string texto =

@"Envie um POST para a rota => api/usuario/obtertoken
com o JSON abaixo no body

{
 'usuario': 'fd98fda89fda79f8da798ffds7fdsh79da',
 'senha': 'fd98fda89fda79f8da798ffds7fdsh79daSenha',
 'email': 'fd98fda89fda79f8da798ffds7fdsh79da@gmail.com'
}


Após receber o token, envie um GET para a rota api/usuario/testandotoken com o token como Authorization, TYPE Bearer Token
";

            return texto;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
