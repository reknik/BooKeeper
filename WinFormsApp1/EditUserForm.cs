using BooKeeper.Models;
using BooKeeper.Repositories;
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
public partial class EditUserForm : Form
{
    private readonly User _user;

    private readonly IUserRepository _userRepository;

    private readonly UserForm _userForm;

    private String profilePicturePath;
    public EditUserForm(User user, IUserRepository userRepository, UserForm userForm)
    {
        InitializeComponent();
        this._user= user;
        this._userRepository= userRepository;
        this._userForm= userForm;
        if(user.ProfilePicturePath != null)
        {
            profilePictureBox.Image = Image.FromFile(user.ProfilePicturePath);
        }
        usernameTextBox.Text = user.Username;
        firstNameTextBox.Text = user.FirstName;
        lastNameTextBox.Text = user.LastName;
    }

    private void usernameTextBox_Validating(object sender, CancelEventArgs e)
    {
        if(usernameTextBox.Text.Equals(_user.Username)) {
            usernameLabel.Text = "";
            return;
         }
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

    private void changeProfilePictureButton_Click(object sender, EventArgs e)
    {
        OpenFileDialog dialog = new OpenFileDialog();
        dialog.Title = "Open Image";
        dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";

        if (dialog.ShowDialog() == DialogResult.OK)
        {
            profilePictureBox.Image = Image.FromFile(dialog.FileName);
            profilePicturePath = dialog.FileName;
        }
        dialog.Dispose();
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        if (usernameLabel.ForeColor.Equals(Color.Red))
        {
            MessageBox.Show("Please check errors");
            return;
        }
        if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNoCancel) != DialogResult.Yes)
        {
            return;
        }

        _user.Username = usernameTextBox.Text;
        _user.ProfilePicturePath = profilePicturePath;
        _user.FirstName = firstNameTextBox.Text;
        _user.LastName = lastNameTextBox.Text;
        if(profilePicturePath!= null)
        {
            _userForm.changeProfilePicture(profilePicturePath);
        }
        _userRepository.UpdateUser(_user);
        MessageBox.Show("Changes have been saved");
    }
}
