using BooKeeper.Models;
using BooKeeper.Services;
using BooKeeper.Services.Impl;
using System;
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

        initializeAllBooksList();
    }

    private void initializeAllBooksList()
    {
        allBooks.DisplayMember = "Title";
        allBooks.ValueMember = "Title";
        _bookRepository.GetAllBooks().DistinctBy(book => book.Title).ToList().ForEach(book => allBooks.Items.Add(book));
    }

    private void initializeUserBookList()
    {
        userBookList.DisplayMember = "Title";
        userBookList.ValueMember = "Id";
        _bookRepository.GetBooksByUser(_user).ToList().ForEach(book => userBookList.Items.Add(book));
    }

    private void reserveButton_Click(object sender, EventArgs e)
    {
        DialogResult dr = MessageBox.Show("Are you sure you want to reserve this book?", 
            "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

    }

    private void userBookList_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(userBookList.SelectedValue == null)
        {
            selectedBookTextBox.Text = null;
            return;
        }
        int selectedBookId =  (int) userBookList.SelectedValue;
        Book? selectedBook = _bookRepository.GetBookById(selectedBookId);
        if(selectedBook == null)
        {
            selectedBookTextBox.Text = null;
            return;
        }
        selectedBookTextBox.Text = selectedBook.ToString();
    }
}
