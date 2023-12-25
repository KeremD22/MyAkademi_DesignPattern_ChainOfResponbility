using Microsoft.EntityFrameworkCore;
using MyAkademi_DesignPattern_ChainOfResponbility.DAL.Entities;

namespace MyAkademi_DesignPattern_ChainOfResponbility.DAL.Context
{
    public class ChainOfRespContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-6NNQ5EJI\\KEREM;initial catalog=DBChain;integrated security=true");
        }

        public DbSet<CustomerProcess> CustomerProcesses { get; set; }

    }
}
