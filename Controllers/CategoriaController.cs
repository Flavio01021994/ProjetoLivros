using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoLivros.Interfaces;
using ProjetoLivros.Models;

namespace ProjetoLivros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        // Injetar o Repository
        private readonly ICategoriaRepository _repository;

        public CategoriaController(ICategoriaRepository repository)
        { 
            _repository = repository;
        }

        [HttpGet]
        public IActionResult ListarTodos()
        {
            var categorias = _repository.ListarTodos();
            return Ok(categorias);
        }

        [HttpPost]
        public IActionResult Cadastrar(Categoria categoria) 
        { 
            _repository.Cadatrar(categoria);
            return Created();
        }
             
    }
}
