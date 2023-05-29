public class Mutation {
    public Book? AddBook (string title, Author author) {
        Book book = new () {Title = title, Id = Guid.NewGuid ().ToString (), Author = author };
        BookRepository.Add (book);
        return book;
    }
}