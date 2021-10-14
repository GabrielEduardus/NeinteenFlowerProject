using NeinteenFlowerProject.Controller;
using NeinteenFlowerProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlowerProject.View.AdminPage.ManageMember
{
    public partial class ManageMemberPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string current = "Administrator";
            UserController.sessionIsNull(Response, Session);
            UserController.authenticationForAll(Response, Session, current);

            var members = MemberController.GetAllMember();
            gvMember.DataSource = members;
            gvMember.DataBind();
        }

        protected void gvMember_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = gvMember.Rows[e.NewEditIndex];
            int id = int.Parse(row.Cells[0].Text.ToString());
            Response.Redirect("~/View/Administrator/ManageMember/UpdateMemberPage.aspx?id=" + id);
        }

        protected void gvMember_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = gvMember.Rows[e.RowIndex];
            int id = int.Parse(row.Cells[0].Text.ToString());

            MemberController.delete(id);
            Response.Redirect("~/View/Administrator/ManageMember/ManageMemberPage.aspx");
        }

    }
}