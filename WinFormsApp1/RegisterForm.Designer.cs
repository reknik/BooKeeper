namespace BooKeeper;

partial class RegisterForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.confirmPasswordErrorLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordErrorLabel = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(23, 117);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.PlaceholderText = "Password";
            this.passwordTextBox.Size = new System.Drawing.Size(138, 23);
            this.passwordTextBox.TabIndex = 6;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.passwordTextBox_Validating);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(23, 59);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PlaceholderText = "Username";
            this.usernameTextBox.Size = new System.Drawing.Size(138, 23);
            this.usernameTextBox.TabIndex = 5;
            this.usernameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.usernameTextBox_Validating);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lastNameTextBox);
            this.panel1.Controls.Add(this.firstNameTextBox);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(this.confirmPasswordErrorLabel);
            this.panel1.Controls.Add(this.usernameTextBox);
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Controls.Add(this.passwordErrorLabel);
            this.panel1.Controls.Add(this.confirmPasswordTextBox);
            this.panel1.Controls.Add(this.registerButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 325);
            this.panel1.TabIndex = 8;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(38, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(105, 23);
            this.Title.TabIndex = 7;
            this.Title.Text = "BooKeeper !!";
            // 
            // confirmPasswordErrorLabel
            // 
            this.confirmPasswordErrorLabel.AutoSize = true;
            this.confirmPasswordErrorLabel.Location = new System.Drawing.Point(12, 205);
            this.confirmPasswordErrorLabel.Name = "confirmPasswordErrorLabel";
            this.confirmPasswordErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.confirmPasswordErrorLabel.TabIndex = 11;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(12, 87);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(0, 15);
            this.usernameLabel.TabIndex = 10;
            // 
            // passwordErrorLabel
            // 
            this.passwordErrorLabel.AutoSize = true;
            this.passwordErrorLabel.Location = new System.Drawing.Point(12, 143);
            this.passwordErrorLabel.Name = "passwordErrorLabel";
            this.passwordErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.passwordErrorLabel.TabIndex = 9;
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(23, 179);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '*';
            this.confirmPasswordTextBox.PlaceholderText = "Confirm password";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(138, 23);
            this.confirmPasswordTextBox.TabIndex = 7;
            this.confirmPasswordTextBox.UseSystemPasswordChar = true;
            this.confirmPasswordTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.confirmPasswordTextBox_Validating);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(51, 278);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 2;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(23, 220);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.PlaceholderText = "First Name";
            this.firstNameTextBox.Size = new System.Drawing.Size(138, 23);
            this.firstNameTextBox.TabIndex = 12;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(23, 249);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.PlaceholderText = "Last Name";
            this.lastNameTextBox.Size = new System.Drawing.Size(138, 23);
            this.lastNameTextBox.TabIndex = 13;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 325);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private TextBox passwordTextBox;
    private TextBox usernameTextBox;
    private Panel panel1;
    private TextBox confirmPasswordTextBox;
    private Button registerButton;
    private Label Title;
    private Label confirmPasswordErrorLabel;
    private Label usernameLabel;
    private Label passwordErrorLabel;
    private TextBox lastNameTextBox;
    private TextBox firstNameTextBox;
}