

using Project.Interface;
using Project.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project.Presenter
{
    class StudyHelperPresenter
    {
        IStudyHelper iStudyHelper;

        StudyHelperModel model = new StudyHelperModel();
        public StudyHelperPresenter(IStudyHelper iStudyHelper) {
            this.iStudyHelper = iStudyHelper;
        }


        public void updateScheduledEvent() {

            DataTable dt = model.UpdateStudyProgress(iStudyHelper.studyProgressId,
                iStudyHelper.percent);

            if (dt.Rows.Count > 0) {
                MessageBox.Show("Sucess");
            }
    

        }

        public int loadCurrentProgress() {

            DataTable dt = model.LoadCurrentProgress(iStudyHelper.studyProgressId);

            if (dt.Rows.Count > 0)
            {
       
                return Convert.ToInt32(dt.Rows[0]["study_percent"].ToString());
            }
            else {
                return 0;
            }

        }

    }
}
