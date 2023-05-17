namespace BooKeeper;

partial class EditUserForm
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
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.changeProfilePictureButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(18, 143);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.PlaceholderText = "Last Name";
            this.lastNameTextBox.Size = new System.Drawing.Size(138, 23);
            this.lastNameTextBox.TabIndex = 20;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(18, 114);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.PlaceholderText = "First Name";
            this.firstNameTextBox.Size = new System.Drawing.Size(138, 23);
            this.firstNameTextBox.TabIndex = 19;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(18, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(105, 23);
            this.Title.TabIndex = 17;
            this.Title.Text = "BooKeeper !!";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(18, 59);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PlaceholderText = "Username";
            this.usernameTextBox.Size = new System.Drawing.Size(138, 23);
            this.usernameTextBox.TabIndex = 15;
            this.usernameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.usernameTextBox_Validating);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(116, 177);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(177, 59);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(100, 50);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePictureBox.TabIndex = 21;
            this.profilePictureBox.TabStop = false;
            // 
            // changeProfilePictureButton
            // 
            this.changeProfilePictureButton.Location = new System.Drawing.Point(177, 117);
            this.changeProfilePictureButton.Name = "changeProfilePictureButton";
            this.changeProfilePictureButton.Size = new System.Drawing.Size(100, 23);
            this.changeProfilePictureButton.TabIndex = 22;
            this.changeProfilePictureButton.Text = "Change picture";
            this.changeProfilePictureButton.UseVisualStyleBackColor = true;
            this.changeProfilePictureButton.Click += new System.EventHandler(this.changeProfilePictureButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(18, 85);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(0, 15);
            this.usernameLabel.TabIndex = 23;
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 212);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.changeProfilePictureButton);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.saveButton);
            this.Name = "EditUserForm";
            this.Text = "EditUserForm";
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private TextBox lastNameTextBox;
    private TextBox firstNameTextBox;
    private Label Title;
    private TextBox usernameTextBox;
    private Button saveButton;
    private PictureBox profilePictureBox;
    private Button changeProfilePictureButton;
    private Label usernameLabel;
}