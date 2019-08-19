using Microsoft.EntityFrameworkCore;

namespace BootApi.Models
{
    public class MyContext: DbContext
    {
        public MyContext(DbContextOptions<MyContext> options):base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}
