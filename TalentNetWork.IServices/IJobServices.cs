using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentNetWork.IServices
{
    using Entity;
    public interface IJobServices
    {
        Task<List<Job>> GetAll();
        Task<IEnumerable<Job>> Get(int id);
        Task<Job> Add(Job model);
        Task<bool> Update(Job model);
        Task<bool> Delete(int id);
        int GetCount();
        List<V_Job> GetHotJob(int pageIndex, int pageSize);
    }
}
