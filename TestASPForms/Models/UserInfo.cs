using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestASPForms.Models
{
    public class UserInfo
    {
        private string firstname;
        private string lastname;
        private string email;
        private string phonenumber;
        private string phonetype;
        private string password;

        public string FirstName
        {
            set { firstname = value; }
            get { return firstname; }
        }

        public string LastName
        {
            set { lastname = value; }
            get { return lastname; }
        }

        public string Email
        {
            set { email = value; }
            get { return email; }
        }

        public string PhoneNumber
        {
            set { phonenumber = value; }
            get { return phonenumber; }
        }

        public string PhoneType
        {
            set { phonetype = value; }
            get { return phonetype; }
        }

        public string Password
        {
            set { password = value; }
            get { return password; }
        }
        public UserInfo()
        {
            FirstName = "";
            LastName = "";
            Email = "";
            PhoneNumber = "";
            PhoneType = "";
            Password = "";
        }

        public UserInfo(string frstnm, string lstnme, string eml, string phnenum, string phnetyp, string pswrd)
        {
            FirstName = frstnm;
            LastName = lstnme;
            Email = eml;
            PhoneNumber = phnenum;
            PhoneType = phnetyp;
            Password = pswrd;
        }
    }
}