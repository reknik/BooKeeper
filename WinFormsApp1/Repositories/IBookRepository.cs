using BooKeeper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooKeeper.Repositories;

public interface IBookRepository
{
    IEnumerable<Book> GetBooksByUser(User user);

    IEnumerable<Book> GetAllBooks();
    Book? GetBookById(int selectedBookId);

    Book? GetBookByIdWithCategory(int selectedBookId);

    void ReserveBook(User user, Book book);
}
