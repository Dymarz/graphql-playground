public class Query
{
    [UseFiltering]
    [UseSorting]
    public IEnumerable<Book> GetBooks() =>
        BookRepository.GetAll();

    public Book? GetBook(string id) => BookRepository.GetAll().FirstOrDefault(x => x.Id == id);
}
