using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BooKeeper.Models
{
    [Table("user_book")]
    [Index(nameof(BookId), Name = "bookId_idx")]
    public partial class UserBook
    {
        [Key]
        [Column("userId")]
        public int UserId { get; set; }
        [Key]
        [Column("bookId")]
        public int BookId { get; set; }

        [ForeignKey(nameof(BookId))]
        [InverseProperty("UserBooks")]
        public virtual Book Book { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("UserBooks")]
        public virtual User User { get; set; }
    }
}
