using NeinteenFlowerProject.Controller;
using NeinteenFlowerProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlowerProject.View.AdminPage.ManageEmployee
{
    public partial class ManageEmployeePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string current = "Administrator";
            UserController.sessionIsNull(Response, Session);
            UserController.authenticationForAll(Response, Session, current);

            var employees = EmployeeController.GetAllEmployee();
            gvEmployee.DataSource = employees;
            gvEmployee.DataBind();
        }

        protected void gvEmployee_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = gvEmployee.Rows[e.NewEditIndex];
            int id = int.Parse(row.Cells[0].Text.ToString());
            Response.Redirect("~/View/Administrator/ManageEmployee/UpdateEmployeePage.aspx?id=" + id);
        }

        protected void gvEmployee_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = gvEmployee.Rows[e.RowIndex];
            int id = int.Parse(row.Cells[0].Text.ToString());

            EmployeeController.delete(id);
            Response.Redirect("~/View/Administrator/ManageEmployee/ManageEmployeePage.aspx");
        }
    }
}