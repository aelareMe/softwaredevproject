using Project.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Interface
{
    interface IMainPage
    {
        UserInfObject userInfo { get; set; }

        DataGridView subjectList { get; set; }

        DataGridView eventList { get; set; }

        Label lblUpComingEvents { get; set; }

        Label lblSubjectsEnrolled { get; set; }

    }
}
