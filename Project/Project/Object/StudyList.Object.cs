using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Object
{
    class StudyList
    {
        int studyId = 0;
        string studyName = "";
        string studyNotes = "";
        int studyCount = 0;
        int studyLimit = 0;
        int studyPercentage = 0;
        int userId = 0;

        public StudyList(int studyId, string studyName, int studyCount, 
            int studyLimit, int studyPercentage, int userId) {

            this.studyId = studyId;
            this.studyName = studyName;
            this.studyCount = studyCount;
            this.studyLimit = studyLimit;
            this.studyPercentage = studyPercentage;
            this.studyId = studyId;
        }

    }
}
