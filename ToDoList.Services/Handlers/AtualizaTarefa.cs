using ToDoList.Core.Models;
using ToDoList.Data;

namespace ToDoList.Services.Handlers
{
    public class AtualizaTarefa
    {
        private IDataRepository _context;
        public AtualizaTarefa(IDataRepository context)
        {
            _context = context;
        }

        public CommandResult Atualizar(Tarefa tarefa)
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
                _context.EditarTarefa(tarefa);
                return new CommandResult(true);
            }
            catch
            {
                return new CommandResult(false);
            }
        }
    }
}
