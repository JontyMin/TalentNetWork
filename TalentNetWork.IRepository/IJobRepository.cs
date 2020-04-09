using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentNetWork.IRepository
{
    using Entity;
    public interface IJobRepository
    {

        Task<List<Job>> GetAll();
        Task<IEnumerable<Job>> Get(int id);
        Task<Job> Add(Job model);
        Task<bool> Update(Job model);
        Task<bool> Delete(int id);

        Task<IEnumerable<V_JobInfo>> GetHotJob(int pageIndex,int pageSize);
    }
}
