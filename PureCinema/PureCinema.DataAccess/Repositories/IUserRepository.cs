using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureCinema.DataAccess.Models;

namespace PureCinema.DataAccess.Repositories
{
    public interface IUserRepository
    {
        User GetUser(int userId);
    }
}
