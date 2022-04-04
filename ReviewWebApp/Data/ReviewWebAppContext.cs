using Microsoft.EntityFrameworkCore;

namespace ReviewWebApp.Data
{
    public class ReviewWebAppContext : DbContext
    {
        public ReviewWebAppContext(DbContextOptions<ReviewWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<ReviewWebApp.Models.User> Review { get; set; }
    }
}
