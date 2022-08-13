namespace HospitalProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Doctor")]
    public partial class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long doctor_id { get; set; }

        public long dept_id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string experties { get; set; }

        [StringLength(50)]
        public string designation { get; set; }

        public int? age { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? contact_num { get; set; }

        public int? experience { get; set; }

        public virtual Department Department { get; set; }
    }
}
