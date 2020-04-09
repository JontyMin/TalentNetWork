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

    public class JobServices : IJobServices
    {

        private readonly IJobRepository _IJobRepository;

        public JobServices(IJobRepository IJobRepository)
        {
            _IJobRepository = IJobRepository;
        }
        public Task<Job> Add(Job model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Job>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Job>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<V_JobInfo>> GetHotJob(int pageIndex, int pageSize)
        {
            return _IJobRepository.GetHotJob(pageIndex, pageSize);
        }

        public Task<bool> Update(Job model)
        {
            throw new NotImplementedException();
        }
    }
}
