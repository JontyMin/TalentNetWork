using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Filters;
using TalentNetWork.Api;

namespace TokenTest.Filter
{
    // IAuthenticationFilter用来自定义一个webapi控制器方法属性
    public class AuthenticationAttribute : Attribute, IAuthenticationFilter
    {
        public bool AllowMultiple => false;
        public string Realm { get; set; }

        public async Task AuthenticateAsync(HttpAuthenticationContext context, CancellationToken cancellationToken)
        {
            // 当api发送请求，自动调用这个方法
            var request = context.Request; // 获取请求的请求体
            var authorization = request.Headers.Authorization; // 获取请求的token对象
            if (authorization == null || authorization.Scheme != "Bearer") return;
            if (string.IsNullOrEmpty(authorization.Parameter))
            {
                // 给ErrorResult赋值需要一个类实现了IHttpActionResult接口
                // 此类声明在AuthenticationFailureResult.cs文件中，此文件用来处理错误信息。
                context.ErrorResult = new AuthenticationFailureResult("Missing Jwt Token", request);
                return;
            }

            var token = authorization.Parameter; // 获取token字符串
            var principal = await AuthenticateJwtToken(token); // 调用此方法，根据token生成对应的"身份证持有人"
            if (principal == null)
            {
                context.ErrorResult = new AuthenticationFailureResult("Invalid token", request);
            }
            else
            {
                context.Principal = principal; // 设置身份验证的主体
            }

            // 此法调用完毕后，会调用ChallengeAsync方法，从而来完成WWW-Authenticate验证
        }

        private Task<IPrincipal> AuthenticateJwtToken(string token)
        {
            string userName;
            if (ValidateToken(token, out userName))
            {
                // 这里就是验证成功后要做的逻辑，也就是处理WWW-Authenticate验证
                var info = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, userName)
                }; // 根据验证token后获取的用户名重新在建一个声明，你个可以在这里创建多个声明
                // 作者注： claims就像你身份证上面的信息，一个Claim就是一条信息，将这些信息放在ClaimsIdentity就构成身份证了
                var infos = new ClaimsIdentity(info, "Jwt");
                // 将上面的身份证放在ClaimsPrincipal里面，相当于把身份证给持有人
                IPrincipal user = new ClaimsPrincipal(infos);
                return Task.FromResult(user);
            }

            return Task.FromResult<IPrincipal>(null);
        }

        private bool ValidateToken(string token, out string userName)
        {
            userName = null;
            var simplePrinciple = TokenHelper.GetPrincipal(token); // 调用自定义的GetPrincipal获取Token的信息对象
            var identity = simplePrinciple?.Identity as ClaimsIdentity; // 获取主声明标识
            if (identity == null) return false;
            if (!identity.IsAuthenticated) return false;
            var userNameClaim = identity.FindFirst(ClaimTypes.Name); // 获取声明类型是ClaimTypes.Name的第一个声明
            userName = userNameClaim?.Value; // 获取声明的名字，也就是用户名
            if (string.IsNullOrEmpty(userName)) return false;
            return true;
            // 到这里token本身的验证工作已经完成了，因为用户名可以解码出来
            // 后续要验证的就是浏览器的 WWW-Authenticate
            /*
                什么是WWW-Authenticate验证？？？
                WWW-Authenticate是早期的一种验证方式，很容易被破解，浏览器发送请求给后端，后端服务器会解析传过来的Header验证
                如果没有类似于本文格式的token，那么会发送WWW-Authenticate: Basic realm= "." 到前端浏览器，并返回401
            */
        }

        public Task ChallengeAsync(HttpAuthenticationChallengeContext context, CancellationToken cancellationToken)
        {
            // 此方法在AuthenticateAsync方法调用完成之后自动调用
            ChallengeAsync(context);
            return Task.FromResult(0);
        }

        private void ChallengeAsync(HttpAuthenticationChallengeContext context)
        {
            string parameter = null;
            if (!string.IsNullOrEmpty(Realm))
            {
                parameter = "realm=\"" + Realm + "\"";
            } // token的parameter部分已经通过jwt验证成功，这里只需要验证scheme即可

            context.ChallengeWith("Bearer",
                parameter); // 这个自定义扩展方法定义在HttpAuthenticationChallengeContextExtensions.cs文件中
            // 主要用来验证token的Schema是不是Bearer
        }
    }
}
