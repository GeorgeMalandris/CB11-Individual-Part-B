namespace IndividualProjectPartB_GeorgeMalandris.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Courses
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Courses()
        {
            Assignments = new HashSet<Assignments>();
            Students = new HashSet<Students>();
            Trainers = new HashSet<Trainers>();
        }

        [Key]
        public int CourseID { get; set; }

        [Required]
        [StringLength(10)]
        public string title { get; set; }

        [Required]
        [StringLength(10)]
        public string stream { get; set; }

        [Required]
        [StringLength(30)]
        public string type { get; set; }

        public DateTime start_date { get; set; }

        public DateTime end_date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Assignments> Assignments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Students> Students { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trainers> Trainers { get; set; }
    }
}
