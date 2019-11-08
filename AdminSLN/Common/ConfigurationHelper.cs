using System;
using System.Configuration;

namespace Common
{
    public static class ConfigurationHelper
    {
        public static string AppSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
