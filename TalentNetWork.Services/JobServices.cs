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

        public int GetCount() => _IJobRepository.GetCount();


        public Task<bool> Update(Job model)
        {
            throw new NotImplementedException();
        }

        List<V_Job> IJobServices.GetHotJob(int pageIndex, int pageSize)
        {
            return _IJobRepository.GetHotJob(pageIndex, pageSize);
        }
    }
}
