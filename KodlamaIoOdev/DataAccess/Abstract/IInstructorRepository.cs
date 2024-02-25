using KodlamaIoOdev.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoOdev.DataAccess.Abstract;

public interface IInstructorRepository
{
    public void Add(Instructor instructor);
    public void Remove(Instructor instructor);
    public List<Instructor> GetAll();
    public Instructor? GetByName(string name);
    public Instructor? GetById(int id);
    public void Update(Instructor instructor);
}
