namespace ProductDetails.Interfaces
{
    public interface IDbContext
    {
        string ServerName { get; set; }
        string DatabaseName { get; set; }
        string UserId { get; set; }
        string Password { get; set; }
        string GetConnectionString();
    }
}
