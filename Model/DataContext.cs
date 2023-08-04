
namespace WaterStartup.Model
{
    public class DataContext: IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Ocean_theme> ocean_Themes{ get; set; }
    }
}
