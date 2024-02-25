using KodlamaIoOdev.DataAccess.Abstract;
using KodlamaIoOdev.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoOdev.DataAccess.Concrete;

public class InstructorRepository : IInstructorRepository
{
    private readonly List<Instructor> _instructors = [];

    public void Add(Instructor instructor)
    {
        _instructors.Add(instructor);
    }
    public void Remove(Instructor instructor)
    {
        _instructors?.Remove(instructor);
    }

    public List<Instructor> GetAll()
    {
        return _instructors;
    }

    public Instructor? GetById(int id)
    {
        return _instructors.FirstOrDefault(x => x.Id == id);
    }

    public Instructor? GetByName(string name)
    {
        return _instructors.FirstOrDefault(x => x.Name == name);
    }

    public void Update(Instructor instructor)
    {
        Instructor instructor1 = GetById(instructor.Id);
        instructor1.Name = instructor.Name;
    }
}
