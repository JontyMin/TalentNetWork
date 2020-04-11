﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace TalentNetWork.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务

            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            
            //配置返回数据为json
            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling =
                Newtonsoft.Json.PreserveReferencesHandling.Objects;  //把Json格式化器设置为防止对对象引用

            config.Formatters.Remove(config.Formatters.XmlFormatter);
        }
    }
}
