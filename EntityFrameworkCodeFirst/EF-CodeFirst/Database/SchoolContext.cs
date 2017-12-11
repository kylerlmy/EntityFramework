using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using ProjectShared;

namespace EF_CodeFirst
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base()
        {
            //Database.SetInitializer(new SchoolDbInitializer());

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SchoolContext, EF_CodeFirst.Migrations.Configuration>());


        }
        //  Person p=new Person();
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        //public DbSet<Standard> Standards { get; set; }
        //public DbSet<StudentAddress> StudentAddresses { get; set; }



        /*
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configure default schema
            modelBuilder.HasDefaultSchema("Admin");

            //Map entity to table
            modelBuilder.Entity<Student>().ToTable("StudentInfo");
            modelBuilder.Entity<Standard>().ToTable("StandardInfo", "dbo");
          

             modelBuilder.Entity<Student>().Map(m =>
            {
                m.Properties(p => new { p.StudentId, p.StudentName});
                m.ToTable("StudentInfo");

            }).Map(m => {
                m.Properties(p => new { p.StudentId, p.Height, p.Weight, p.Photo, p.DateOfBirth});
                m.ToTable("StudentInfoDetail");

            });

            modelBuilder.Entity<Standard>().ToTable("StandardInfo");




            modelBuilder.Entity<Student>().Map(delegate (EntityMappingConfiguration<Student> studentConfig)
            {
                studentConfig.Properties(p => new { p.StudentId, p.StudentName });
                studentConfig.ToTable("StudentInfo");
            });

            Action<EntityMappingConfiguration<Student>> studentMapping = m =>
            {
                m.Properties(p => new { p.StudentId, p.Height, p.Weight, p.Photo, p.DateOfBirth });
                m.ToTable("StudentInfoDetail");
            };
            modelBuilder.Entity<Student>().Map(studentMapping);

            modelBuilder.Entity<Standard>().ToTable("StandardInfo");

        }
        */
    }
}
