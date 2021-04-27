

using Project.Interface;
using Project.Model;
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

            DataTable dt = model.UpdateScheduledStudy(iStudyHelper.studyScheduleId,
                iStudyHelper.percent);

            if (dt.Rows.Count > 0) {
                MessageBox.Show("Sucess");
            }
    

        }



    }
}
