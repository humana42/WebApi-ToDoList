
using AutoMapper;
using ToDoList.Core.Models;
using ToDoList.WebApi.Dtos;

namespace ToDoList.Profiles
{
    public class TarefaProfiles : Profile
    {
        public TarefaProfiles()
        {
            CreateMap<TarefaDto, Tarefa>();
        }

    }
}
