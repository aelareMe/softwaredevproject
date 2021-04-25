using Project.Interface;
using Project.Model;
using Project.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Presenter
{
    class SubjectEventScheduler
    {

        ISubjectEventScheduler iSubjectEventScheduler;
        SubjectEventSchedulerModel model = new SubjectEventSchedulerModel();
  
        public SubjectEventScheduler(ISubjectEventScheduler iSubjectEventScheduler) {
            this.iSubjectEventScheduler = iSubjectEventScheduler;
        }

        public void loadSubjects() {
        
            DataTable subjectList = model.LoadAllSubjects(iSubjectEventScheduler.userInfo.getId());
            iSubjectEventScheduler.cmbSubjectList.DataSource = subjectList;
            iSubjectEventScheduler.cmbSubjectList.DisplayMember = "study_name";
            iSubjectEventScheduler.cmbSubjectList.ValueMember = "study_id";
        }

        public void showAddEvent() {
            AddEvent aE = new AddEvent(iSubjectEventScheduler);
            aE.ShowDialog();

        }

        public void addEvent(DateTime selectedDate,string eventName,int eventType) {
            int selectedSubjectID =Int32.Parse(iSubjectEventScheduler.cmbSubjectList.SelectedValue.ToString());

            string strBuildDate = selectedDate.Date.Year.ToString() + "-" + selectedDate.Date.Month.ToString() +
                "-" + selectedDate.Date.Day.ToString() + " " + selectedDate.TimeOfDay.ToString();
            DataTable response = model.AddEventToSubject(selectedSubjectID, strBuildDate,eventName, eventType);
            if (response.Rows.Count > 0)
            {
                MessageBox.Show("Success Adding Event");
            }       
        }

        public void loadStudyTime() {
          int selectedSubjectID = Int32.Parse(iSubjectEventScheduler.cmbSubjectList.SelectedValue.ToString());
          DataTable response = model.LoadSubjectStudyTime(selectedSubjectID);
          iSubjectEventScheduler.listEvents.DataSource = response;

        }

 
    }
}
