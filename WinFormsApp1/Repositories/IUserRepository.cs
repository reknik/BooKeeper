using BooKeeper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooKeeper.Repositories;

public interface IUserRepository
{
    User? GetUserByEmail(string email);
    User? GetUserByUsername(string username);

    void SaveUser(User user);
    void UpdateUser(User user);
}
