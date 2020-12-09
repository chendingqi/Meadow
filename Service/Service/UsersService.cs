using Data.IRepository;
using Domain.Entity;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Service
{
    public class UsersService : Service<UsersEntity>, IUsersService
    {
        public UsersService(IUsersRepository _repository) : base(_repository)
        {
        }
    }
}
