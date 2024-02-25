using KodlamaIoOdev.DataAccess.Abstract;
using KodlamaIoOdev.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KodlamaIoOdev.DataAccess.Concrete;

public class CategoryRepository : ICategoryRepository
{
    private readonly List<Category> categories = [];
    public void Add(Category category)
    {
        categories.Add(category);
    }

    public void Delete(Category category)
    {
        categories.Remove(category);
    }

    public List<Category> GetAll()
    {
        return categories;
    }

    public Category? GetById(int id)
    {
        return categories.FirstOrDefault(c => c.Id == id);
    }

    public Category? GetByName(string name)
    {
        return categories.FirstOrDefault(c => c.Name == name);
    }

    public void Update(Category category)
    {
        Category category1 = GetById(category.Id)!;
        category1.Name = category.Name;
    }
}
