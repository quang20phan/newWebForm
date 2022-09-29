using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using newWebForm.Entity;

namespace newWebForm.Display.myMasterPages
{
    public partial class Home : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Common.checkLogin())
            {
                lblHello.Text = Page.Session["user__name"].ToString();
            }
            else
            {
                Response.Redirect("/formLogin.aspx");
            }
        }
    }
}