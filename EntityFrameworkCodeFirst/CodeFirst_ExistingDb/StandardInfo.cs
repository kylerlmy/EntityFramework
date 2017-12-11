namespace CodeFirst_ExistingDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StandardInfo")]
    public partial class StandardInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StandardInfo()
        {
            StudentInfoes = new HashSet<StudentInfo>();
        }

        [Key]
        public int StandardId { get; set; }

        public string StandardName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentInfo> StudentInfoes { get; set; }
    }
}
