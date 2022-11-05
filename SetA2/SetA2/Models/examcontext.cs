using Microsoft.EntityFrameworkCore;

namespace SetA2.Models
{
    public class examcontext:DbContext
    {
        public examcontext(DbContextOptions<examcontext> options) : base(options)
        {

        }
        public DbSet<exam> Exams { get; set; }
    }
}
