using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NeinteenFlowerProject.Model;
using NeinteenFlowerProject.Repository;

namespace NeinteenFlowerProject.Handler
{
    public class UserHandler
    {
        public static MsMember getMemberbyEmail(string email)
        {
            MsMember mm = MemberRepository.getMemberbyEmail(email);
            return mm;
        }

        public static MsEmployee getEmployeebyEmail(string email)
        {
            MsEmployee me = EmployeeRepository.getEmployeebyEmail(email);
            return me;
        }

        public static MsMember getMemberbyId(int id)
        {
            MsMember mm = MemberRepository.GetMemberByID(id);
            return mm;
        }

        public static MsEmployee getEmployeebyId(int id)
        {
            MsEmployee me = EmployeeRepository.GetEmployeeByID(id);
            return me;
        }
    }
}