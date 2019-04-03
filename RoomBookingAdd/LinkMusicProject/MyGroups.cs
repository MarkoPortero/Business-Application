using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkMusicProject
{
    //TO DO
    //ADD VALIDATION TO THIS CLASS
    //CREATE CUSTOM VALIDATION
    class MyGroups
    {
        private string GroupName, ContactForename, ContactSurname, Telephone, Email;

        public MyGroups()
        {

            this.GroupName = "";
            this.ContactForename = "";
            this.ContactSurname = "";
            this.Telephone = "";
            this.Email = "";
        }

        public MyGroups( string GroupName, string ContactForename, string
            ContactSurname, string Telephone, string Email)
        {

            this.GroupName = GroupName;
            this.ContactForename = ContactForename;
            this.ContactSurname = ContactSurname;
            this.Telephone = Telephone;
            this.Email = Email;
        }


        public string groupName
        {
            get { return GroupName; }
            set { GroupName = value;}
        }

        public string contactForename
        {
            get { return ContactForename; }
            set { ContactForename = value; }
        }
        public string contactSurname
        {
            get { return ContactSurname; }
            set { ContactSurname = value; }
        }

        public string telephone
        {
            get { return Telephone; }
            set { Telephone = value; }
        }

        public string email
        {
            get { return Email; }
            set { Email = value; }
        }


    }
}
