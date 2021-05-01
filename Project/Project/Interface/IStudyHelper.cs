using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Interface
{
    interface IStudyHelper
    {
        string studyScheduleName { get; set; }
        int studyProgressId { get; set; }
        int percent { get; set; }
    }
}
