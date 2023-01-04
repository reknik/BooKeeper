using BooKeeper.Data;
using BooKeeper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooKeeper.Services.Impl;

public class BookRepository : IBookRepository
{
    private readonly BookDbContext _dbContext;
    private readonly IEnumerable<Book> _books;

    public BookRepository(BookDbContext dbContext)
    {
        this._dbContext = dbContext;
        this._books = _dbContext.Books;
    }

    public IEnumerable<Book> GetAllBooks() => _books;

    public Book? GetBookById(int selectedBookId) => _books.FirstOrDefault(book => book.Id.Equals(selectedBookId));

    public IEnumerable<Book> GetBooksByUser(User user) => _books.Where(book => book.Loaner.Equals(user));
}
