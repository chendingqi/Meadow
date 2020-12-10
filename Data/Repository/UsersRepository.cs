﻿using Data.Context;
using Data.IRepository;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class UsersRepository : Repository<UsersEntity>, IUsersRepository
    {

        public UsersRepository(MeadowContext _context) : base(_context)
        {
        }

        public string getname()
        {
            return "old";
        }
    }
}
