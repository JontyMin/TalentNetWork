using System;
using System.Net.Http.Headers;
using System.Web.Http.Filters;
namespace TokenTest.Filter
{
    public static class HttpAuthenticationChallengeContextExtensions
    {
        public static void ChallengeWith(this HttpAuthenticationChallengeContext context, string scheme)
        {
            ChallengeWith(context, new AuthenticationHeaderValue(scheme));
        }
        private static void ChallengeWith(HttpAuthenticationChallengeContext context, AuthenticationHeaderValue challenge)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
            context.Result = new AddChallengeOnUnauthorizedResult(challenge, context.Result);
        }
        public static void ChallengeWith(this HttpAuthenticationChallengeContext context, string scheme, string parameter)
        {
            // 第二个参数的作用是根据传进来的scheme也就是"Bearer"和parameter这里为null，创建一个验证头，和前端传过来的token是一样的
            ChallengeWith(context, new AuthenticationHeaderValue(scheme, parameter));
        }
    }
}