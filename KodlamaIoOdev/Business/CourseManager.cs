using KodlamaIoOdev.DataAccess.Abstract;
using KodlamaIoOdev.DataAccess.Concrete;
using KodlamaIoOdev.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoOdev.Business;

public class CourseManager
{
    ICourseRepository _courseRepository;

    public CourseManager(ICourseRepository courseRepository)
    {
        _courseRepository = courseRepository;
    }

    public void Add(Course course)
    {
        var result = _courseRepository.GetByName(course.Name);
        if (result != null)
        {
            Console.WriteLine(course.Name + " isminde bir course mevcut.");
            return;
        }
        _courseRepository.Add(course);
    }

    public void Remove(Course course)
    {
        var result = _courseRepository.GetByName(course.Name);
        if (result == null)
        {
            Console.WriteLine(course.Name + " isminde bir course mevcut değil.");
            return;
        }
        _courseRepository.Delete(course);
    }

    public List<Course> GetAll()
    {
        return _courseRepository.GetAll();
    }

    public void GetByName(string name)
    {
        _courseRepository.GetByName(name);
    }

    public void GetById(int id)
    {
        _courseRepository.GetById(id);
    }

    public void Update(Course course)
    {
        var result = _courseRepository.GetByName(course.Name);
        if (result == null)
        {
            Console.WriteLine(course.Name + " isminde bir course mevcut değil.");
            return;
        }
        result.Name = course.Name;
    }

    public void AssignmentInstructor(Instructor instructor, Course course)
    {
        var course1 = _courseRepository.GetById(course.Id);
        course1.InstructorId = instructor.Id;
    }

    public void AssignmentCategory(Category category, Course course)    
    {
        var course1 = _courseRepository.GetById(course.Id);
        course1.CategoryId = category.Id;
    }
}
