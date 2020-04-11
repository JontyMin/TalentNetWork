using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace TalentNetWork.Repository
{
    using Entity;
    using IRepository;

    public class UserRepository : IUserRepository
    {
        private dbhrm db = new dbhrm();

        public Task<User> Add(User model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> Get(int id)
        {
            return await db.User.Where(c => c.ID == id).ToListAsync();
            
        }

        public Task<List<User>> GetAll()
        {
            throw new NotImplementedException();
        }


        public Task<bool> Update(User model)
        {
            throw new NotImplementedException();
        }
    }
}
