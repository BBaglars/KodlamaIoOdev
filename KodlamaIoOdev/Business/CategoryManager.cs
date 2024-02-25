using KodlamaIoOdev.DataAccess.Abstract;
using KodlamaIoOdev.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoOdev.Business;

public class CategoryManager
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryManager(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public void Add(Category category)
    {
        var result = _categoryRepository.GetByName(category.Name);
        if (result != null) {
            Console.WriteLine(category.Name + " isminde bir category mevcut.");
            return;
        }
        _categoryRepository.Add(category);
    }

    public void Remove(Category category)
    {
        var result = _categoryRepository.GetByName(category.Name);
        if (result == null)
        {
            Console.WriteLine(category.Name + " isminde bir category mevcut değil.");
            return;
        }
        _categoryRepository.Add(category);
    }

    public List<Category> GetAll() 
    {
        return _categoryRepository.GetAll();
    }

    public void GetByName(string name)
    {
        _categoryRepository.GetByName(name);
    }

    public void GetById(int id)
    {
        _categoryRepository.GetById(id);
    }

    public void Update(Category category)
    {
        var result = _categoryRepository.GetByName(category.Name);
        if (result == null)
        {
            Console.WriteLine(category.Name + " isminde bir category mevcut değil.");
            return;
        }
        result.Name = category.Name;
    }
}
