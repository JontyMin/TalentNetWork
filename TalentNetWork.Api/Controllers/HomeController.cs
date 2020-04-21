using System.Threading.Tasks;
using System.Web.Http;

namespace TalentNetWork.Api.Controllers
{
    using IServices;

    [RoutePrefix("api/home")]
    public class HomeController : ApiController
    {

        private readonly IJobServices _IJobServices;

        public HomeController(IJobServices IJobServices)
        {
            _IJobServices = IJobServices;
        }

        [HttpGet, Route("hotJobs/{pageIndex}")]
        public IHttpActionResult GetHotJob(int pageIndex)
        {
            var pageSize = 5;
            var count = _IJobServices.GetCount();
            var data = _IJobServices.GetHotJob(pageIndex, pageSize);
            return Ok(new
            {
                count = count,
                data = data
            });
        }
    }
}
