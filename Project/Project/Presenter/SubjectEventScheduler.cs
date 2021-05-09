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
        DataTable subjectList = new DataTable();

        DataTable studyProgress = new DataTable();


        public SubjectEventScheduler(ISubjectEventScheduler iSubjectEventScheduler) {
            this.iSubjectEventScheduler = iSubjectEventScheduler;
        }

        public void loadSubjects() {
        
            subjectList = model.LoadAllSubjects(iSubjectEventScheduler.userInfo.getId());
            iSubjectEventScheduler.cmbSubjectList.DataSource = subjectList;
            iSubjectEventScheduler.cmbSubjectList.DisplayMember = "study_name";
            iSubjectEventScheduler.cmbSubjectList.ValueMember = "study_id";
        }

        public void showAddEvent() {
            AddEvent aE = new AddEvent(iSubjectEventScheduler);
            aE.ShowDialog();

        }

        public void addEvent(DateTime selectedDate,string eventName, 
            int eventType,int numberOfDaysAccomplish ,int numberOfSessionsDay) {
            int selectedSubjectID =Int32.Parse(iSubjectEventScheduler.cmbSubjectList.SelectedValue.ToString());

            string strBuildDate = selectedDate.Date.Year.ToString() + "-" + selectedDate.Date.Month.ToString() +
                    "-" + selectedDate.Date.Day.ToString();
            DataTable response = model.AddEventToSubject(selectedSubjectID,
                strBuildDate,eventName, eventType , numberOfDaysAccomplish, numberOfSessionsDay);
            if (response.Rows.Count > 0)
            {
                MessageBox.Show("Success Adding Event");
            }       
        }

        public void loadStudyTime() {
          int selectedSubjectID = Int32.Parse(iSubjectEventScheduler.cmbSubjectList.SelectedValue.ToString());
          DataTable response = model.LoadSubjectStudyTime(selectedSubjectID);
          iSubjectEventScheduler.dtEventList = response;
          iSubjectEventScheduler.listEvents.DataSource = response;

            foreach (DataGridViewColumn dc in iSubjectEventScheduler.listEvents.Columns)
            {
                if (dc.Name.Contains("_")) {
                    dc.Visible = false;
                }
            }

        }

        public void submitScheduledTime(int studyDetailsId, DateTime selectedDate) {

            string strBuildDate = selectedDate.TimeOfDay.ToString();

            DataTable response = model.InsertStudyProgress(studyDetailsId, strBuildDate);

            if (response.Rows.Count > 0) {
                MessageBox.Show("Sucesss");
            }

        }


        public void loadScheduledTime(int studyDetailsId,DataGridView dtg) {

            studyProgress = model.GettStudyProgress(studyDetailsId);
            DataGridViewProgressColumn column = new DataGridViewProgressColumn();

            dtg.Rows.Clear();
            dtg.ColumnCount = 1;
            dtg.Columns[0].Name = "Subject Code";
            dtg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtg.Columns.Add(column);
            dtg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column.HeaderText = "Progress";

            foreach (DataRow dr in studyProgress.Rows) {

                DateTime date = Convert.ToDateTime(dr["Scheduled Time"].ToString());
                int percent = Convert.ToInt32(dr["study_percent"].ToString());
      
                object[] temp = new object[] { date.ToString("hh:mm tt"), percent };
                dtg.Rows.Add(temp);

            }

      


        }


        public void showStudyHelper(int index)
        {
            int progressId = Convert.ToInt32(studyProgress.Rows[index]["study_progress_id"].ToString());
            string name = studyProgress.Rows[index]["Study Name"].ToString();
            StudyHelper studyHelper = new StudyHelper(progressId, name);
            studyHelper.ShowDialog();
        }


        public void deleteScheduledStudy(DataRow dr)
        {
           int  selectedIndex = Convert.ToInt32(dr["study_details_id"].ToString());
            DataTable dt = model.DeleteScheduledEvent(selectedIndex);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Deleting Subject Success");

            }

        }

    }
}
