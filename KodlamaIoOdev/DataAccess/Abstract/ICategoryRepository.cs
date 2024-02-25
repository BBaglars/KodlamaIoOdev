using KodlamaIoOdev.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoOdev.DataAccess.Abstract;

public interface ICategoryRepository
{
    public void Add(Category category);
    public void Update(Category category);
    public void Delete(Category category);
    public List<Category> GetAll();
    public Category? GetByName(string name);
    public Category? GetById(int id);
}
