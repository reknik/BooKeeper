using BooKeeper.Data;
using BooKeeper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooKeeper.Repositories.Impl;

public class CategoryRepository : ICategoryRepository
{
    private readonly BookDbContext _dbContext;
    private readonly IEnumerable<Category> _categories;

    public CategoryRepository(BookDbContext dbContext)
    {
        this._dbContext = dbContext;
        this._categories = _dbContext.Categories;
    }

    public IEnumerable<Category> GetAllCategories() => _categories;

    public Category? GetCategoryById(int selectedCategoryId) => _categories.FirstOrDefault(category => category.Id.Equals(selectedCategoryId));
}
