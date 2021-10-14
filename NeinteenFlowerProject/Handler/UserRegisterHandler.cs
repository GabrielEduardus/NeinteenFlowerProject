using NeinteenFlowerProject.Factory;
using NeinteenFlowerProject.Model;
using NeinteenFlowerProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlowerProject.Handler
{
    public class UserRegisterHandler
    {
        public static void registerMember(string name, DateTime dob, string gender, string address,
            string phoneNumber, string email, string password)
        {
            MsMember mm = MemberFactory.insertMember(name, dob, gender, address, phoneNumber, email, password);
            MemberRepository.insertMember(mm);
        }

        public static bool UniqueEmail(string email)
        {
            MsEmployee me = EmployeeRepository.getEmployeebyEmail(email);
            MsMember mm = MemberRepository.getMemberbyEmail(email);
            if (me != null || mm != null) return false;
            else return true;
        }
    }
}