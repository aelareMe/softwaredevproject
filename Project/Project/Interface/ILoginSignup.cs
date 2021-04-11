using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Interface
{
    interface ILoginSignup
    {
        String username { get; }
        String password { get; }

        Form currentForm { get; }
    }
}
