using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BooKeeper.Models
{
    [Table("book")]
    [Index(nameof(Category), Name = "category_idx")]
    public partial class Book
    {
        public Book() => UserBooks = new HashSet<UserBook>();

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
        [Column("category")]
        public int Category { get; set; }
        [Column("description")]
        [StringLength(250)]
        public string Description { get; set; }

        [Column("cover")]
        [StringLength(450)]
        public string CoverPath { get; set; }
        [Column("available")]
        public int Available { get; set; }
        [Column("totalNumber")]
        public int TotalNumber { get; set; }

        [ForeignKey(nameof(Category))]
        [InverseProperty("Books")]
        public virtual Category CategoryNavigation { get; set; }
        [InverseProperty(nameof(UserBook.Book))]
        public virtual ICollection<UserBook> UserBooks { get; set; }

        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine("Title :" + this.Title)
                .AppendLine("Author :" + this.Author)
                .AppendLine("Year :" + this.Year)
                .AppendLine("Category :" + this.CategoryNavigation.Name)
                .AppendLine("Description :" + this.Description)
                .AppendLine("Total number :" + this.TotalNumber)
                .AppendLine("Available :" + this.Available)
                .ToString();
        }
    }
}
