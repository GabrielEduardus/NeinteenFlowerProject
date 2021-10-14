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
    public partial class updateFlower : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string current = "Employee";
            UserController.sessionIsNull(Response, Session);
            UserController.authenticationForAll(Response, Session, current);

            if (!IsPostBack)
            {
                int id = int.Parse(Request["id"]);
                MsFlower mf = FlowerController.GetFlowerByID(id);
                flowerImg.ImageUrl = mf.FlowerImage;
                tbName.Text = mf.FlowerName;
                tbDesc.Text = mf.FlowerDescription;
                tbPrice.Text = mf.FlowerPrice.ToString();
                dlType.SelectedIndex = mf.FlowerTypeID;

                setFlowerType();
                dlType.SelectedIndex = mf.FlowerTypeID;
            }
        }

        private void setFlowerType()
        {
            dlType.Items.Add("Select the type");
            dlType.Items.Add("Daisies");
            dlType.Items.Add("Lilies");
            dlType.Items.Add("Roses");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request["id"]);

            string name = tbName.Text;
            string picturePath = "";
            string description = tbDesc.Text;
            int selectedType = dlType.SelectedIndex;
            int price;
            try
            {
                price = int.Parse(tbPrice.Text);
            }
            catch (Exception arg02)
            {
                price = 0;
            }


            errName.Text = FlowerController.validateName(name);
            errDesc.Text = FlowerController.validateDesc(description);
            errPrice.Text = FlowerController.validatePrice(price);
            errType.Text = FlowerController.validateType(selectedType);

            var file = filePic.PostedFile;
            string extention = System.IO.Path.GetExtension(file.FileName);
            errImg.Text = FlowerController.validateImg(extention);


            if(errName.Text == "" && errDesc.Text == "" && errPrice.Text == "" && errType.Text == "" && errImg.Text == "")
            {
                //Masukin image
                var filePath = HttpContext.Current.Server.MapPath("~/Assets/" + file.FileName);
                file.SaveAs(filePath);
                // masukin ke picturePath
                picturePath = "~/Assets/" + file.FileName;

                FlowerController.update(id, name, selectedType, description, price, picturePath);
                Response.Redirect("~/View/Employee/manageFlower.aspx");
            }
        }
    }
}