//4 passo Trabalhar com a classe 

using Exo.WebApi.Models;
using Exo.WebApi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Exo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetosController : ControllerBase
    {
        //Cria uma variável:
        private readonly ProjetoRepository _projetoRepository;

        //Um construtor:
        public ProjetosController(ProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }
        //Método Get:
        [HttpGet]
        //Esse Método Listar  trabalha com o método Listar da classe projetoRepository :
        public IActionResult Listar()
        {
            return Ok(_projetoRepository.Listar());
        }
    }
}