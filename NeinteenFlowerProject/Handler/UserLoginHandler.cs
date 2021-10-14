using NeinteenFlowerProject.Model;
using NeinteenFlowerProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlowerProject.Handler
{
    public class UserLoginHandler
    {
        public static bool CheckEmail(string email)
        {
            MsMember mm = MemberRepository.getMemberbyEmail(email);
            MsEmployee me = EmployeeRepository.getEmployeebyEmail(email);

            if (mm != null || me != null) return true;
            return false;
        }

        public static bool CheckPassword(string email, string password)
        {
            MsMember mm = MemberRepository.getMemberbyEmail(email);
            MsEmployee me = EmployeeRepository.getEmployeebyEmail(email);

            if (mm != null)
            {
                if (mm.MemberPassword.Equals(password)) return true;
            }

            if (me != null)
            {
                if (me.EmployeePassword.Equals(password)) return true;
            }

            return false;
        }

        public static string checkRole(string email)
        {
            MsMember mm = MemberRepository.getMemberbyEmail(email);
            MsEmployee me = EmployeeRepository.getEmployeebyEmail(email);

            if (mm != null) return "Member";
            if (me != null)
            {
                if (me.EmployeePosition == "Employee") return "Employee";
                if (me.EmployeePosition == "Administrator") return "Administrator";
            }

            return null;
        }

        public static void updatePassword(string email, string newPassword)
        {
            string role = checkRole(email);

            if (role == "Member") MemberRepository.updatePassword(email, newPassword);
            if (role == "Employee" || role == "Administrator") EmployeeRepository.updatePassword(email, newPassword);
        }
    }
}