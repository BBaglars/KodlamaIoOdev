using KodlamaIoOdev.DataAccess.Abstract;
using KodlamaIoOdev.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoOdev.Business;

public class InstructorManager
{
    IInstructorRepository _instructorRepository;

    public InstructorManager(IInstructorRepository instructorRepository)
    {
        _instructorRepository = instructorRepository;
    }

    public void Add(Instructor instructor)
    {
        var result = _instructorRepository.GetByName(instructor.Name);
        if (result != null)
        {
            Console.WriteLine(instructor.Name + " bu isimde bir instructor mevcut");
            return;
        }
        _instructorRepository.Add(instructor);
    }

    public void Remove(Instructor instructor)
    {
        var result = _instructorRepository.GetByName(instructor.Name);
        if (result == null)
        {
            Console.WriteLine(instructor.Name + " bu isimde bir instructor mevcut değil");
            return;
        }
        _instructorRepository.Remove(instructor);
    }

    public List<Instructor> GetAll()
    {
        return _instructorRepository.GetAll();
    }

    public void GetByName(string name)
    {
        _instructorRepository.GetByName(name);
    }

    public void GetById(int id)
    {
        _instructorRepository.GetById(id);
    }

    public void Update(Instructor instructor)
    {
        var result = _instructorRepository.GetByName(instructor.Name);
        if (result == null)
        {
            Console.WriteLine(instructor.Name + " bu isminde bir instructor mevcut değil");
            return;
        }
        result.Name = instructor.Name;
    }
}
