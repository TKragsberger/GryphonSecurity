using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GryphonSecurity
{
    class User
    {
        private String name;
        private String lastname;
        private String adresse;
        private long phoneNumber;
        public String toString()
        {
            return name + lastname + adresse + phoneNumber;
    }
    }

    
}
