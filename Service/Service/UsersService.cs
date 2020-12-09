using Data.IRepository;
using Domain.Entity;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class UsersService : Service<UsersEntity>, IUsersService
    {
        public UsersService(IUsersRepository _repository) : base(_repository)
        { }

        public async Task<string> GetName(Guid id)
        {
            UsersEntity UsersEntity = await base.Get(id);
            return UsersEntity.NickName;
        }
    }
}
