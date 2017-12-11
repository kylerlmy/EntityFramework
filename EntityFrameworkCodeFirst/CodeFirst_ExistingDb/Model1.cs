namespace CodeFirst_ExistingDb
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=SchoolContext2")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<StudentInfo> StudentInfoes { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<StandardInfo> StandardInfoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>()
                .HasMany(e => e.StudentInfoes)
                .WithOptional(e => e.Teacher)
                .HasForeignKey(e => e.Teacher_TeacherId);

            modelBuilder.Entity<StandardInfo>()
                .HasMany(e => e.StudentInfoes)
                .WithOptional(e => e.StandardInfo)
                .HasForeignKey(e => e.Standard_StandardId);
        }
    }
}
