DatabaseContext context = new DatabaseContext();
BookRepository bookRepository = new BookRepository(context);

var book = new Book{
    Title = "The Divine Comedy",
    Description = "A journey through the infinite torment of Hell",
    Year = 2013,
    Pages = 811,
    Genre = "Drama",
    Author = new Author
    {
        Name = "Dante Alighieri",
        Email = "mail@mail.com"
    },
    Publisher = new Publisher
    {
        Name = "Paradise Publisher"
    }
};

bookRepository.Insert(book);
