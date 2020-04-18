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

        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="Email"></param>
        /// <param name="PassWord"></param>
        /// <returns></returns>
        public Task<User> LoginTask(string Email, string PassWord)
        {
            return _IUserRepository.LoginTask(Email, PassWord);
        }

        public Task<bool> Update(User model)
        {
            throw new NotImplementedException();
        }
    }
}
