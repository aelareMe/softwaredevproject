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
        String name = "";
        public UserInfObject(String username, String password,String name) {
            this.username = username;
            this.password = password;
            this.name = name;
        }


        public String getName() {
            return name;
        }
    }
}
