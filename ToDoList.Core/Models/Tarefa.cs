using System;
using ToDoList.Core.Enums;

namespace ToDoList.Core.Models
{
    public class Tarefa
    {
        public Tarefa(int id, string titulo, string descricao, DateTime dataInicio, DateTime dataFinal, SituacaoTarefa situacao)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            DataInicio = dataInicio;
            DataFinal = dataFinal;
            Situacao = situacao;
        }

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public SituacaoTarefa Situacao { get; set; }
    }
}
