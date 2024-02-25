using KodlamaIoOdev.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoOdev.DataAccess.Abstract;

public interface ICourseRepository
{
    public void Add(Course course);
    public void Delete(Course course);
    public List<Course> GetAll();
    public void Update(Course course);
    public Course? GetById(int id);
    public Course? GetByName(string name);
    public void AssignmentInstructor(Instructor instructor, Course course);
    public void AssignmentCategory(Category category, Course course);
}
