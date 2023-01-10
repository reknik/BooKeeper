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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookNumberDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookNumberDTOBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            this.panel1.Size = new System.Drawing.Size(781, 248);
            this.panel1.TabIndex = 0;
            // 
            // allBooksList
            // 
            this.allBooksList.FormattingEnabled = true;
            this.allBooksList.ItemHeight = 15;
            this.allBooksList.Location = new System.Drawing.Point(469, 22);
            this.allBooksList.Name = "allBooksList";
            this.allBooksList.Size = new System.Drawing.Size(120, 184);
            this.allBooksList.TabIndex = 11;
            this.allBooksList.SelectedIndexChanged += new System.EventHandler(this.allBooksList_SelectedIndexChanged);
            // 
            // editBooksButton
            // 
            this.editBooksButton.Location = new System.Drawing.Point(595, 218);
            this.editBooksButton.Name = "editBooksButton";
            this.editBooksButton.Size = new System.Drawing.Size(176, 23);
            this.editBooksButton.TabIndex = 10;
            this.editBooksButton.Text = "Edit books";
            this.editBooksButton.UseVisualStyleBackColor = true;
            // 
            // reserveButton
            // 
            this.reserveButton.Location = new System.Drawing.Point(595, 183);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(176, 23);
            this.reserveButton.TabIndex = 9;
            this.reserveButton.Text = "Reserve now!";
            this.reserveButton.UseVisualStyleBackColor = true;
            this.reserveButton.Click += new System.EventHandler(this.reserveButton_Click);
            // 
            // allBooksTextBox
            // 
            this.allBooksTextBox.Location = new System.Drawing.Point(595, 22);
            this.allBooksTextBox.Name = "allBooksTextBox";
            this.allBooksTextBox.ReadOnly = true;
            this.allBooksTextBox.Size = new System.Drawing.Size(176, 152);
            this.allBooksTextBox.TabIndex = 8;
            this.allBooksTextBox.Text = "";
            // 
            // userBookTextBox
            // 
            this.userBookTextBox.Location = new System.Drawing.Point(264, 22);
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
            this.userBookList.Location = new System.Drawing.Point(138, 22);
            this.userBookList.Name = "userBookList";
            this.userBookList.Size = new System.Drawing.Size(120, 184);
            this.userBookList.TabIndex = 5;
            this.userBookList.SelectedIndexChanged += new System.EventHandler(this.userBookList_SelectedIndexChanged);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(12, 22);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(105, 23);
            this.Title.TabIndex = 4;
            this.Title.Text = "BooKeeper !!";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(12, 226);
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
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 248);
            this.Controls.Add(this.panel1);
            this.Name = "UserForm";
            this.Text = "BooKeeper";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
}