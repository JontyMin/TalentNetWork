﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        dbhrm db = new dbhrm();

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
            var ls = await db.User.Where(c => c.ID == id).ToListAsync();
            return ls;
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
