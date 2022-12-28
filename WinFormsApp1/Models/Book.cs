using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BooKeeper.Models
{
    [Table("book")]
    [Index(nameof(Category), Name = "category_idx")]
    [Index(nameof(Loaner), Name = "loaner_idx")]
    public partial class Book
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("title")]
        [StringLength(90)]
        public string Title { get; set; }
        [Required]
        [Column("author")]
        [StringLength(45)]
        public string Author { get; set; }
        [Column("year", TypeName = "date")]
        public DateTime Year { get; set; }
        [Column("loaner")]
        public int? Loaner { get; set; }
        [Column("category")]
        public int Category { get; set; }
        [Column("description")]
        [StringLength(250)]
        public string Description { get; set; }

        [ForeignKey(nameof(Category))]
        [InverseProperty("Books")]
        public virtual Category CategoryNavigation { get; set; }
        [ForeignKey(nameof(Loaner))]
        [InverseProperty(nameof(User.Books))]
        public virtual User LoanerNavigation { get; set; }
    }
}
