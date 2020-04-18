using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.UI;
using TalentNetWork.Api.Models;
using TokenTest.Filter;

namespace TalentNetWork.Api.Controllers
{
    using IServices;

    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        private readonly IUserServices _userServices;

        public UserController(IUserServices userServices)
        {
            _userServices = userServices;
        }
        /// <summary>
        /// 获取登录token
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("login")]
        [AllowAnonymous]
        [Obsolete]
        public async Task<IHttpActionResult> Login([FromUri]LoginViewModel model)
        {

            if (!ModelState.IsValid)
            {
                string error = string.Empty;
                foreach (var key in ModelState.Keys)
                {
                    var state = ModelState[key];
                    if (state.Errors.Any())
                    {
                        error = state.Errors.First().ErrorMessage;
                        break;
                    }
                }
                return Ok(new ResponseData() { Code =400,Data=null, Message = error });
            }

            model.PassWord =
                    System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(model.PassWord, "MD5");
            var user = await _userServices.LoginTask(model.Email, model.PassWord);


            if (user == null)
                return Ok(new ResponseData()
                {
                    Code = 404,
                    Data = null,
                    Message = "邮箱地址或密码错误"

                });

            return Ok(new ResponseData()
                {
                    Code = 200,
                    Data = new
                    {
                        uid = user.ID,
                        urealName = user.RealName,
                        
                        token = TokenHelper.GenerateToken(model.Email)
                    },
                    Message = "登录成功"
                });
            
        }


    }
}
