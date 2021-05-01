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


        public void updateSubject(int selectedItem,string subjectCode,string newDescription) {
            int studyId = Convert.ToInt32(dtSubject.Rows[selectedItem - 1]["study_id"].ToString());
            DataTable reponse = model.UpdateSubject(subjectCode,
              newDescription, userInfo.getId());
            if (reponse.Rows.Count > 0)
            {
                MessageBox.Show("Editing Subject Success");

            }

        }

    }
}
