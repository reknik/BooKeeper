using BooKeeper.Models;
using BooKeeper.Models.DTO;
using BooKeeper.Repositories;
using ObjectLibrary;
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
using WinFormsApp1;

namespace BooKeeper;
public partial class UserForm : Form
{

    private readonly User _user;

    private readonly IBookRepository _bookRepository;

    private readonly ICategoryRepository _categoryRepository;

    private readonly LoginForm _loginForm;

    public UserForm(User user, IBookRepository bookRepository, ICategoryRepository categoryRepository, LoginForm loginForm)
    {
        this._user = user;
        this._bookRepository = bookRepository;
        this._categoryRepository = categoryRepository;
        this._loginForm = loginForm;
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
        userBookList.Items.Clear();
        List<Book> books = _bookRepository.GetBooksByUser(_user).ToList();
        if (!ObjectUtils.isEnumerableEmpty(books))
        {
            _bookRepository.GetBooksByUser(_user).ToList().ForEach(book => userBookList.Items.Add(book));
        }
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
        initializeUserBookList();

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
        try {
            userBookTextBox.Text = _bookRepository.GetBookByIdWithCategory(selectedBook.Id).ToString();
        }
        catch (NullReferenceException)
        {
            userBookTextBox.Text = "Books couldn't be found";
        }
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
        try 
        { 
            allBooksTextBox.Text = _bookRepository.GetBookByIdWithCategory(selectedBook.Id).ToString();
        }
        catch (NullReferenceException)
        {
            allBooksTextBox.Text = "Books couldn't be found";
        }
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

    private void returnButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        _loginForm.Show();
        this.Close();
    }

    private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        _loginForm.Close();
    }
}
