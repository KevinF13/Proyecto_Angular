﻿using System.Web;
using System.Web.Mvc;

namespace Agencia_Turismo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
