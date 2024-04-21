using Microsoft.EntityFrameworkCore;

namespace WebApplication3.data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options ) : base( options ) { }

        #region DbSet 
        public DbSet<HangHoa> HangHoas { get; set; }
        public DbSet<Loai> Loais { get; set; }
        #endregion
    }
}