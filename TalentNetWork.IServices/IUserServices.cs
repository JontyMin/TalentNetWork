using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentNetWork.IServices
{
    using Entity;
    public interface IUserServices
    {
        Task<List<User>> GetAll();
        Task<IEnumerable<User>> Get(int id);
        Task<User> Add(User model);
        Task<bool> Update(User model);
        Task<bool> Delete(int id);
    }
}
