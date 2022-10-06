using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

public class BookTestContext : DbContext
{
    public DbSet<Book>? Books;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var serviceProvider = new ServiceCollection()
            .AddEntityFrameworkInMemoryDatabase()
            .BuildServiceProvider();

        //usamos a função UseInMemoryDatabase() para indicar que usaremos um banco de dados utilizando a memória interna 
        optionsBuilder.UseInMemoryDatabase("Books").UseInternalServiceProvider(serviceProvider);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>()
            .HasKey(b => b.BookId);

        modelBuilder.Entity<Book>()
            .HasOne(b => b.Author)
            .WithMany(a => a.Books)
            .HasForeignKey(b => b.AuthorId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Book>()
            .HasOne(b => b.Publisher)
            .WithMany(p => p.Books)
            .HasForeignKey(b => b.PublisherId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Book>()
            .Property(b => b.Title)
            .IsRequired()
            .HasMaxLength(100);
    }
}