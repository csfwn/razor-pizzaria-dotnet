using Microsoft.EntityFrameworkCore;
using RazorPizzaria.Models;

namespace RazorPizzaria.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) 
            : base (options)
        {

        }
    }
}
