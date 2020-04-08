using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentNetWork.Services
{
    using IServices;
    using Entity;
    using IRepository;

    public class UserServices : IUserServices
    {
        private readonly IUserRepository _IUserRepository;

        public UserServices(IUserRepository IUserRepository)
        {
            _IUserRepository = IUserRepository;
        }
        public Task<IEnumerable<User>> Get(int id)
        {
           return _IUserRepository.Get(id);
        }
    }
}
