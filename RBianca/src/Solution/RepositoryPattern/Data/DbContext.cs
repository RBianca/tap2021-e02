namespace RepositoryPattern.Data
{
    public class DbContext
    {
        private DbContextOptions<DnaContext> options;

        public DbContext(DbContextOptions<DnaContext> options)
        {
            this.options = options;
        }
    }
}