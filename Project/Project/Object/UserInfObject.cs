using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Object
{
    public class UserInfObject
    {
        private String username = "";
        private String password = "";
        private String name = "";
        private int id ;
        private bool isLoggedIn = false;
        public UserInfObject(bool isLoggedIn = false,
            String username = "", String password = "",
            String name = "", int id = 0) {
            this.username = username;
            this.password = password;
            this.name = name;
            this.id = id;
            this.isLoggedIn = isLoggedIn;
        }

        public String getPassword()
        {
            return password;
        }
        public String getUsername()
        {
            return username;
        }
        public String getName() {
            return name;
        }

        public int getId() {
            return id;
        }
    }
}
