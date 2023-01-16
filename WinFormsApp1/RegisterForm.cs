using BooKeeper.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using BooKeeper.Repositories;

namespace BooKeeper;
public partial class RegisterForm : Form
{

    private readonly IUserRepository _userRepository;

    public RegisterForm(IUserRepository userRepository)
    {
        this._userRepository = userRepository;
        InitializeComponent();
    }

    private void usernameTextBox_Validating(object sender, CancelEventArgs e)
    {
        usernameLabel.ForeColor = Color.Red;
        if (usernameTextBox.Text.Length < 2)
        {
            usernameLabel.Text = "Username must be at least 2 characters long";
            return;
        }
        User? user = _userRepository.GetUserByUsername(usernameTextBox.Text.Trim());
        if (user != null)
        {
            usernameLabel.Text = "Username already taken";
            return;
        }
        usernameLabel.ForeColor = Color.Green;
        usernameLabel.Text = "Username is available";
    }

    private void passwordTextBox_Validating(object sender, CancelEventArgs e)
    {
        if (passwordTextBox.Text.Length < 2)
        {
            passwordErrorLabel.Text = "Password must be at least 2 characters long";
            return;
        }
        passwordErrorLabel.Text = null;
    }

    private void confirmPasswordTextBox_Validating(object sender, CancelEventArgs e)
    {
        if (!confirmPasswordTextBox.Text.Equals(passwordTextBox.Text))
        {
            confirmPasswordErrorLabel.Text = "Passwords must match";
            return;
        }
        confirmPasswordErrorLabel.Text = null;
    }

    private void registerButton_Click(object sender, EventArgs e)
    {
        if (usernameLabel.ForeColor.Equals(Color.Red) 
            || !string.IsNullOrEmpty(passwordErrorLabel.Text) 
            || !string.IsNullOrEmpty(confirmPasswordErrorLabel.Text))
        {
            MessageBox.Show("Please check errors");
            return;
        }
        string username = usernameTextBox.Text.Trim();
        string password = BCrypt.Net.BCrypt.HashPassword(passwordTextBox.Text.Trim());
        _userRepository.SaveUser(new User(username, password));
        MessageBox.Show("Registration successful");
        this.Close();
    }
}
