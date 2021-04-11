using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Object
{
    class StudyDetailsPerItem
    {

        int studyDetailsId = 0;
        int studyId = 0;
        int studyPercent = 0;
        string studyNotes = "";


       public StudyDetailsPerItem(int studyDetailsId, int studyId ,
          int studyPercent, string studyNotes) {

            this.studyDetailsId = studyDetailsId;
            this.studyId = studyId;
            this.studyPercent = studyPercent;
            this.studyNotes = studyNotes;
        }
    }
}
