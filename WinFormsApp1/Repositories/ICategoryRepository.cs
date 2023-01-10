using BooKeeper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooKeeper.Repositories;

public interface ICategoryRepository
{

    public IEnumerable<Category> GetAllCategories();

    public Category? GetCategoryById(int selectedCategoryId);
}
