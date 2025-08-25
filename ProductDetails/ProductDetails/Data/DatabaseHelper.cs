using ProductDetails.Interfaces;

namespace ProductDetails.Data
{
    public class DatabaseHelper : IDatabaseHelper
    {
        public DatabaseHelper(IDbContext dbContext)
        {
            ConnectionString = dbContext.GetConnectionString();
        }
        public string ConnectionString { get; set; }
    }
}
