using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Web;
using Microsoft.IdentityModel.Tokens;

namespace TalentNetWork.Api
{
    public class TokenHelper
    {
        private const string Secret = "db3OIsj+BXE9NZDy0t8W3TcNekrF+2d/1sFnWG4HnV8TZY30iTOdtVWJG8abWvB1GlOgJuQZdcF2Luqm/hccMw==";
        public static string GenerateToken(string username, int expireMinutes = 120)
        { // 此方法用来生成 Token 
            var symmetricKey = Convert.FromBase64String(Secret);  // 生成二进制字节数组
            var tokenHandler = new JwtSecurityTokenHandler(); // 创建一个JwtSecurityTokenHandler类用来生成Token
            var now = DateTime.UtcNow; // 获取当前时间
            var tokenDescriptor = new SecurityTokenDescriptor // 创建一个 Token 的原始对象
            {
                Subject = new ClaimsIdentity(new[] // Token的身份证，类似一个人可以有身份证，户口本
                        {
                            new Claim(ClaimTypes.Name, username) // 可以创建多个
                        }),

                Expires = now.AddMinutes(Convert.ToInt32(expireMinutes)), // Token 有效期

                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(symmetricKey), SecurityAlgorithms.HmacSha256)
                // 生成一个Token证书，第一个参数是根据预先的二进制字节数组生成一个安全秘钥，说白了就是密码，第二个参数是编码方式
            };
            var stoken = tokenHandler.CreateToken(tokenDescriptor); // 生成一个编码后的token对象实例
            var token = tokenHandler.WriteToken(stoken); // 生成token字符串，给前端使用
            return token;
        }
        public static ClaimsPrincipal GetPrincipal(string token)
        { // 此方法用解码字符串token，并返回秘钥的信息对象
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler(); // 创建一个JwtSecurityTokenHandler类，用来后续操作
                var jwtToken = tokenHandler.ReadToken(token) as JwtSecurityToken; // 将字符串token解码成token对象
                if (jwtToken == null)
                    return null;
                var symmetricKey = Convert.FromBase64String(Secret); // 生成编码对应的字节数组
                var validationParameters = new TokenValidationParameters() // 生成验证token的参数
                {
                    RequireExpirationTime = true, // token是否包含有效期
                    ValidateIssuer = false, // 验证秘钥发行人，如果要验证在这里指定发行人字符串即可
                    ValidateAudience = false, // 验证秘钥的接受人，如果要验证在这里提供接收人字符串即可
                    IssuerSigningKey = new SymmetricSecurityKey(symmetricKey) // 生成token时的安全秘钥
                };
                SecurityToken securityToken; // 接受解码后的token对象
                var principal = tokenHandler.ValidateToken(token, validationParameters, out securityToken);
                return principal; // 返回秘钥的主体对象，包含秘钥的所有相关信息
            }

            catch (Exception)
            {
                return null;
            }
        }

    }
}