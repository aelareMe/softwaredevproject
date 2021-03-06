using Project.Interface;
using Project.Model;
using Project.Object;
using Project.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Presenter
{
    class MainPagePresenter
    {

        IMainPage iMainPage;

        SubjectEventSchedulerModel subjModel = new SubjectEventSchedulerModel();

        DataGridViewProgressColumn column = new DataGridViewProgressColumn();

        DataTable scheduledEvents = new DataTable();

        DataTable perEventPercentage = new DataTable();

        public MainPagePresenter(IMainPage iMainPage)  {
            this.iMainPage = iMainPage;

            iMainPage.eventList.ColumnCount = 3;
            iMainPage.eventList.Columns[0].Name = "Subject Code";
            iMainPage.eventList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            iMainPage.eventList.Columns[1].Name = "Study Name";
            iMainPage.eventList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            iMainPage.eventList.Columns[2].Name = "Type";
            iMainPage.eventList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            iMainPage.eventList.Columns.Add(column);
            iMainPage.eventList.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column.HeaderText = "Progress";
            
        }

        public void showAddSubjects() {
            //Subject_Oversight open_add_subject = new Subject_Oversight(iMainPage.userInfo);
            //open_add_subject.Show();
        }

        public UserInfObject getUserObj() {
            return iMainPage.userInfo;
        }


        public void ShowScheduleTime() {
            ActSched scheduler = new ActSched(iMainPage.userInfo);
            scheduler.Show();
        }


        public async void loadSubjectsAsync()
        {
            Task[] task1 = {  asyncLoadAllMainPageSubjects()
                           };

           Task[] task2 = { asyncScheduledWithinTimeFrame() };


            Task[] task3 = { getAllPercentage() };
       
            await Task.WhenAll(task1);
            await Task.WhenAll(task2);
            await Task.WhenAll(task3);

        }


        public async Task asyncScheduledWithinTimeFrame()
        {
            while (true)
            {
                 DataTable dt =
                    subjModel.GetScheduledStudy(iMainPage.userInfo.getId(), "5");
               
                foreach(DataRow dr in dt.Rows) {


                    int studyScheduleId = Convert.ToInt32( dr["_StudyDetails"].ToString());
                    string studyScheduleName = dr["Description"].ToString();
                    string studyTime = dr["Study Time"].ToString();
                    string subjectCode = dr["Subject Code"].ToString();

                    string strTitleBuild = "Subject Code: " + subjectCode;

                   
                    string[] subs = studyTime.Split(':');
                    int temp = Convert.ToInt32(subs[0]);
                    string amPM = "AM";
                    string notifString = "";
                    if (temp > 12)
                    {
                        amPM = "PM";
                        temp -= 12;
                    }
                    notifString = temp.ToString() + ":" + subs[1] + " " + amPM;
                       iMainPage.notifyIcon.
                           ShowBalloonTip(1000, strTitleBuild,
                           " Time to study at " + notifString + " Please Adhere", ToolTipIcon.Info);

                    if (iMainPage.mainpageForm.WindowState == FormWindowState.Minimized) {
                        iMainPage.mainpageForm.Hide();
                    }   

                }
                int delay = iMainPage.minuteNotifyEvery * 60000;
                await Task.Delay(delay);
            }
        }


        public void scheduledSubjectToday()
        {
           
                DataTable dt =
                   subjModel.GetDateStudy(iMainPage.userInfo.getId());

                foreach (DataRow dr in dt.Rows)
                {

                    string studyScheduleDate = dr["Scheduled Date"].ToString();
                    string studyTime = dr["Study Time"].ToString();
                    DateTime parseData = DateTime.Parse(studyScheduleDate);
                    DateTime parseStudyTime = DateTime.Parse(studyTime);

                    TimeSpan temp = parseData.Subtract(DateTime.Now);

                    TimeSpan tem2= parseStudyTime.Subtract(DateTime.Now);
                    int result = Convert.ToInt32(Math.Round(temp.TotalDays));
                    int result2 = Math.Abs( Convert.ToInt32(Math.Round(Convert.ToDouble(temp.Hours))));
                    if (result == 0 && result2>0)
                    {
                        string subjectCode = dr["Subject Name"].ToString();

                        string strTitleBuild = "Subject Code: " + subjectCode;

                        iMainPage.notifyIcon.
                            ShowBalloonTip(1000, strTitleBuild,
                            "Heads Up! today you have a scheduled study session for " + strTitleBuild + " ", ToolTipIcon.Info);

                        if (iMainPage.mainpageForm.WindowState == FormWindowState.Minimized)
                        {
                            iMainPage.mainpageForm.Hide();
                        }

                    }

                }
            
        }
      

        public  async Task asyncUpcommingvents()
        {
            while (true)
            {
                DataTable scheduledEvents = 
                subjModel.GetScheduledStudy(iMainPage.userInfo.getId(), iMainPage.minuteRange.ToString());

                await Task.Delay(60000);
            }
        }

        public async Task asyncLoadAllMainPageSubjects()
        {
            while (true)
            {

                DataTable subjectList = subjModel.LoadAllMainPageSubjects(iMainPage.userInfo.getId());

                iMainPage.lblSubjectsEnrolled.Text = subjectList.Rows.Count.ToString();
                iMainPage.subjectList.DataSource = subjectList;
                //MessageBox.Show(subjectList.Rows[0].ItemArray[0].ToString());
                await Task.Delay(1000);
            }
        }

        public async Task getAllPercentage() {
            while (true)
            {
                scheduledEvents = subjModel.GetPercentsPerType(iMainPage.userInfo.getId());

                List<EventType> eventTypes = EventType.getTypes();
                iMainPage.eventList.Rows.Clear();
                foreach (DataRow dr in scheduledEvents.Rows)
                {

                    string subjCode = dr["Subject Code"].ToString();
                    string studyName = dr["Description"].ToString();
                    int totalPercent = Convert.ToInt32(dr["Total Percent"].ToString());
                    int studyDetailsId = Convert.ToInt32(dr["study_details_id"].ToString());

                    double denominator = Convert.ToDouble(subjModel.GetCountStudyDetailsID(studyDetailsId).Rows[0]["ctr"]);

                   // Convert.ToInt32(subjModel.GetCountStudyDetailsID. [0]["ctr"].ToString());

                    int type = Convert.ToInt32(dr["_type"].ToString());

                    string strType = "Exam";
                    if (type == 1) {
                        strType = "Exam";
                    } else if (type == 2) {
                        strType = "Quiz";
                    } else {
                        strType = "Assignment";
                    }

                   double value = Convert.ToDouble((Convert.ToDouble(totalPercent) / denominator).ToString());
                    object[] row1 = new object[] { subjCode.ToString(),
                     studyName,strType,Convert.ToInt32( value) };
                    iMainPage.eventList.Rows.Add(row1);

                }
        
                //  iMainPage.eventList.DataSource = perEventPercentage;
                await Task.Delay(10000);
            }

        }


        public void ShowAllProgress(int selectedIndex) {
            DataRow dr = scheduledEvents.Rows[selectedIndex];

            ActSched scheduler = new ActSched(iMainPage.userInfo);
            ScheduleTime form = new ScheduleTime(scheduler,dr);
            form.Show();
        }

    }
}
