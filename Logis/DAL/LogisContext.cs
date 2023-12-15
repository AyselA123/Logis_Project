using Logis.Models;
using Microsoft.EntityFrameworkCore;

namespace Logis.DAL
{
    public class LogisContext:DbContext
    {
        public LogisContext(DbContextOptions<LogisContext> options):base(options) 
        {
            
        }

        public DbSet<Service> Services { get; set; }
    }
}
