using GryphonSecurity.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GryphonSecurity
{
    class DBFacade
    {
        DummyDB dummyDB = new DummyDB();


        public void login(String userName, String password)
        {

        }

        public Boolean createUser(User user)
        {
            return dummyDB.createUser(user);
        }

        public User getUser()
        {
            return dummyDB.getUser();
        }

    }
}
