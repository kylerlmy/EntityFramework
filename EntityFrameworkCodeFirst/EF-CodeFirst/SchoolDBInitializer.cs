using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst
{
    public class SchoolDbInitializer : DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {

            //IList<Standard> defaultStandards = new List<Standard>();

            //defaultStandards.Add(new Standard() { StandardName = "Standard 1", Description = "First Standard" });
            //defaultStandards.Add(new Standard() { StandardName = "Standard 2", Description = "Second Standard" });
            //defaultStandards.Add(new Standard() { StandardName = "Standard 3", Description = "Third Standard" });


            IList<Student> defaultStudents = new List<Student>();
            defaultStudents.Add(new Student() { DateOfBirth = DateTime.Now.AddYears(-19), Height = 168.6m, Photo = new byte[] { 0x12, 0x54 }, StudentId = 1, StudentName = "xiaoming", Weight = 65.5f });
            defaultStudents.Add(new Student() { DateOfBirth = DateTime.Now.AddYears(-17), Height = 158.6m, Photo = new byte[] { 0x12, 0x54 }, StudentId = 2, StudentName = "xiaohua", Weight = 68.5f });
            defaultStudents.Add(new Student() { DateOfBirth = DateTime.Now, Height = 178.6m, Photo = new byte[] { 0x12, 0x54 }, StudentId = 3, StudentName = "xiaohong", Weight = 75.5f });
            defaultStudents.Add(new Student() { DateOfBirth = DateTime.Now.AddYears(-18), Height = 179.6m, Photo = new byte[] { 0x12, 0x54 }, StudentId = 4, StudentName = "xiaoqiang", Weight = 85.5f });
            defaultStudents.Add(new Student() { DateOfBirth = DateTime.Now.AddYears(-20), Height = 163.6m, Photo = new byte[] { 0x12, 0x54 }, StudentId = 5, StudentName = "xiaoli", Weight = 55.5f });

            foreach (Student std in defaultStudents)
                context.Students.Add(std);


            IList<Course> defaultCourses = new List<Course>();
            defaultCourses.Add(new Course { CourseId = 1, CourseName = "Math", Description = "数学" });
            defaultCourses.Add(new Course { CourseId = 2, CourseName = "English", Description = "英语" });
            defaultCourses.Add(new Course { CourseId = 3, CourseName = "Chinese", Description = "语文" });

            foreach (Course course in defaultCourses)
                context.Courses.Add(course);

            IList<Teacher> teachers = new List<Teacher>();

            teachers.Add(new Teacher { TeacherId = 1, TeacherName = "Doctor Li" });
            teachers.Add(new Teacher { TeacherId = 2, TeacherName = "Doctor Chen" });
            teachers.Add(new Teacher { TeacherId = 3, TeacherName = "Doctor Wang" });

            foreach (Teacher teacher in teachers)
                context.Teachers.Add(teacher);


            base.Seed(context);
        }
    }
}
