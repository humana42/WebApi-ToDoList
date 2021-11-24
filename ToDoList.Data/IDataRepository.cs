using System.Collections.Generic;
using ToDoList.Core.Models;

namespace ToDoList.Data
{
    public interface IDataRepository
    {
        void InserirTarefas(params Tarefa[] tarefas);
        IList<Tarefa> RetornarTarefas();
        void EditarTarefa(params Tarefa[] tarefas);
        Tarefa RetornarTarefaId(int id);
        void RemoverTarefa(int id);
    }
}