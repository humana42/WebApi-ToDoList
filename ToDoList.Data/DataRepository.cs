using System.Collections.Generic;
using System.Linq;
using ToDoList.Core.Models;

namespace ToDoList.Data
{
    public class DataRepository : IDataRepository
    {
        private ToDoListContext _context;

        public DataRepository(ToDoListContext context)
        {
            _context = context;
        }

        public Tarefa RetornarTarefaId(int id)
        {
            return _context.Tarefa.FirstOrDefault(t => t.Id == id);
        }

        public void EditarTarefa(params Tarefa[] tarefa)
        {
            _context.Tarefa.UpdateRange(tarefa);
            _context.SaveChanges();
        }
        public void RemoverTarefa(int id)
        {
            var tarefa = _context.Tarefa.FirstOrDefault(t => t.Id == id);    
            _context.Tarefa.RemoveRange(tarefa);
            _context.SaveChanges();
        }

        public void InserirTarefas(params Tarefa[] tarefas)
        {
            _context.Tarefa.AddRange(tarefas);
            _context.SaveChanges();
        }

        public IList<Tarefa> RetornarTarefas()
        {
            return _context.Tarefa.ToList();
        }
    }
}
