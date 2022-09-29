using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newWebForm.Entity
{
    public class Common
    {
        public static bool checkLogin()
        {
            if (HttpContext.Current.Session["user__name"] == null)
            {
                return false;
            }
            else
                return true;

        }
    }
}