using NeinteenFlowerProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlowerProject.Factory
{
    public class MemberFactory
    {
        public static MsMember insertMember(string memberName, DateTime memberDob, string memberGender,
            string memberAddress, string memberPhoneNumber, string memberEmail, string memberPassword)
        {
            MsMember mm = new MsMember();
            mm.MemberName = memberName;
            mm.MemberDOB = memberDob;
            mm.MemberGender = memberGender;
            mm.MemberAddress = memberAddress;
            mm.MemberPhone = memberPhoneNumber;
            mm.MemberEmail = memberEmail;
            mm.MemberPassword = memberPassword;

            return mm;
        }
    }
}