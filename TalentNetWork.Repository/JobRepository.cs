using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentNetWork.Repository
{
    using Entity;
    using IRepository;

    public class JobRepository : IJobRepository
    {
        private dbhrm db = new dbhrm();
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

        public Task<bool> Update(Job model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取热度最高的工作
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<V_Job> GetHotJob(int pageIndex,int pageSize)
        {
            //return await db.V_JobInfo.OrderByDescending(x=>x.Hits)
            //    .Skip((pageIndex - 1) * pageSize)
            //    .Take(pageSize)
            //    .ToListAsync();
            var sql = "select * from v_job";
            var order = "order by hits desc";
            var sp = new SqlParameter[]
            {
                new SqlParameter("@sql",sql),
                new SqlParameter("@PageIndex",pageIndex), 
                new SqlParameter("@Pagesize",pageSize), 
                new SqlParameter("@OrderByField",order), 
                new SqlParameter("@TotalRecord",SqlDbType.Int)
            };
            sp[4].Direction = ParameterDirection.Output;

            return db.V_Job
                .SqlQuery("Exec Pro_PageProcedure @sql,@PageIndex,@Pagesize,@OrderByField,@TotalRecord out", sp)
                .ToList();
           
        }


        public int GetCount() =>db.V_Job.Count();
    }
}
