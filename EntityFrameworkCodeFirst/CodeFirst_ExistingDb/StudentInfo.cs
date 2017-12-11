namespace CodeFirst_ExistingDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Admin.StudentInfo")]
    public partial class StudentInfo
    {
        [Key]
        public int StudentID { get; set; }

        public string StudentName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public byte[] Photo { get; set; }

        public decimal Height { get; set; }

        public float Weight { get; set; }

        public int? Standard_StandardId { get; set; }

        public int? Teacher_TeacherId { get; set; }

        public virtual Teacher Teacher { get; set; }

        public virtual StandardInfo StandardInfo { get; set; }
    }
}
