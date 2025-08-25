using ProductDetails.Interfaces;
using ProductDetails.Models;

namespace ProductDetails.Service
{
    public class DatabaseService : IDatabaseService
    {
        private IDatabaseHelper _dbHelper;
        private string ConnectionString;
        public DatabaseService(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
            ConnectionString = _dbHelper.ConnectionString;
        }
        
        Task<bool> IDatabaseService.InsertProduct()
        {
            throw new NotImplementedException();
        }

        Task<bool> IDatabaseService.UpdateProduct()
        {
            throw new NotImplementedException();
        }

        Task<bool> IDatabaseService.DeleteProduct()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Product>> IDatabaseService.GetProducts()
        {
            throw new NotImplementedException();
        }

        public async Task ExecuteQuery(string sqlquery, string connectionString)
        {
            await using var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString);
            await using var command = new Microsoft.Data.SqlClient.SqlCommand(sqlquery, connection);

            await connection.OpenAsync();
            await command.ExecuteNonQueryAsync();
            await connection.CloseAsync();
        }
    }
}
