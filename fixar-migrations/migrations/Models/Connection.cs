using Microsoft.EntityFrameworkCore;


public class ProductContext : DbContext
{
    public DbSet<Products> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=127.0.0.1;Database=sql_server_db;User=SA;Password=Password12;");
    }
}