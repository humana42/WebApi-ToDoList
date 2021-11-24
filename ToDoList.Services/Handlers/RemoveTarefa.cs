using ToDoList.Core.Models;
using ToDoList.Data;

namespace ToDoList.Services.Handlers
{
    public class RemoveTarefa
    {
        private IDataRepository _context;
        public RemoveTarefa(IDataRepository context)
        {
            _context = context;
        }

        public CommandResult Remover(int id)
        {
            try
            {
                _context.RemoverTarefa(id);
                return new CommandResult(true);
            }
            catch
            {
                return new CommandResult(false);
            }
        }
    }
}
