using BooKeeper.Models;
using BooKeeper.Services;
using MySql.Data.MySqlClient;

namespace WinFormsApp1;

public partial class Form1 : Form
{
    private readonly IUserRepository _userRepository;

    public Form1(IUserRepository userRepository)
    {
        InitializeComponent();
        _userRepository = userRepository;
    }

    private void loginButton_Click(object sender, EventArgs e)
    {
        string username = usernameTextBox.Text;
        string password = passwordTextBox.Text;
        User? user = _userRepository.GetUserByUsername(username);
        if(user == null || !user.Password.Equals(password.Trim()))
        {
            errorLabel.Text = "Username or password are wrong";
        }
    }
}