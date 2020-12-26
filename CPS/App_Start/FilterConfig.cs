﻿using CPS.Infrastructure.Filters;
using System.Web;
using System.Web.Mvc;

namespace CPS
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new WebExceptionHandlerFilter());
        }
    }
}
