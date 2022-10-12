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

        protected void dgv__User_RowEditing(object sender, GridViewEditEventArgs e)
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

        protected void dgv__User_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgv__User.PageIndex = e.NewPageIndex;
            List<User> lstUser = Users.getAllUser();
            dgv__User.DataSource = lstUser;
            dgv__User.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string _search = tblSearch.Text.ToString();

            List<User> User = Users.SearchUser(_search);

            if (User.Count != 0)
            {
                dgv__User.DataSource = User;
                dgv__User.DataBind();
                lblErrorMessage.Visible = false;
            }
            else
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Không tìm thấy kết quả!";
            }
               
        }

        protected void ddlPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<User> lstUsers = Users.getAllUser();
            dgv__User.PageSize = Convert.ToInt32(ddlPageSize.SelectedItem.ToString());

            dgv__User.PageIndex = 0;
            dgv__User.DataSource = lstUsers;
            dgv__User.DataBind();
        }
    }
}