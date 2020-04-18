using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TalentNetWork.Api.Models
{
    public class ResponseData
    {
        /// <summary>
        /// 状态码
        /// </summary>
        public int Code { get; set; }
        /// <summary>
        /// 返回数据
        /// </summary>
        public object Data { get; set; }
        /// <summary>
        /// 返回消息
        /// </summary>
        public string Message { get; set; }
    }
}