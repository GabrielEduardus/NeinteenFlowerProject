using NeinteenFlowerProject.Controller;
using NeinteenFlowerProject.Model;
using NeinteenFlowerProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlowerProject.View
{
    public partial class manageFlower : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string current = "Employee";
            UserController.sessionIsNull(Response, Session);
            UserController.authenticationForAll(Response, Session, current);

            var flowers = FlowerController.GetAllFlower();
            gvItem.DataSource = flowers;
            gvItem.DataBind();
        }

        protected void gvItem_RowEditing(object sender, GridViewEditEventArgs e)
        {
            // pake url
            GridViewRow row = gvItem.Rows[e.NewEditIndex];
            int id = int.Parse(row.Cells[0].Text.ToString());

            Response.Redirect("~/View/Employee/updateFlower.aspx?id=" + id);
        }

        protected void gvItem_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = gvItem.Rows[e.RowIndex];
            // ambil id di cell row ke 1 (Flower Id)
            int id = int.Parse(row.Cells[0].Text.ToString());

            FlowerController.delete(id);

            Response.Redirect("~/View/Employee/manageFlower.aspx");
        }

        protected void gvItem_RowEditing1(object sender, GridViewEditEventArgs e)
        {

        }

        protected void gvItem_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}