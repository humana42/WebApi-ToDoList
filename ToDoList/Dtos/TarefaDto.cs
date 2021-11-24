using System;
using System.ComponentModel.DataAnnotations;
using ToDoList.Core.Enums;

namespace ToDoList.WebApi.Dtos
{
    public class TarefaDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O Título é obrigatório")]
        [StringLength(60, ErrorMessage = "O Título não pode passar de 60 caracteres")]
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        [Required(ErrorMessage = "A DataInicio é obrigatório")]
        public DateTime DataInicio { get; set; }
        [Required(ErrorMessage = "A DataFinal é obrigatório")]
        public DateTime DataFinal { get; set; }
        public SituacaoTarefa  Situacao { get; set; }
    }
}
