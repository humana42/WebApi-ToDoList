using System.Collections.Generic;
using ToDoList.Core.Models;
using ToDoList.Data;

namespace ToDoList.Services.Handlers
{
    public class ExibeTarefas
    {
        private IDataRepository _context;
        public ExibeTarefas(IDataRepository context)
        {
            _context = context;
        }

        public IList<Tarefa> Exibir()
        {
            return _context.RetornarTarefas();
        }
    }
}
