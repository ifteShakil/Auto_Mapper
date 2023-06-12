using Microsoft.EntityFrameworkCore;

namespace AutoMapperCore.Models
{
    public class myContext:DbContext
    {
        public myContext(DbContextOptions<myContext> options):base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

    }
}
