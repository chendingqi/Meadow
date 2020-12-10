using Data.IRepository;
using Domain.Entity;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class UsersService : Service<UsersEntity>, IUsersService
    {
        private readonly IUsersRepository usersRepository;
        public UsersService(IEnumerable<IUsersRepository>  _repository) : base(_repository.FirstOrDefault(h=>h.GetType().Name== "UsersNewRepository"))
        { usersRepository = _repository.FirstOrDefault(h => h.GetType().Name == "UsersNewRepository"); }

        public async Task<string> GetName(Guid id)
        {
            var a = usersRepository.getname();

            UsersEntity UsersEntity = await base.Get(id);

            return a;
        }
    }
}
