namespace BooKeeper;

partial class UserForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.myCoverBox = new System.Windows.Forms.PictureBox();
            this.allCoverBox = new System.Windows.Forms.PictureBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.muteButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.allBooksList = new System.Windows.Forms.ListBox();
            this.editBooksButton = new System.Windows.Forms.Button();
            this.reserveButton = new System.Windows.Forms.Button();
            this.allBooksTextBox = new System.Windows.Forms.RichTextBox();
            this.userBookTextBox = new System.Windows.Forms.RichTextBox();
            this.userBookList = new System.Windows.Forms.ListBox();
            this.Title = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.bookNumberDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookNumberDTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.changeProfileButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCoverBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allCoverBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookNumberDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookNumberDTOBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.changeProfileButton);
            this.panel1.Controls.Add(this.profilePictureBox);
            this.panel1.Controls.Add(this.myCoverBox);
            this.panel1.Controls.Add(this.allCoverBox);
            this.panel1.Controls.Add(this.nextButton);
            this.panel1.Controls.Add(this.playButton);
            this.panel1.Controls.Add(this.muteButton);
            this.panel1.Controls.Add(this.returnButton);
            this.panel1.Controls.Add(this.allBooksList);
            this.panel1.Controls.Add(this.editBooksButton);
            this.panel1.Controls.Add(this.reserveButton);
            this.panel1.Controls.Add(this.allBooksTextBox);
            this.panel1.Controls.Add(this.userBookTextBox);
            this.panel1.Controls.Add(this.userBookList);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.welcomeLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1390, 572);
            this.panel1.TabIndex = 0;
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(875, 12);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(100, 50);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePictureBox.TabIndex = 19;
            this.profilePictureBox.TabStop = false;
            // 
            // myCoverBox
            // 
            this.myCoverBox.Location = new System.Drawing.Point(326, 68);
            this.myCoverBox.Name = "myCoverBox";
            this.myCoverBox.Size = new System.Drawing.Size(153, 152);
            this.myCoverBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.myCoverBox.TabIndex = 18;
            this.myCoverBox.TabStop = false;
            // 
            // allCoverBox
            // 
            this.allCoverBox.Location = new System.Drawing.Point(822, 68);
            this.allCoverBox.Name = "allCoverBox";
            this.allCoverBox.Size = new System.Drawing.Size(153, 152);
            this.allCoverBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.allCoverBox.TabIndex = 17;
            this.allCoverBox.TabStop = false;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(256, 270);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(45, 23);
            this.nextButton.TabIndex = 16;
            this.nextButton.Text = "next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(205, 270);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(45, 23);
            this.playButton.TabIndex = 15;
            this.playButton.Text = "play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // muteButton
            // 
            this.muteButton.Location = new System.Drawing.Point(154, 270);
            this.muteButton.Name = "muteButton";
            this.muteButton.Size = new System.Drawing.Size(45, 23);
            this.muteButton.TabIndex = 14;
            this.muteButton.Text = "mute";
            this.muteButton.UseVisualStyleBackColor = true;
            this.muteButton.Click += new System.EventHandler(this.muteButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(144, 229);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(176, 23);
            this.returnButton.TabIndex = 12;
            this.returnButton.Text = "Return to login";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // allBooksList
            // 
            this.allBooksList.FormattingEnabled = true;
            this.allBooksList.ItemHeight = 15;
            this.allBooksList.Location = new System.Drawing.Point(509, 68);
            this.allBooksList.Name = "allBooksList";
            this.allBooksList.Size = new System.Drawing.Size(120, 184);
            this.allBooksList.TabIndex = 11;
            this.allBooksList.SelectedIndexChanged += new System.EventHandler(this.allBooksList_SelectedIndexChanged);
            // 
            // editBooksButton
            // 
            this.editBooksButton.Location = new System.Drawing.Point(635, 264);
            this.editBooksButton.Name = "editBooksButton";
            this.editBooksButton.Size = new System.Drawing.Size(176, 23);
            this.editBooksButton.TabIndex = 10;
            this.editBooksButton.Text = "Edit books";
            this.editBooksButton.UseVisualStyleBackColor = true;
            this.editBooksButton.Click += new System.EventHandler(this.editBooksButton_Click);
            // 
            // reserveButton
            // 
            this.reserveButton.Location = new System.Drawing.Point(635, 229);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(176, 23);
            this.reserveButton.TabIndex = 9;
            this.reserveButton.Text = "Reserve now!";
            this.reserveButton.UseVisualStyleBackColor = true;
            this.reserveButton.Click += new System.EventHandler(this.reserveButton_Click);
            // 
            // allBooksTextBox
            // 
            this.allBooksTextBox.Location = new System.Drawing.Point(635, 68);
            this.allBooksTextBox.Name = "allBooksTextBox";
            this.allBooksTextBox.ReadOnly = true;
            this.allBooksTextBox.Size = new System.Drawing.Size(176, 152);
            this.allBooksTextBox.TabIndex = 8;
            this.allBooksTextBox.Text = "";
            // 
            // userBookTextBox
            // 
            this.userBookTextBox.Location = new System.Drawing.Point(144, 68);
            this.userBookTextBox.Name = "userBookTextBox";
            this.userBookTextBox.ReadOnly = true;
            this.userBookTextBox.Size = new System.Drawing.Size(176, 152);
            this.userBookTextBox.TabIndex = 6;
            this.userBookTextBox.Text = "";
            // 
            // userBookList
            // 
            this.userBookList.FormattingEnabled = true;
            this.userBookList.ItemHeight = 15;
            this.userBookList.Location = new System.Drawing.Point(18, 68);
            this.userBookList.Name = "userBookList";
            this.userBookList.Size = new System.Drawing.Size(120, 184);
            this.userBookList.TabIndex = 5;
            this.userBookList.SelectedIndexChanged += new System.EventHandler(this.userBookList_SelectedIndexChanged);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(18, 24);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(105, 23);
            this.Title.TabIndex = 4;
            this.Title.Text = "BooKeeper !!";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(732, 24);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(38, 15);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "label1";
            // 
            // bookNumberDTOBindingSource
            // 
            this.bookNumberDTOBindingSource.DataSource = typeof(BooKeeper.Models.DTO.BookNumberDTO);
            // 
            // bookNumberDTOBindingSource1
            // 
            this.bookNumberDTOBindingSource1.DataSource = typeof(BooKeeper.Models.DTO.BookNumberDTO);
            // 
            // changeProfileButton
            // 
            this.changeProfileButton.Location = new System.Drawing.Point(732, 42);
            this.changeProfileButton.Name = "changeProfileButton";
            this.changeProfileButton.Size = new System.Drawing.Size(137, 23);
            this.changeProfileButton.TabIndex = 20;
            this.changeProfileButton.Text = "Change profile settings";
            this.changeProfileButton.UseVisualStyleBackColor = true;
            this.changeProfileButton.Click += new System.EventHandler(this.changeProfileButton_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 572);
            this.Controls.Add(this.panel1);
            this.Name = "UserForm";
            this.Text = "BooKeeper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCoverBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allCoverBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookNumberDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookNumberDTOBindingSource1)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private Panel panel1;
    private Label welcomeLabel;
    private ListBox userBookList;
    private Label Title;
    private RichTextBox userBookTextBox;
    private Button reserveButton;
    private RichTextBox allBooksTextBox;
    private Button editBooksButton;
    private BindingSource bookNumberDTOBindingSource;
    private BindingSource bookNumberDTOBindingSource1;
    private ListBox allBooksList;
    private Button returnButton;
    private Button nextButton;
    private Button playButton;
    private Button muteButton;
    private PictureBox allCoverBox;
    private PictureBox myCoverBox;
    private PictureBox profilePictureBox;
    private Button changeProfileButton;
}