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
            this.panel1 = new System.Windows.Forms.Panel();
            this.reserveButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.allBooks = new System.Windows.Forms.ListBox();
            this.selectedBookTextBox = new System.Windows.Forms.RichTextBox();
            this.userBookList = new System.Windows.Forms.ListBox();
            this.Title = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reserveButton);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.allBooks);
            this.panel1.Controls.Add(this.selectedBookTextBox);
            this.panel1.Controls.Add(this.userBookList);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.welcomeLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 327);
            this.panel1.TabIndex = 0;
            // 
            // reserveButton
            // 
            this.reserveButton.Location = new System.Drawing.Point(553, 258);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(176, 23);
            this.reserveButton.TabIndex = 9;
            this.reserveButton.Text = "Reserve now!";
            this.reserveButton.UseVisualStyleBackColor = true;
            this.reserveButton.Click += new System.EventHandler(this.reserveButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(553, 97);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(176, 152);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // allBooks
            // 
            this.allBooks.FormattingEnabled = true;
            this.allBooks.ItemHeight = 15;
            this.allBooks.Location = new System.Drawing.Point(400, 97);
            this.allBooks.Name = "allBooks";
            this.allBooks.Size = new System.Drawing.Size(120, 184);
            this.allBooks.TabIndex = 7;
            // 
            // selectedBookTextBox
            // 
            this.selectedBookTextBox.Location = new System.Drawing.Point(165, 97);
            this.selectedBookTextBox.Name = "selectedBookTextBox";
            this.selectedBookTextBox.ReadOnly = true;
            this.selectedBookTextBox.Size = new System.Drawing.Size(176, 152);
            this.selectedBookTextBox.TabIndex = 6;
            this.selectedBookTextBox.Text = "";
            // 
            // userBookList
            // 
            this.userBookList.FormattingEnabled = true;
            this.userBookList.ItemHeight = 15;
            this.userBookList.Location = new System.Drawing.Point(12, 97);
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
            this.welcomeLabel.Location = new System.Drawing.Point(12, 56);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(38, 15);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "label1";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 327);
            this.Controls.Add(this.panel1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private Panel panel1;
    private Label welcomeLabel;
    private ListBox userBookList;
    private Label Title;
    private RichTextBox selectedBookTextBox;
    private Button reserveButton;
    private RichTextBox richTextBox1;
    private ListBox allBooks;
}