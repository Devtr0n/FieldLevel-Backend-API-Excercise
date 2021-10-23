using Microsoft.EntityFrameworkCore;

namespace FieldLevel.Data
{
    public class FieldLevelDbContext : DbContext
    {
        public DbSet<RequestStamp> RequestStamps { get; set; }

        public FieldLevelDbContext(DbContextOptions<FieldLevelDbContext> context) : base(context)
        {
        }
    }
}