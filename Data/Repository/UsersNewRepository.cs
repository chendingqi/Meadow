using Data.Context;
using Data.IRepository;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public class UsersNewRepository : Repository<UsersEntity>, IUsersRepository
    {
        public UsersNewRepository(MeadowContext _context) : base(_context)
        {
        }

        public string getname()
        {
            return "new";
        }
    }
}
