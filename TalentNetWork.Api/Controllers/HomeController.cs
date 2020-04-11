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

        //[HttpGet]
        //[Route("GetHotJob/{pageIndex}/{pageSize}")]
        /*public async Task<ResponseMessage> GetHotJob(int pageIndex,int pageSize)
        {
            ResponseMessage date = new ResponseMessage()
            {
                Code = 200,
                Data = new
                {
                    ls=await _IJobServices.GetHotJob(pageIndex,pageSize)
                },
                message = "查询完成"
            };
            return date;
        }*/
    }
}
