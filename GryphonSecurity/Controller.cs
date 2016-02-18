using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GryphonSecurity
{
    class Controller
    {
        private DBFacade dbFacade;
        
        private static Controller instance;
        private Controller()
        {
            dbFacade = new DBFacade();
        }
        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller();
                }
                return instance;
            }
        }
        public void login(String userName, String password)
        {
            dbFacade.login(userName, password);
        }
    }
}
