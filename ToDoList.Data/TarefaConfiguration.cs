using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoList.Core.Models;

namespace ToDoList.Data
{
    public class TarefaConfiguration : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder
                .ToTable("tasks");

            builder
                .Property(a => a.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("task_id")
                .IsRequired();

            builder
                .Property(a => a.Titulo)
                .HasColumnName("title")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(a => a.DataInicio)
                .HasColumnName("initial_date")
                .HasColumnType("datetime")
                .IsRequired();

            builder
                .Property(a => a.DataFinal)
                .HasColumnName("final_date")
                .HasColumnType("datetime")
                .IsRequired();

            builder
                .Property(a => a.Descricao)
                .HasColumnName("description")
                .HasColumnType("varchar(100)");

            builder
                .Property(a => a.Situacao)
                .HasColumnName("situation")
                .HasColumnType("varchar(20)")
                .IsRequired();
        }
    }
}
