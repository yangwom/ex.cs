using Microsoft.EntityFrameworkCore;
public class DatabaseContext : DbContext
{

   public DbSet<Book> Books { get; set; }
    DbSet<Author> Authors { get; set; }

    DbSet<Publisher> Publishers { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=127.0.0.1;Database=;User=SA;Password=Password12;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>()
        .HasOne(b => b.Author) //Explicita que a entidade Book tem uma referência a Author
        .WithMany(a => a.Books) // Define a relação como um Author para muitos Book
        .HasForeignKey(b => b.AuthorId); // Define como chave estrangeira a variável AuthorId

        modelBuilder.Entity<Book>()
            .HasOne(b => b.Publisher)//Explicita que a entidade Book tem uma referência a Publisher
            .WithMany(p => p.Books) // Define a relação como um Publisher para muitos Book
            .HasForeignKey(b => b.PublisherId); // Define como chave estrangeira a variável PublisherId


    }
};