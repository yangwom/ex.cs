using Microsoft.EntityFrameworkCore;
public class MyContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(@"
                Server=127.0.0.1;
                Database= sql_server_db;
                User=SA;
                Password=Password12;
            ");
        }
    }
}