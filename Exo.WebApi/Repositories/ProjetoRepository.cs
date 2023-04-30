//3 passo Trabalhar com a classe projeto repositorie: Esta classe **projetoRepository** faz juntamente o classe **projetosController** a ligacao e manipulacao com o banco de dados.

using Exo.WebApi.Contexts;
using Exo.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exo.WebApi.Repositories
{
    public class ProjetoRepository
    {
        //Cria uma variavel chamada de ExoContext:
        private readonly ExoContext _context;
        public ProjetoRepository(ExoContext context)
        {
            _context = context;
        }
        //Método chamado Listar aqui em ProjetoRepository e outro método Listar em ProjetosController.
        public List<Projeto> Listar()
        {
            return _context.Projetos.ToList();
        }
    }
}

