using BooKeeper.Data;
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

    private readonly IUserRepository _userRepository;

    private readonly ICategoryRepository _categoryRepository;

    private readonly LoginForm _loginForm;

    private readonly MusicBox _musicBox;

    public UserForm(User user, IBookRepository bookRepository, ICategoryRepository categoryRepository, LoginForm loginForm, MusicBox musicBox, IUserRepository userRepository)
    {
        this._user = user;
        this._bookRepository = bookRepository;
        this._categoryRepository = categoryRepository;
        this._userRepository = userRepository;
        this._loginForm = loginForm;
        this._musicBox = musicBox;
        
        InitializeComponent();
        welcomeLabel.Text = "Welcome, " + user.Username;
        if(user.ProfilePicturePath!= null )
        {
            profilePictureBox.Image = Image.FromFile(user.ProfilePicturePath);
        }
        
        //vlcControl1.Play(new FileInfo(@"C:\Users\Alex\Downloads\library.mp4"));
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

    public void changeProfilePicture(String newProfilePicturePath)
    {
        profilePictureBox.Image = Image.FromFile(newProfilePicturePath);
    }

    private void userBookList_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(userBookList.SelectedItem == null)
        {
            userBookTextBox.Text = null;
            myCoverBox.Image = null;
            return;
        }  
        Book? selectedBook = ((Book)userBookList.SelectedItem);
        if (selectedBook == null)
        {
            userBookTextBox.Text = null;
            myCoverBox.Image = null;
            return;
        }
        try {
            userBookTextBox.Text = _bookRepository.GetBookByIdWithCategory(selectedBook.Id).ToString();
            myCoverBox.Image = Image.FromFile(selectedBook.CoverPath);
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
            allCoverBox.Image = null;
            return;
        }
        Book? selectedBook = ((Book)allBooksList.SelectedItem);
        if (selectedBook == null)
        {
            allBooksTextBox.Text = null;
            allCoverBox.Image = null;
            return;
        }
        try 
        { 
            allBooksTextBox.Text = _bookRepository.GetBookByIdWithCategory(selectedBook.Id).ToString();
            allCoverBox.Image = Image.FromFile(selectedBook.CoverPath);
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

    private void muteButton_Click(object sender, EventArgs e)
    {
        this._musicBox.stop();
    }

    private void playButton_Click(object sender, EventArgs e)
    {
        this._musicBox.play();
    }

    private void nextButton_Click(object sender, EventArgs e)
    {
        this._musicBox.nextSong();
    }

    private void changeProfileButton_Click(object sender, EventArgs e)
    {
        EditUserForm editUserForm = new EditUserForm(_user, _userRepository, this);
        editUserForm.ShowDialog();
    }
}
