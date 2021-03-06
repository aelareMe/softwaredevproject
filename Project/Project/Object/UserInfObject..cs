using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Object
{
    class UserInfObject
    {
        private String username = "";
        private String password = "";
        private String name = "";
        private int id ;
        private bool isLoggedIn = false;
        public UserInfObject(String username, String password,
            String name, int id = 0,bool isLoggedIn = false) {
            this.username = username;
            this.password = password;
            this.name = name;
            this.id = id;
            this.isLoggedIn = isLoggedIn;
        }

        public String getName() {
            return name;
        }

        public int getId() {
            return id;
        }
    }
}
