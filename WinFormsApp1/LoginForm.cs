using BCrypt.Net;
using BooKeeper.Models;
using BooKeeper.Services;
using MySql.Data.MySqlClient;

namespace WinFormsApp1;

public partial class LoginForm : Form
{
    private readonly IUserRepository _userRepository;

    public LoginForm(IUserRepository userRepository)
    {
        InitializeComponent();
        _userRepository = userRepository;
    }

    private void loginButton_Click(object sender, EventArgs e)
    {
        string username = usernameTextBox.Text;
        string password = passwordTextBox.Text;
        User? user = _userRepository.GetUserByUsername(username);
        if(user == null || !BCrypt.Net.BCrypt.Verify(password, user.Password))
        {
            errorLabel.Text = "Username or password are wrong";
        }
    }
}