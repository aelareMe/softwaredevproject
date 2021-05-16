using Project.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Interface
{
    interface ISettings
    {

        MainPage mainPageForm { get; }

        int id { get; }
        string name { get; }
        string userName { get; }
        string password { get;  }

    }
}
