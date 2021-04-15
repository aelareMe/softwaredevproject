using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Interface
{
    interface ISignup
    {
        String username { get; }
        String password { get; }
        String name { get; }
        Form currentForm { get; }
    }
}
