using BooKeeper.Data;
using BooKeeper.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BooKeeper.Services.Impl;

public class UserRepository : IUserRepository
{

    private readonly BookDbContext _dbContext;
    private readonly IEnumerable<User> _users;

    public UserRepository(BookDbContext dbContext)
    {
        _dbContext = dbContext;
        _users = dbContext.Users;
    }

    public User GetUserByEmail(string email)
    {
        return _users.First(user => user.Email.Equals(email));
    }

    public User? GetUserByUsername(string username) => _users.FirstOrDefault(user => user.Username.Equals(username));
}
