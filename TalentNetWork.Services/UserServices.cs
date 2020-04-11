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

        public Task<User> Add(User model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> Get(int id)
        {
           return _IUserRepository.Get(id);
        }

        public Task<List<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<bool> LoginTask(string user, string pwd)
        {
            return _IUserRepository.LoginTask(user, pwd);
        }

        public Task<bool> Update(User model)
        {
            throw new NotImplementedException();
        }
    }
}
