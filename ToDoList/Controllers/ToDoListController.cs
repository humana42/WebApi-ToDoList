using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Core.Models;
using ToDoList.Data;
using ToDoList.Services.Handlers;
using ToDoList.WebApi.Dtos;

namespace ToDoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListController : ControllerBase
    {
        private IDataRepository _context;
        private IMapper _mapper;

        public ToDoListController(IDataRepository context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult InserirTarefa([FromBody] TarefaDto tarefaDto)
        {
            if (ModelState.IsValid)
            {
                var tarefa = _mapper.Map<Tarefa>(tarefaDto);
                var handler = new CriarNovaTarefa(_context);
                var result = handler.Inserir(tarefa);
                if (result.IsSuccess)
                {
                    return Ok();
                }
            }
            return BadRequest();
        }

        [HttpGet]
        public IActionResult RetornaTarefas()
        {

            var handler = new ExibeTarefas(_context);
            var result = handler.Exibir();
            if (result != null)
            {
                return Ok(result);
            }
             return BadRequest();

        }

        [HttpGet("{id}")]
        public IActionResult DetalhesTarefa(int id)
        {
            var handler = new ExibeDetalheTarefa(_context);
            var result = handler.Detalhes(id);
            if(result != null)
            {
                return Ok(result);
            }
            return BadRequest();

        }

        [HttpPut("{id}")]
        public IActionResult EditarTarefa(int id, [FromBody] TarefaDto tarefaDto)
        {
            if (ModelState.IsValid)
            {
                var tarefa = _mapper.Map<Tarefa>(tarefaDto);
                var handler = new AtualizaTarefa(_context);
                var result = handler.Atualizar(tarefa);
                if (result.IsSuccess)
                {
                    return Ok();
                }
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult ExcluirTarefa(int id)
        {
            var handler = new RemoveTarefa(_context);
            var result = handler.Remover(id);
            if (result.IsSuccess)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
