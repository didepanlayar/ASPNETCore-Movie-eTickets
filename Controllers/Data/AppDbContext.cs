using Microsoft.EntityFrameworkCore;

namespace Movie_eTickets.Controllers.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
    }
}
