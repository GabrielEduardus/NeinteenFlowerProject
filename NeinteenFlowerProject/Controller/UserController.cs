using NeinteenFlowerProject.Handler;
using NeinteenFlowerProject.Model;
using NeinteenFlowerProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace NeinteenFlowerProject.Controller
{
    public class UserController
    {
        public static MsMember getMemberbyEmail(string email)
        {
            MsMember mm = UserHandler.getMemberbyEmail(email);
            return mm;
        }

        public static MsEmployee getEmployeebyEmail(string email)
        {
            MsEmployee me = UserHandler.getEmployeebyEmail(email);
            return me;
        }

        public static MsMember getMemberbyId(int id)
        {
            MsMember mm = UserHandler.getMemberbyId(id);
            return mm;
        }

        public static MsEmployee getEmployeebyId(int id)
        {
            MsEmployee me = UserHandler.getEmployeebyId(id);
            return me;
        }

        public static string checkRole(string email)
        {
            string role = UserLoginHandler.checkRole(email);
            return role;
        }

        public static void createSession(HttpSessionState Session, string email)
        {
            string role = UserLoginHandler.checkRole(email);

            if (role == "Member")
            {
                MsMember mm = UserHandler.getMemberbyEmail(email);
                Session["Userlogin"] = mm;
            }
            else
            {
                MsEmployee me = UserHandler.getEmployeebyEmail(email);
                Session["Userlogin"] = me;
            }
            Session["Role"] = role;
        }

        public static void RememberMeCookie(HttpResponse Response, bool isChecked, string email)
        {
            if (isChecked)
            {
                HttpCookie cookie = new HttpCookie("UserInfo");
                string role = UserLoginHandler.checkRole(email);

                if (role == "Member")
                {
                    MsMember mm = UserHandler.getMemberbyEmail(email);
                    cookie.Value = mm.MemberEmail;
                }
                else
                {
                    MsEmployee me = UserHandler.getEmployeebyEmail(email);
                    cookie.Value = me.EmployeeEmail;
                }

                cookie.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(cookie);
            }
        }

        public static void removeCookieAndSession(HttpResponse Response, HttpSessionState Session)
        {
            HttpCookie cookie = new HttpCookie("UserInfo");
            cookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cookie);
            Session["Userlogin"] = null;
        }

        public static string sessionIsMember(HttpResponse Response, HttpSessionState Session)
        {
            MsMember mm = (MsMember)Session["Userlogin"];

            if (checkRole(mm.MemberEmail) == "Employee")
            {
                Response.Redirect("~/View/Employee/Home.aspx");
            }
            else if (checkRole(mm.MemberEmail) == "Administrator")
            {
                Response.Redirect("~/View/Administrator/Home.aspx");
            }

            return "Welcome to Neinteen Flower, " + mm.MemberName;
        }

        public static void sessionIsNull(HttpResponse Response, HttpSessionState Session)
        {
            if (Session["Userlogin"] == null)
            {
                Response.Redirect("~/View/Guest/Login.aspx");
            }
        }

        public static void authenticationForAll(HttpResponse Response, HttpSessionState Session, string curr)
        {
            if (Session["Userlogin"] != null)
            {
                string role = Session["Role"].ToString();
                if (role != curr) Response.Redirect("~/View/" + role + "/Home.aspx");
                else return;
            }
            else return;
        }

        public static string WelcomeLabel(HttpResponse Response, HttpSessionState Session)
        {
            sessionIsNull(Response, Session);
            if (Session["Userlogin"] != null)
            {
                string role = Session["Role"].ToString();
                if (role == "Member")
                {
                    MsMember mm = (MsMember)Session["Userlogin"];
                    return "Welcome to Neinteen Flower, " + mm.MemberName;
                }
                else if (role == "Employee")
                {
                    MsEmployee me = (MsEmployee)Session["Userlogin"];
                    return "Welcome to Neinteen Flower, " + me.EmployeeName;
                }
                else if (role == "Administrator")
                {
                    MsEmployee me = (MsEmployee)Session["Userlogin"];
                    return "Welcome to Neinteen Flower, " + me.EmployeeName;
                }
            }
            return null;
        }
    }
}