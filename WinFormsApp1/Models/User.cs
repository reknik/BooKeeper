using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BooKeeper.Models
{
    [Table("user")]
    public partial class User
    {
        public User()
        {
            UserBooks = new HashSet<UserBook>();
        }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        [Required]
        [Column("username")]
        [StringLength(16)]
        public string Username { get; set; }
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; }
        [Required]
        [Column("password")]
        [StringLength(128)]
        public string Password { get; set; }
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [InverseProperty(nameof(UserBook.User))]
        public virtual ICollection<UserBook> UserBooks { get; set; }
    }
}
