using NeinteenFlowerProject.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlowerProject.View.AdminPage.ManageMember
{
    public partial class InsertMemberPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string current = "Administrator";
            UserController.sessionIsNull(Response, Session);
            UserController.authenticationForAll(Response, Session, current);
        }

        protected void insertBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            bool rbtnCowo = RadioButton1.Checked;
            bool rbtnCewe = RadioButton2.Checked;
            string address = addressTxt.Text;
            string phoneNum = phoneNumberTxt.Text;
            string email = emailTxt.Text;
            string password = passwordTxt.Text;
            string dob = ageTxt.Text;

            errorEmail.Text = MemberController.validateEmail(email);
            errorPassword.Text = MemberController.validatePassword(password);
            errorName.Text = MemberController.validateName(name);
            errorAge.Text = MemberController.validateAge(dob);
            errorGender.Text = MemberController.validateGender(rbtnCowo, rbtnCewe);
            errorPhoneNumber.Text = MemberController.validatePhone(phoneNum);
            errorAddress.Text = MemberController.validateAddress(address);

            if (errorAddress.Text == "" && errorAge.Text == "" && errorEmail.Text == "" &&
                errorGender.Text == "" && errorName.Text == "" && errorPassword.Text == "" &&
                errorPhoneNumber.Text == "")
            {
                string gender = MemberController.chkBoyOrGirl(rbtnCowo, rbtnCewe);
                DateTime tmpDob = DateTime.Parse(ageTxt.Text);
                MemberController.Insert(name, tmpDob, gender, address, phoneNum, email, password);
                Response.Redirect("~/View/Administrator/ManageMember/ManageMemberPage.aspx");
            }
        }
    }
}