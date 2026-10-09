using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using WebAPI.Model;
namespace WebAPI.Infraestrutura
{
    public class ConnectionContext :DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost; port=5432;Database=employee_sample;user Id=postgres;Password=1234");
        }
    }
}
