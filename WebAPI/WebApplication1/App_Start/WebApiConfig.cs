﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Net.Http.Headers;
using System.Web.Http.Cors;
using System.Data.SqlClient;

namespace WebApplication1
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));

            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=tcp:whosatwork.database.windows.net;Initial Catalog=IP_Project_DataBase;User id=dev;Password=vacasipuiu2!";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            cnn.Close();

        }
    }
}
