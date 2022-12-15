﻿using System.Configuration;

namespace WebAPI.Helpers
{
    public class ConfigurationHelper
    {

        public static string ServiceUrl => ConfigurationManager.AppSettings["serviceUrl"];
        public static string ContentServiceUrl => ConfigurationManager.AppSettings["contentServiceUrl"];
        public static string AuthorizationToken => ConfigurationManager.AppSettings["token"];
        public static string DefaultFilePath => ConfigurationManager.AppSettings["defaultFilePath"];

    }
}
