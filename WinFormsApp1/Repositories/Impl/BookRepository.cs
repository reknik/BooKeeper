using BooKeeper.Data;
using BooKeeper.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooKeeper.Repositories.Impl;

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

    public Book? GetBookByIdWithCategory(int selectedBookId) => _dbContext.Books.Include(p => p.CategoryNavigation).FirstOrDefault(book => book.Id.Equals(selectedBookId));

    public IEnumerable<Book> GetBooksByUser(User user) => _dbContext.Books.Include(p=> p.UserBooks).Where(book => book.UserBooks.Any(userbooks => userbooks.UserId.Equals(user.Id)));

    public void ReserveBook(User user, Book book)
    {
        book.UserBooks.Add(new UserBook
        {
            Book = book,
            User = user
       });
        book.Available--;
        _dbContext.SaveChanges();
    }
}
