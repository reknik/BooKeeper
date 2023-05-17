using BCrypt.Net;
using BooKeeper;
using BooKeeper.Data;
using BooKeeper.Models;
using BooKeeper.Repositories;
using MySql.Data.MySqlClient;
using System.Media;

namespace WinFormsApp1;

public partial class LoginForm : Form
{
    private readonly IUserRepository _userRepository;

    private readonly IBookRepository _bookRepository;

    private readonly ICategoryRepository _categoryRepository;


    private readonly RegisterForm _registerForm;

    private readonly MusicBox _musicBox;

    public LoginForm(IUserRepository userRepository, RegisterForm registerForm, IBookRepository bookRepository, ICategoryRepository categoryRepository, MusicBox musicBox)
    {
        InitializeComponent();
        _userRepository = userRepository;
        _registerForm = registerForm;
        _bookRepository = bookRepository;
        _categoryRepository = categoryRepository;
        _musicBox = musicBox;
    }

    private void loginButton_Click(object sender, EventArgs e)
    {
        string username = usernameTextBox.Text;
        string password = passwordTextBox.Text.Trim();
        User? user = _userRepository.GetUserByUsername(username);
        if(user == null || !BCrypt.Net.BCrypt.Verify(password, user.Password))
        {
            errorLabel.Text = "Username or password are wrong";
            return;
        }
        this.Hide();
        new UserForm(user,_bookRepository,_categoryRepository, this, _musicBox, _userRepository).Show();
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        _registerForm.ShowDialog();
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
}