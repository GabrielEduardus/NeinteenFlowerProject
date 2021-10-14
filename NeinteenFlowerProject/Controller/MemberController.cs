using NeinteenFlowerProject.Handler;
using NeinteenFlowerProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlowerProject.Controller
{
    public class MemberController
    {
        public static MsMember GetMemberByID(int id)
        {
            MsMember member = MemberHandler.GetMemberByID(id);
            return member;
        }

        public static List<MsMember> GetAllMember()
        {
            return MemberHandler.GetAllMember();
        }

        public static void Insert(string name, DateTime dob, string gender,
            string address, string phoneNumber, string email, string password)
        {
            MemberHandler.insert(name, dob, gender, address, phoneNumber, email, password);
        }

        public static void Update(int id, string name, DateTime dob, string gender,
            string address, string phoneNumber, string email, string password)
        {
            MemberHandler.update(id, name, dob, gender, address, phoneNumber, email, password);
        }

        public static string validateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return "Name must be filled!";
            if (name.Length < 3 || name.Length > 20) return "Name must be between 3 and 20 characters";
            if (!name.All(x => ((x >= 65 && x <= 90) || (x >= 97 && x <= 122) || (x == 32)))) return "Name must be letter";
            return null;
        }

        public static string validatePhone(string phoneNumber)
        {
            if (String.IsNullOrWhiteSpace(phoneNumber)) return "Phone Number must be filled!";
            if (!phoneNumber.All(c => (c >= 48 && c <= 57))) return "Phone Number must be numeric";
            return null;
        }

        public static string validateAge(string dob)
        {
            if (dob == "")
            {
                return "Date must be filled";
            }
            DateTime tmpDob = DateTime.Parse(dob);
            int cekTahun = DateTime.Now.Year - tmpDob.Year;
            if (cekTahun > 17) return null;
            if (cekTahun == 17)
            {
                if (DateTime.Now.Month > tmpDob.Month) return null;
                if (DateTime.Now.Month == tmpDob.Month)
                {
                    if (DateTime.Now.Day >= tmpDob.Day)
                    {
                        return null;
                    }
                }
            }
            return "Age must be atleast 17 years old";
        }

        public static string chkBoyOrGirl(bool genderCowo, bool genderCewe)
        {
            if (genderCowo == true)
            {
                return "Male";
            }
            return "Female";
        }

        public static string validateGender(bool genderCowo, bool genderCewe)
        {
            if (genderCowo == false && genderCewe == false)
            {
                return "Gender must be chosen!";
            }
            return null;
        }

        public static string validateAddress(string address)
        {
            if (String.IsNullOrWhiteSpace(address)) return "Address must be filled!";
            if (!address.Contains("Street")) return "Address must contain word 'Street'";
            return null;
        }

        public static string validateEmail(string email)
        {
            if (String.IsNullOrWhiteSpace(email)) return "Email must be filled!";
            if (!MemberHandler.UniqueEmail(email))
            {
                return "Email already exist";
            }
            if (email.Contains("@") && email.Contains(".") &&
               !email.StartsWith("@") && !email.EndsWith("@") &&
               !email.StartsWith(".") && !email.EndsWith(".") &&
               Math.Abs(email.IndexOf('@') - email.IndexOf('.')) != 1)
            {
                return null;
            }
            return "Email must using a correct format";
        }

        public static string validateEmailUpdate(string email)
        {
            if (String.IsNullOrWhiteSpace(email)) return "Email must be filled!";
            if (!MemberHandler.UniqueEmailUpdate(email))
            {
                return "Email already exist";
            }
            if (email.Contains("@") && email.Contains(".") &&
               !email.StartsWith("@") && !email.EndsWith("@") &&
               !email.StartsWith(".") && !email.EndsWith(".") &&
               Math.Abs(email.IndexOf('@') - email.IndexOf('.')) != 1)
            {
                return null;
            }
            return "Email must using a correct format";
        }

        public static string validatePassword(string password)
        {
            if (String.IsNullOrWhiteSpace(password)) return "Password must be filled!";
            if (password.Length < 3 || password.Length > 20) return "Password must be between 3 and 20 characters";
            return null;
        }

        public static string validateQuantity(string quantity)
        {
            if (quantity == "")
            {
                return "Quantity must be filled";
            }
            int tmpQuantity = int.Parse(quantity);
            if (tmpQuantity < 1 || tmpQuantity > 100) return "Quantity mus be between 1 to 100 inclusively";
            return null;
        }


        public static void delete(int id)
        {
            MemberHandler.delete(id);
        }
    }
}