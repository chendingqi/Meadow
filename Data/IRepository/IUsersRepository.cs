using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.IRepository
{
    public interface IUsersRepository : IRepository<UsersEntity>
    {
        string getname();
    }
}
