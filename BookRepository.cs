public static class BookRepository {
    private static List<Book> _books = new () {
        new () {
        Title = "C# in Depth",
        Id = Guid.NewGuid ().ToString (),
        Author = new () { Name = "Max Schmidt" }
        },
        new () {
        Title = "Ruby in Depth",
        Id = Guid.NewGuid ().ToString (),
        Author = new () { Name = "Fritz Müller" }
        },
        new () {
        Title = "F# in Depth",
        Id = Guid.NewGuid ().ToString (),
        Author = new () { Name = "Hannes Herbst" }
        },
        new () {
        Title = "Java in Depth",
        Id = Guid.NewGuid ().ToString (),
        Author = new () { Name = "Bob Marlie" }
        }
    };

    public static void Add (Book book) {
        _books.Add (book);
    }

    public static IEnumerable<Book> GetAll () {
        return _books;
    }

}