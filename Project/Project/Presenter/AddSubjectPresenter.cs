using Project.Interface;
using Project.Model;
using Project.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Presenter
{
    class AddSubjectPresenter
    {
        IAddSubject iAddSubject;
        UserInfObject userInfo;
        AddSubjectModel model = new AddSubjectModel();
        DataTable dtSubject = new DataTable();

        SubjectEventSchedulerModel modelSubjects = new SubjectEventSchedulerModel();
        public AddSubjectPresenter(IAddSubject iAddSubject, UserInfObject userInfo) {
            this.iAddSubject = iAddSubject;
            this.userInfo = userInfo;
        }   

        public void AddSubject() {

            DataTable reponse = model.AddSubject(iAddSubject.subjectCode,
                iAddSubject.subjectDescription, userInfo.getId());
            if (reponse.Rows.Count > 0) {
                MessageBox.Show("Adding Subject Success");
           
            }
        }


        public DataTable loadSubjects()  {
            dtSubject =  modelSubjects.LoadAllSubjects(userInfo.getId());

            return dtSubject;
        }


        public void updateSubject() {
            int studyId = Convert.ToInt32(dtSubject.Rows[iAddSubject.selectedIndex - 1]["study_id"].ToString());
            DataTable reponse = model.UpdateSubject(iAddSubject.subjectCode,
              iAddSubject.subjectDescription, studyId);
            if (reponse.Rows.Count > 0)
            {
                MessageBox.Show("Updating Subject Success");

            }

        }

        public void deleteSubject() {
  
            int studyId = Convert.ToInt32(dtSubject.Rows[iAddSubject.selectedIndex - 1]["study_id"].ToString());
            DataTable reponse = model.DeleteSubject(studyId);
            if (reponse.Rows.Count > 0)
            {
                MessageBox.Show("Deleting Subject Success");

            }
        }

    }
}
