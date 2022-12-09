﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjektNYYYZealand.Models
{
    [Table("Bog")]
    public partial class Bog
    {
        public Bog()
        {
            BogHolds = new HashSet<BogHold>();
        }

        [Key]
        [Column("Bog_id")]
        public int BogId { get; set; }
        public int Year { get; set; }
        [Required]
        [StringLength(256)]
        public string Title { get; set; }
        [Required]
        [StringLength(256)]
        public string Forfatter { get; set; }
        [Column("ISBN")]
        public double Isbn { get; set; }
        [StringLength(256)]
        public string Billede { get; set; }

        [InverseProperty(nameof(BogHold.Bog))]
        public virtual ICollection<BogHold> BogHolds { get; set; }
    }
}