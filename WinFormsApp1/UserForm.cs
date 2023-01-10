using BooKeeper.Models;
using BooKeeper.Models.DTO;
using BooKeeper.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooKeeper;
public partial class UserForm : Form
{

    private readonly User _user;

    private readonly IBookRepository _bookRepository;

    private readonly ICategoryRepository _categoryRepository;

    

    public UserForm(User user, IBookRepository bookRepository, ICategoryRepository categoryRepository)
    {
        this._user = user;
        this._bookRepository = bookRepository;
        this._categoryRepository = categoryRepository;
        InitializeComponent();
        welcomeLabel.Text = "Welcome, " + user.Username;

        initializeUserBookList();

        initializeAllBooksGridView();
    }

    private void initializeAllBooksGridView()
    {
        allBooksList.DisplayMember = "Title";
        allBooksList.ValueMember = "Id";
        _bookRepository.GetAllBooks().DistinctBy(book => book.Title).ToList().ForEach(book => allBooksList.Items.Add(book)); ;
    }
    private void initializeUserBookList()
    {
        userBookList.DisplayMember = "Title";
        userBookList.ValueMember = "Id";
        List<Book> books = _bookRepository.GetBooksByUser(_user).ToList();
        _bookRepository.GetBooksByUser(_user).ToList().ForEach(book => userBookList.Items.Add(book));
    }

    private void reserveButton_Click(object sender, EventArgs e)
    {
        if(allBooksList.SelectedItem == null)
        {
            MessageBox.Show("Please select a book");
            return;
        }

        DialogResult dr = MessageBox.Show("Are you sure you want to reserve this book?", 
            "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        if(dr != DialogResult.Yes)
        {
            return;
        }
        Book selectedBook = (Book)allBooksList.SelectedItem;
        if (selectedBook.Available.Equals(0))
        {
            MessageBox.Show("No books available");
            return;
        }
        _bookRepository.ReserveBook(_user, selectedBook);
        allBooksList_SelectedIndexChanged(sender, e);
        userBookList_SelectedIndexChanged(sender, e);

    }

    private void userBookList_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(userBookList.SelectedItem == null)
        {
            userBookTextBox.Text = null;
            return;
        }  
        Book? selectedBook = ((Book)userBookList.SelectedItem);
        if (selectedBook == null)
        {
            userBookTextBox.Text = null;
            return;
        }
        userBookTextBox.Text = _bookRepository.GetBookByIdWithCategory(selectedBook.Id).ToString();
    }

    private void allBooksList_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (allBooksList.SelectedItem == null)
        {
            allBooksTextBox.Text = null;
            return;
        }
        Book? selectedBook = ((Book)allBooksList.SelectedItem);
        if (selectedBook == null)
        {
            allBooksTextBox.Text = null;
            return;
        }
        allBooksTextBox.Text = _bookRepository.GetBookByIdWithCategory(selectedBook.Id).ToString();
    }

    private void editBooksButton_Click(object sender, EventArgs e)
    {
        if (allBooksList.SelectedItem == null)
        {
            MessageBox.Show("Please select a book");
            return;
        }

        new EditBookForm((Book)allBooksList.SelectedItem, _categoryRepository, _bookRepository).ShowDialog();
        allBooksList_SelectedIndexChanged(sender, e);
        userBookList_SelectedIndexChanged(sender, e);
    }
}
