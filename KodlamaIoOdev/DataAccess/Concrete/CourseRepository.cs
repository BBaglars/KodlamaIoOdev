using KodlamaIoOdev.DataAccess.Abstract;
using KodlamaIoOdev.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoOdev.DataAccess.Concrete;

public class CourseRepository : ICourseRepository
{
    private readonly List<Course> courses = [];

    public void Add(Course course)
    {
        courses.Add(course);
    }


    public void Delete(Course course)
    {
        courses.Remove(course);
    }

    public List<Course> GetAll()
    {
        return courses;
    }
    public Course? GetById(int id)
    {
        return courses.FirstOrDefault(c => c.Id == id);
    }

    public Course? GetByName(string name)
    {
        return courses.FirstOrDefault(c => c.Name == name);
    }

    public void Update(Course course)
    {
        Course course1 = GetById(course.Id);
        course1.Name = course.Name;
    }

    public void AssignmentInstructor(Instructor instructor, Course course)
    {
        Course course1 = GetById(course.Id);
        course1.InstructorId = instructor.Id;
    }

    public void AssignmentCategory(Category category, Course course)
    {
        Course course1 = GetById(course.Id);
        course1.CategoryId = category.Id;
    }
}
