// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjektNYYYZealand.Models
{
    [Table("Hold")]
    public partial class Hold
    {
        public Hold()
        {
            BogHolds = new HashSet<BogHold>();
            UndervisereHolds = new HashSet<UndervisereHold>();
        }

        [Key]
        [Column("Hold_id")]
        public int HoldId { get; set; }
        [Required]
        [StringLength(50)]
        public string Holdnavn { get; set; }
        [Required]
        [StringLength(50)]
        public string Semester { get; set; }
        [Required]
        [StringLength(50)]
        public string Uddannelse { get; set; }

        [InverseProperty(nameof(BogHold.Hold))]
        public virtual ICollection<BogHold> BogHolds { get; set; }
        [InverseProperty(nameof(UndervisereHold.Hold))]
        public virtual ICollection<UndervisereHold> UndervisereHolds { get; set; }
    }
}