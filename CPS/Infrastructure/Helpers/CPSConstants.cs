using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace CPS.Infrastructure.Helpers
{
    public class CPSConstants
    {
        public static string ErrorFolderpath = ConfigurationManager.AppSettings["ErrorLogsFolderPath"];
        public static string SuperAdminUserName = ConfigurationManager.AppSettings["SuperAdminUserName"];
        public static string SuperAdminPassword = ConfigurationManager.AppSettings["SuperAdminPassword"];
    }
}