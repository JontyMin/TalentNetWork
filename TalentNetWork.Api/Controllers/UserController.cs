using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.UI;
using TokenTest.Filter;

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
        [HttpGet,Route("Login/{user}/{pwd}")]
        [AllowAnonymous]
        [Obsolete]
        public async Task<string> Login(string user, string pwd)
        {
            pwd = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(pwd, "MD5");
            if (await _userServices.LoginTask(user,pwd))
            {
                return TokenHelper.GenerateToken(user);
            }
            throw new HttpResponseException(HttpStatusCode.Unauthorized);
        }

        /// <summary>
        /// 根据用户id获取用户
        /// </summary>
        /// <param name="id">用户id</param>
        /// <returns></returns>
        [Authentication]
        [HttpGet,Route("GetUser/{id}")]
        public async Task<IHttpActionResult> GetUser(int id)
        {
            var ls = await _userServices.Get(id);
            return Ok(ls);
        }


    }
}
