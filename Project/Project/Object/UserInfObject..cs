using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Object
{
    class UserInfObject
    {
        String username = "";
        String password = "";
        public UserInfObject(String username, String password) {
            this.username = username;
            this.password = password;
        }


        public String getUserName() {
            return username;
        }
    }
}
