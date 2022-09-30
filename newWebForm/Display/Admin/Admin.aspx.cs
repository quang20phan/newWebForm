using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using newWebForm.DAO;
using newWebForm.Entity;

namespace newWebForm.Display.Admin
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                List<User> lstUser = Users.getAllUser();
                dgv__User.DataSource = lstUser;
                dgv__User.DataBind();
            }
        }

        protected void dgv__User_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int _id = Convert.ToInt32(dgv__User.DataKeys[e.RowIndex].Value);
            if (Users.Delete(_id))
            {
                Response.Redirect("/Display/Admin/Admin.aspx");
            }
            else
            {
                Response.Write("loi");
                Response.End();
            }

        }

        protected void dgv__gvUser_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int _id = Convert.ToInt32(dgv__User.DataKeys[e.NewEditIndex].Value);
            User user = Users.GetUserById(_id);
            string id = user.userID.ToString();
            Response.Redirect("/Display/updateUser?user_id=" + id);
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Display/updateUser");
        }

    }
}