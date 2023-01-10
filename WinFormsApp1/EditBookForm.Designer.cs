namespace BooKeeper;

partial class EditBookForm
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
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.totalNumber = new System.Windows.Forms.NumericUpDown();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.yearPicker = new System.Windows.Forms.DateTimePicker();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.totalNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(12, 59);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.PlaceholderText = "Title";
            this.titleTextBox.Size = new System.Drawing.Size(200, 23);
            this.titleTextBox.TabIndex = 0;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(12, 88);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.PlaceholderText = "Author";
            this.authorTextBox.Size = new System.Drawing.Size(200, 23);
            this.authorTextBox.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(12, 146);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 96);
            this.descriptionTextBox.TabIndex = 2;
            this.descriptionTextBox.Text = "";
            // 
            // totalNumber
            // 
            this.totalNumber.Location = new System.Drawing.Point(12, 248);
            this.totalNumber.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.totalNumber.Name = "totalNumber";
            this.totalNumber.Size = new System.Drawing.Size(62, 23);
            this.totalNumber.TabIndex = 3;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(12, 277);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(200, 23);
            this.categoryComboBox.TabIndex = 4;
            // 
            // yearPicker
            // 
            this.yearPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.yearPicker.Location = new System.Drawing.Point(12, 117);
            this.yearPicker.Name = "yearPicker";
            this.yearPicker.Size = new System.Drawing.Size(200, 23);
            this.yearPicker.TabIndex = 5;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 314);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(137, 314);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(12, 18);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(105, 23);
            this.Title.TabIndex = 8;
            this.Title.Text = "BooKeeper !!";
            // 
            // EditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 352);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.yearPicker);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.totalNumber);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Name = "EditBookForm";
            this.Text = "Edit Book";
            this.Load += new System.EventHandler(this.EditBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.totalNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private TextBox titleTextBox;
    private TextBox authorTextBox;
    private RichTextBox descriptionTextBox;
    private NumericUpDown totalNumber;
    private ComboBox categoryComboBox;
    private DateTimePicker yearPicker;
    private Button saveButton;
    private Button exitButton;
    private Label Title;
}