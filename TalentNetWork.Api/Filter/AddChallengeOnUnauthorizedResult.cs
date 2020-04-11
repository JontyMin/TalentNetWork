using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
namespace TokenTest.Filter
{
    public class AddChallengeOnUnauthorizedResult : IHttpActionResult
    {
        public AuthenticationHeaderValue _Challenge { get; }
        public IHttpActionResult _InnerResult { get; }
        public AddChallengeOnUnauthorizedResult(AuthenticationHeaderValue challenge, IHttpActionResult innerResult)
        {
            _Challenge = challenge;
            _InnerResult = innerResult;
        }
        public async Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            // 这里讲schemee也就是"Bearer"生成后的response返回给浏览器去做判断，如果浏览器请求的Authenticate中含有含有名为"Bearer"的scheme会返回200状态码否则返回401状态码
            HttpResponseMessage response = await _InnerResult.ExecuteAsync(cancellationToken);
            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                // 如果这里不成立，但是我们之前做的验证都是成功的，这是不对的，可能出现意外情况啥的
                // 这时我们手动添加一个名为"Bearer"的sheme，让请求走通
                // 到此，完毕。
                if (response.Headers.WwwAuthenticate.All(h => h.Scheme != _Challenge.Scheme))
                {
                    response.Headers.WwwAuthenticate.Add(_Challenge);
                }
            }
            return response;
        }
    }
}