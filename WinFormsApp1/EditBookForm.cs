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
public partial class EditBookForm : Form
{
    private Book selectedBook;

    private readonly ICategoryRepository _categoryRepository;

    private readonly IBookRepository _bookRepository;

    public EditBookForm(Book selectedBook, ICategoryRepository categoryRepository, IBookRepository bookRepository)
    {
        this.selectedBook = selectedBook;
        this._categoryRepository = categoryRepository;
        InitializeComponent();
        titleTextBox.Text = selectedBook.Title;
        authorTextBox.Text = selectedBook.Author;
        descriptionTextBox.Text = selectedBook.Description;
        yearPicker.Value = selectedBook.Year;
        totalNumber.Value = selectedBook.TotalNumber;
        IEnumerable<Category> categories = _categoryRepository.GetAllCategories();
        categoryComboBox.DisplayMember = "Name";
        categories.ToList().ForEach(category => categoryComboBox.Items.Add(category));
        categoryComboBox.SelectedItem = categories.Single(category => selectedBook.Category.Equals(category.Id));
        yearPicker.Format = DateTimePickerFormat.Custom;
        yearPicker.CustomFormat = "yyyy";
        yearPicker.ShowUpDown = true;
        _categoryRepository = categoryRepository;
        _bookRepository = bookRepository;
    }

    private void EditBookForm_Load(object sender, EventArgs e)
    {

    }

    private void exitButton_Click(object sender, EventArgs e)
    {
        DialogResult dr = MessageBox.Show("Are you sure you want to exit? \n All unsaved changes will be lost","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
        if (dr.Equals(DialogResult.Cancel))
        {
            return;
        }
        this.Close();
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(titleTextBox.Text))
        {
            MessageBox.Show("Title cannot be empty");
            return;
        }
        if (string.IsNullOrEmpty(authorTextBox.Text))
        {
            MessageBox.Show("Author cannot be empty");
            return;
        }
        selectedBook.Title = titleTextBox.Text;
        selectedBook.Author = authorTextBox.Text;
        selectedBook.Description = descriptionTextBox.Text;
        selectedBook.Year = yearPicker.Value;
        selectedBook.CategoryNavigation = (Category)categoryComboBox.SelectedItem;
        selectedBook.TotalNumber = (int)totalNumber.Value;
        _bookRepository.SaveBook(selectedBook);
        MessageBox.Show("Book has been saved");
    }
}
