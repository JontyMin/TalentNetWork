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
        Task<IEnumerable<User>> Get(int id);
    }
}
