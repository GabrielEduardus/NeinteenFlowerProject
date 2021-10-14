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
    public partial class UpdateMemberPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string current = "Administrator";
            UserController.sessionIsNull(Response, Session);
            UserController.authenticationForAll(Response, Session, current);

            if (!IsPostBack)
            {
                int id = int.Parse(Request["id"]);
                MsMember show = MemberController.GetMemberByID(id);
                emailTxt.Text = show.MemberEmail;
                passwordTxt.Text = show.MemberPassword;
                nameTxt.Text = show.MemberName;
                if (show.MemberGender == "Male") RadioButton1.Checked = true;
                else RadioButton2.Checked = true;
                DateTime employeeDOB = (DateTime)show.MemberDOB;
                ageBefore.Text = employeeDOB.ToShortDateString();
                phoneNumberTxt.Text = show.MemberPhone.ToString();
                addressTxt.Text = show.MemberAddress;
            }
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request["id"]);
            MsMember show = MemberController.GetMemberByID(id);
            string name = nameTxt.Text;
            bool rbtnCowo = RadioButton1.Checked;
            bool rbtnCewe = RadioButton2.Checked;
            string address = addressTxt.Text;
            string phoneNum = phoneNumberTxt.Text.ToString();
            string emailTmp = show.MemberEmail;
            string email = emailTxt.Text;
            string password = passwordTxt.Text;
            string dob = ageTxt.Text;

            errorEmail.Text = MemberController.validateEmailUpdate(email);
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
                string gender = EmployeeController.chkBoyOrGirl(rbtnCowo, rbtnCewe);
                DateTime tmpDob = DateTime.Parse(ageTxt.Text);
                MemberController.Update(id, name, tmpDob, gender, address, phoneNum, email, password);
                Response.Redirect("~/View/Administrator/ManageMember/ManageMemberPage.aspx");
            }
        }
    }
}