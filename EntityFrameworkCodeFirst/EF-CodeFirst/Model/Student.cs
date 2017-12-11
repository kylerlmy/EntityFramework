using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst
{
    [Table("Students")]
    public class Student
    {
        //如果多个针对不同.NET Framework平台的项目文件存在于同一个物理目录下，存在于相同目录下的源文件可以同时包含到这些项目中以实现共享的目的。

#if WINDOWS
//<<针对Windows Desktop>>

   public string Name { get; set; }
   public Student(string name) { this.Name=name;}

#elif SILVERLIGHT
// <<针对 Silverlight>>
   public string Age { get; set; }
   public Student(string age) { this.Age=name;}

#elif WINDOWS_PHONE
 //<<针对Windows Phone>>
   public string Grade { get; set; }
   public Student(string grade) { this.Grade=grade;}

#else
// <<针对其他平台>>
        public Student() { }


#endif



        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        //public Teacher Teacher { get; set; }
        //public Standard Standard { get; set; }

        //public virtual StudentAddress Address { get; set; }
    }

    [Table("StandardMaster")]
    public class Standard
    {
        public Standard() { }

        public int StandardId { get; set; }
        public string StandardName { get; set; }

        public ICollection<Student> Students { get; set; }
    }
    public class Teacher
    {
        public Teacher() { }

        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
    }

    public class StudentAddress
    {
        [ForeignKey("Student")]
        public int StudentAddressId { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int Zipcode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public virtual Student Student { get; set; }
    }

    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public float Score { get; set; }

        public Teacher OnlineTeacher { get; set; }
    }

}
