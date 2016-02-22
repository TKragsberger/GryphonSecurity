using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GryphonSecurity
{
    class User
    {
        private long id;
        private String firstname;
        private String lastname;
        private String address;
        private long phonenumber;

        public User(String firstname, String lastname, String address, long phonenumber)
        {
            id = 1;
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address;
            this.phonenumber = phonenumber;
        }

        public long Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }

            set
            {
                firstname = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }

            set
            {
                lastname = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public long Phonenumber
        {
            get
            {
                return phonenumber;
            }

            set
            {
                phonenumber = value;
            }
        }

        public String toString()
        {
            return firstname + lastname + address + phonenumber;
        }
    }

    
}
