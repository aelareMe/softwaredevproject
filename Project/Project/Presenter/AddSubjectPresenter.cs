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

        SubjectEventSchedulerModel modelSubjects = new SubjectEventSchedulerModel();
        public AddSubjectPresenter(IAddSubject iAddSubject, UserInfObject userInfo) {
            this.iAddSubject = iAddSubject;
            this.userInfo = userInfo;
        }   

        public  void AddSubject() {

            DataTable reponse = model.AddSubject(iAddSubject.subjectCode,
                iAddSubject.subjectDescription, userInfo.getId());
            if (reponse.Rows.Count > 0) {
                MessageBox.Show("Adding Subject Success");
           
            }
        }


        public DataTable loadSubjects()
        {
           return modelSubjects.LoadAllSubjects(userInfo.getId());
        }

    }
}
