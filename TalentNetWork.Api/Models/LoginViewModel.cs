using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TalentNetWork.Api.Models
{
    public class LoginViewModel
    {
        /// <summary>
        /// 邮箱
        /// </summary>
        [Required(ErrorMessage = "邮箱不能为空")]
        [EmailAddress(ErrorMessage = "邮箱格式错误")]
        public string Email { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Required(ErrorMessage = "密码不能为空")]
        [MinLength(6,ErrorMessage = "密码长度在6-20之间")]
        public string PassWord { get; set; }
    }
}