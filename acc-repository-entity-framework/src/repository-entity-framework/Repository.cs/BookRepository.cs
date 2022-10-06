using Microsoft.EntityFrameworkCore;


public class BookRepository
{
    protected readonly DatabaseContext _context;

    public BookRepository(DatabaseContext? context)
    {
        _context = context;
    }


    public List<Book?> GetBookList()
    {
        var query = _context.Books.ToList();

        return query;
    }

    public Book GetById(int id)
    {
        var ResultBook = _context.Books.Where(book => book.BookId == id).Include(e => e.Author).Include(e => e.Publisher).First();

        return ResultBook;
    }

    public Book Insert(Book book)
    {
      _context.Add(book);
      _context.SaveChanges();
      return book;
    }

    public virtual void Update(Book book)
    {
     _context.Update(book);
     _context.SaveChanges();
    }

      public virtual void Delete(int id)
    {
        //realizamos uma busca em nossa base para encontrarmos o livro e suas associações, pelo id do livro, que gostariamos de excluir
        var book = _context.Books.Include(e => e.Author).Include(e => e.Publisher).Single(p => p.BookId == id);
        _context.Remove(book); // removemos o livro
        _context.Remove(book.Author); //removemos o autor relacionado
        _context.Remove(book.Publisher); // removeos a editora associada
        _context.SaveChanges(); //ao final salvamos nossa exclusão, para isso se refletir em nosso banco
    }
}
