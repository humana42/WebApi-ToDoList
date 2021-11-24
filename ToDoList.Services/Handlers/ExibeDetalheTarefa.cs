using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Core.Models;
using ToDoList.Data;

namespace ToDoList.Services.Handlers
{
    public class ExibeDetalheTarefa
    {
        private IDataRepository _context;
        public ExibeDetalheTarefa(IDataRepository context)
        {
            _context = context;
        }

        public Tarefa Detalhes(int id)
        {

            return _context.RetornarTarefaId(id);

        }
    }
}
