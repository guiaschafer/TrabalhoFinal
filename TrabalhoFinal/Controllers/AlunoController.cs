using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TrabalhoFinal.Models;
using TrabalhoFinal.Services;


namespace TrabalhoFinal.Controllers
{
    [RoutePrefix("aluno")]
    public class AlunoController : ApiController
    {
        private ServiceAluno serviceAluno;

        public AlunoController()
        {
            serviceAluno = new ServiceAluno();
        }

        [Route("buscar")]
        [HttpGet]
        public IHttpActionResult BuscarAluno()
        {
            return Ok("UHUL MOTHERFUCKER");
        }

        [Route("atualizarAluno")]
        [HttpPut]
        public IHttpActionResult AtualizarAluno(EmptyModel model)
        {
            return Ok();
        }

        [Route("cadastrarAluno")]
        [HttpPost]
        public IHttpActionResult CadastrarAluno(Aluno model)
        {
            try
            {
                serviceAluno.CadastrarAluno(model);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
