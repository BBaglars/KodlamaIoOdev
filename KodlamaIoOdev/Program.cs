using KodlamaIoOdev.Business;
using KodlamaIoOdev.DataAccess.Abstract;
using KodlamaIoOdev.DataAccess.Concrete;
using KodlamaIoOdev.Entities.Concrete;

CourseManager courseManager = new CourseManager(new CourseRepository());

Course course1 = new Course();
course1.Id = 1;
course1.Name = "C# 2024";
course1.Price = 0;
course1.CompleationPercent = 100;

Course course2 = new Course();
course2.Id = 2;
course2.Name = "Python";
course2.Price = 0;
course2.CompleationPercent = 42;

Course course3 = new Course();
course3.Id = 3;
course3.Name = "Java";
course3.Price = 0;
course3.CompleationPercent = 86;

InstructorManager instructorManager = new InstructorManager(new InstructorRepository());

Instructor instructor1 = new Instructor();
instructor1.Id = 1;
instructor1.Name = "Engin Demiroğ";

Instructor instructor2 = new Instructor();
instructor2.Id = 2;
instructor2.Name = "Halit Enes Kalaycı";


CategoryManager categoryManager = new CategoryManager(new CategoryRepository());

Category category1 = new Category();
category1.Id = 1;
category1.Name = "Kurslarım";



courseManager.Add(course1);
courseManager.Add(course2);
courseManager.Add(course3);

instructorManager.Add(instructor1);
instructorManager.Add(instructor2);

categoryManager.Add(category1);

Console.WriteLine(courseManager.GetAll());
Console.WriteLine(instructorManager.GetAll());
Console.WriteLine(categoryManager.GetAll());

courseManager.AssignmentInstructor(instructor1, course1);
courseManager.AssignmentInstructor(instructor2, course2);
courseManager.AssignmentInstructor(instructor1, course3);

Console.WriteLine(course1.Name + " eğitmeni = " + course1.InstructorId);
Console.WriteLine(course2.Name + " eğitmeni = " + course2.InstructorId);
Console.WriteLine(course3.Name + " eğitmeni = " + course3.InstructorId);

courseManager.AssignmentCategory(category1, course1);
courseManager.AssignmentCategory(category1, course2);
courseManager.AssignmentCategory(category1, course2);
