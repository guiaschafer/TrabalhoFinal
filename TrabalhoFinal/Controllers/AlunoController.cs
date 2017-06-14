using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TrabalhoFinal.Models;


namespace TrabalhoFinal.Controllers
{
 
    public class AlunoController : ApiController
    {

        [Route("aluno/buscar")]
        [HttpGet]
        public IHttpActionResult BuscarAluno()
        {
            return Ok("UHUL MOTHERFUCKER");
        }

        [Route("aluno/atualizarAluno")]
        [HttpPut]
        public IHttpActionResult AtualizarAluno(EmptyModel model)
        {
            return Ok();
        }

        [Route("aluno/cadastrarAluno")]
        public IHttpActionResult CadastrarAluno(EmptyModel model)
        {
            return Ok();
        }
    }
}
