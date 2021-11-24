using ToDoList.Core.Models;
using ToDoList.Data;

namespace ToDoList.Services.Handlers
{
     public class CriarNovaTarefa
    {
        private IDataRepository _context;

        public CriarNovaTarefa(IDataRepository context)
        {
            _context = context;
        }

        public CommandResult Inserir(Tarefa tarefa)
        {
            try
            {
                var dataTarefa = new Tarefa
                (
                    id: tarefa.Id,
                    titulo: tarefa.Titulo,
                    descricao: tarefa.Descricao,
                    dataInicio: tarefa.DataInicio,
                    dataFinal: tarefa.DataFinal,
                    situacao: tarefa.Situacao
                );
                _context.InserirTarefas(tarefa);
                return new CommandResult(true);
            }
            catch
            {
                return new CommandResult(false);
            }
        }
    }
}
