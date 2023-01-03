using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BooKeeper.Models;

[Table("user")]
public partial class User
{
    public User()
    {
        Books = new HashSet<Book>();
    }

    public User(string username, string password)
    {
        this.Username = username;
        this.Password = password;
        Books = new HashSet<Book>();
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
    [StringLength(32)]
    public string Password { get; set; }
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [InverseProperty(nameof(Book.LoanerNavigation))]
    public virtual ICollection<Book> Books { get; set; }
}
