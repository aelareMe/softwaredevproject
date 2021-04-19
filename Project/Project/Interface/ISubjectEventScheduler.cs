using Project.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Interface
{
    public interface ISubjectEventScheduler
    {

        ComboBox cmbSubjectList { get; set; }
        UserInfObject userInfo { get; set; }
        DataGridView listEvents { get; set; }
    }
}
