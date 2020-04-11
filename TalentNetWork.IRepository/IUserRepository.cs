using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentNetWork.IRepository
{
    using Entity;
    /// <summary>
    /// 用户表接口
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// 获取所有用户
        /// </summary>
        /// <returns>用户列表</returns>
        Task<List<User>> GetAll();

        /// <summary>
        /// 获取单个用户
        /// </summary>
        /// <param name="id">用户id</param>
        /// <returns>用户</returns>
        Task<IEnumerable<User>> Get(int id);

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="model">用户模型</param>
        /// <returns></returns>
        Task<User> Add(User model);

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="model">用户模型</param>
        /// <returns></returns>
        Task<bool> Update(User model);

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id">用户id</param>
        /// <returns></returns>
        Task<bool> Delete(int id);

        Task<bool> LoginTask(string user, string pwd);
    }
}
