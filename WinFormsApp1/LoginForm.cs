using BCrypt.Net;
using BooKeeper;
using BooKeeper.Models;
using BooKeeper.Services;
using MySql.Data.MySqlClient;

namespace WinFormsApp1;

public partial class LoginForm : Form
{
    private readonly IUserRepository _userRepository;

    private readonly RegisterForm _registerForm;

    public LoginForm(IUserRepository userRepository, RegisterForm registerForm)
    {
        InitializeComponent();
        _userRepository = userRepository;
        _registerForm = registerForm;
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
        MessageBox.Show("Iee");
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        _registerForm.ShowDialog();
    }
}