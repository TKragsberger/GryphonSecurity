using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GryphonSecurity.DataSource
{
    class DummyDB
    {
        private static IsolatedStorageSettings appSettings = IsolatedStorageSettings.ApplicationSettings;
        private Boolean dummyDBStatus = false;
        private String KEY_FIRSTNAME = "FIRSTNAME";
        private String KEY_LASTNAME = "LASTNAME";
        private String KEY_ADDRESS = "ADDRESS";
        private String KEy_PHONENUMBER = "PHONENUMBER";
        public Boolean createUser(User user)
        {
            try
            {
                Debug.WriteLine("" + user.toString());
                appSettings.Add(KEY_FIRSTNAME, user.Firstname);
                appSettings.Add(KEY_LASTNAME, user.Lastname);
                appSettings.Add(KEY_ADDRESS, user.Address);
                appSettings.Add(KEy_PHONENUMBER, user.Phonenumber);
                appSettings.Save();
                dummyDBStatus = true;

            }
            catch (IsolatedStorageException)
            {
                dummyDBStatus = false;
                Debug.WriteLine("you are here");
            }
            return dummyDBStatus;
        }
    }
}
