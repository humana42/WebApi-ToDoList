
using Microsoft.EntityFrameworkCore;
using ToDoList.Core.Models;

namespace ToDoList.Data
{
    public class ToDoListContext : DbContext
    {
        public DbSet<Tarefa> Tarefa { get; set; }

        public ToDoListContext(DbContextOptions options) : base(options)
        {
            this.Database.EnsureCreated();

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TarefaConfiguration());
        }
    }
}
