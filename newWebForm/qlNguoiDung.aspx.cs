using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace newWebForm
{
    public partial class qlNguoiDung : System.Web.UI.Page
    {
        Connection conn = new Connection();
        protected void Page_Load(object sender, EventArgs e)
        {
            dgv__User.DataSource = conn.getData();
            dgv__User.DataBind();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtUserID.Text = txtUserName.Text = txtPassWord.Text = "";
        }

        protected void dgv__User_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*dgv__User.DataSource = conn.getData();
            dgv__User.DataBind();
            int rows = dgv__User.SelectedIndex;
            DataTable dt = new DataTable();
            txtUserID.Text = dt.Rows[rows][0].ToString();
            txtUserName.Text = dt.Rows[rows][1].ToString();
            txtPassWord.Text = dt.Rows[rows][2].ToString();?*/
        }

        protected void btnThem_Click(object sender, EventArgs e)
        { 
            conn.addData(txtUserName.Text, txtPassWord.Text);
            dgv__User.DataSource = conn.getData();
            dgv__User.DataBind();
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            conn.deleteData(int.Parse(txtUserID.Text));
            dgv__User.DataSource = conn.getData();
            dgv__User.DataBind();
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            conn.updateData(int.Parse(txtUserID.Text), txtUserName.Text, txtPassWord.Text);
            dgv__User.DataSource = conn.getData();
            dgv__User.DataBind();
        }
    }

}
