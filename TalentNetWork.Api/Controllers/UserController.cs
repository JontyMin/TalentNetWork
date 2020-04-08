using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace TalentNetWork.Api.Controllers
{
    using Entity;
    using IServices;

    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        private readonly IUserServices _userServices;

        public UserController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        [HttpGet]
        [Route("GetUser/{id}")]
        public async Task<IEnumerable<User>> GetUser(int id)
        {
            var ls = await _userServices.Get(id);
            return ls;
        }
    }
}
