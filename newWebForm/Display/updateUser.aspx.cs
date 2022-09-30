using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using newWebForm.Entity;
using newWebForm.DAO;


namespace newWebForm.Display
{
    public partial class updateUser : System.Web.UI.Page
    {
        int queryID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            queryID = Convert.ToInt32(Page.Request.QueryString["user_id"]);

            if (!Page.IsPostBack)
            {
                if (queryID > 0)
                {
                    
                    User user = Users.GetUserById(queryID);
                    txtUserID.Text = queryID.ToString();
                    txtUserName.Text = user.userName;
                    txtPass.Text = user.userPassWord;

                }
               
            }
        }

        protected void btn_Save_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.userID = queryID;
            user.userName = txtUserName.Text;
            user.userPassWord = txtPass.Text;
            if (Users.CreateOrUpdate(user))
            {
                Response.Redirect("/Display/Admin/Admin.aspx");
            }
        }
    }
}