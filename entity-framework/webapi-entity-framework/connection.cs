// Importar o EntityFrameworkCore para utilizar DbContext
using Microsoft.EntityFrameworkCore;

public class MyContext : DbContext
{
    // Criar um construtor que envia as configurações de inicialização
    // para o construtor da classe pai DbContext
    public MyContext(DbContextOptions<MyContext> options)
            : base(options)
    {}

    // Adicionamos Student como um DbSet
    public DbSet<Student> Students { get; set; }


     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Verificamos se o banco de dados já foi configurado
        if (!optionsBuilder.IsConfigured)
        {
            // Buscamos o valor da connection string armazenada nas variáveis de ambiente
            var connectionString = Environment.GetEnvironmentVariable("DOTNET_CONNECTION_STRING");

            // Executamos o método UseSqlServer e passamos a connection string a ele
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
};