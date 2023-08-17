using ApiClientesNet6.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiClientesNet6.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base (options)
        {
            
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
