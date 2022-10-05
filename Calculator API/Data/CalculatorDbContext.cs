using Calculator_API.Model;
using Microsoft.EntityFrameworkCore;

namespace Calculator_API.Data
{
    public class CalculatorDbContext : DbContext
    {
        public CalculatorDbContext(DbContextOptions<CalculatorDbContext> options) : base(options)
        {

        }
        public DbSet<Calculator> Calculators { get; set; }
    }
}
