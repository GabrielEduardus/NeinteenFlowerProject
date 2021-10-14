using NeinteenFlowerProject.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlowerProject.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string current = "Guest";
            UserController.authenticationForAll(Response, Session, current);
        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            string email = emailTxt.Text;
            string password = passwordTxt.Text;
            bool rbtnCowo = RadioButton1.Checked;
            bool rbtnCewe = RadioButton2.Checked;
            string name = nameTxt.Text;
            string dob = ageTxt.Text;
            string phoneNumber = phoneNumberTxt.Text;
            string address = addressTxt.Text;

            errorEmail.Text = UserRegisterController.validateEmail(email);
            errorPassword.Text = UserRegisterController.validatePassword(password);
            errorName.Text = UserRegisterController.validateName(name);
            errorAge.Text = UserRegisterController.validateAge(dob);
            errorGender.Text = UserRegisterController.validateGender(rbtnCowo, rbtnCewe);
            errorPhoneNumber.Text = UserRegisterController.validatePhone(phoneNumber);
            errorAddress.Text = UserRegisterController.validateAddress(address);

            if (errorEmail.Text == "" && errorPassword.Text == "" && errorName.Text == "" && errorAge.Text == "" &&
                errorGender.Text == "" && errorPhoneNumber.Text == "" && errorAddress.Text == "")
            {
                string gender = MemberController.chkBoyOrGirl(rbtnCowo, rbtnCewe);
                DateTime tmpDob = DateTime.Parse(ageTxt.Text);
                errorRegister.Text = UserRegisterController.registerMember(name, tmpDob, gender, address, phoneNumber, email, password);
            }
        }
    }
}