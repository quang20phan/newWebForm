﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using newWebForm.Entity;
using newWebForm.DAO;

 

namespace newWebForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn__Login_Click(object sender, EventArgs e)
        {
            List<User> users = Users.getOneUser(txt_userName.Text, txt_userPassWord.Text);

            if (users.Count > 0)
            {

                Response.Redirect("Default.aspx");
                Response.End();
            }
        }
    }
}