using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                //var student =
                //    new Student
                //    { StudentName = "New Student" };
                //context.Students.Add(student);
                //context.SaveChanges();

                var studentBll = new StudentBll();
                var result = studentBll.GetList();


                //var student1 = new Student() { StudentName = "James" };
                //var address1 = new StudentAddress() { Address1 = "address" };

                //student1.Address = address1;
                //context.Students.Add(student1);
                //context.SaveChanges();

                // student1 and its address will be removed from db

                //var student1 = context.Students.FirstOrDefault();
                //context.Students.Remove(student1);
                //context.SaveChanges();




            }
        }
    }
}
