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

        DataTable perEventPercentage = new DataTable();

        public MainPagePresenter(IMainPage iMainPage)  {
            this.iMainPage = iMainPage;

            iMainPage.eventList.ColumnCount =2;
            iMainPage.eventList.ColumnCount = 2;
            iMainPage.eventList.Columns[0].Name = "Activty Name";
            iMainPage.eventList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            iMainPage.eventList.Columns[1].Name = "Count";
            iMainPage.eventList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            iMainPage.eventList.Columns.Add(column);
            iMainPage.eventList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column.HeaderText = "Progress";


        }

        public void showAddSubjects() {
            Add_Subject open_add_subject = new Add_Subject(iMainPage.userInfo);
            open_add_subject.Show();
        }

        public UserInfObject getUserObj() {
            return iMainPage.userInfo;
        }


        public void showTaskScheduler() {
            ActSched scheduler = new ActSched(iMainPage.userInfo);
            scheduler.Show();
        }


        public async void loadSubjectsAsync()
        {
            Task[] task1 = { asyncUpcommingvents(),
                            asyncLoadAllMainPageSubjects(),
                            getAllPercentage()
                           };

              Task[] task2 = { asyncScheduledWithinTimeFrame() };

            await Task.WhenAll(task1);
            await Task.WhenAll(task2);
    }


        public async Task asyncScheduledWithinTimeFrame()
        {
            while (true)
            {
                DataTable scheduledEvents =
                    subjModel.GetScheduledStudy(iMainPage.userInfo.getId(), "5");
               
                foreach(DataRow dr in scheduledEvents.Rows) {


                    int studyScheduleId = Convert.ToInt32( dr["_StudyDetails"].ToString());
                    string studyScheduleName = dr["Description"].ToString();
                    StudyHelper studyHelper = new StudyHelper(studyScheduleId, studyScheduleName);
                    studyHelper.Show();
                }

                int delay = iMainPage.minuteNotifyEvery * 60000;
                await Task.Delay(delay);
            }
        }

        public  async Task asyncUpcommingvents()
        {
            while (true)
            {
                DataTable scheduledEvents = 
                    subjModel.GetScheduledStudy(iMainPage.userInfo.getId(), iMainPage.minuteRange.ToString());
                iMainPage.lblUpComingEvents.Text = scheduledEvents.Rows.Count.ToString();


                await Task.Delay(1000);
            }
        }

        public async Task asyncLoadAllMainPageSubjects()
        {
            while (true)
            {

                DataTable subjectList = subjModel.LoadAllMainPageSubjects(iMainPage.userInfo.getId());

                iMainPage.lblSubjectsEnrolled.Text = subjectList.Rows.Count.ToString();

                iMainPage.subjectList.DataSource = subjectList;

                await Task.Delay(1000);
            }
        }

        public async Task getAllPercentage() {
            while (true)
            {
                DataTable allScheduledStudy = subjModel.GetAllPercentage(iMainPage.userInfo.getId());
                List<EventType> eventTypes = EventType.getTypes();
                int ctr = 0;

                foreach (DataRow dr in allScheduledStudy.Rows)
                {

                    int ctrFast = ctr + 1;
                    foreach (EventType eType in eventTypes)
                    {

                        int type = Int32.Parse(dr["type"].ToString());
                        int percent = Int32.Parse(dr["study_percent"].ToString());
                        if (eType.typeId == type)
                        {
                            eType.ctr += 1;
                            eType.percentDenominator += 1;
                            eType.percent += percent;
                        }
                    }
                }
                iMainPage.eventList.Rows.Clear();
                foreach (EventType types in eventTypes)
                {

                    if (types.percent > 0.0)
                    {
                        types.percent = ((types.percent / (100 * types.percentDenominator)) * 100);

                        object[] row1 = new object[] { types.typeName.ToString(),
                     types.percentDenominator.ToString(),
                    Convert.ToInt32(types.percent) };
                        iMainPage.eventList.Rows.Add(row1);
                    }
                    else
                    {
                        object[] row1 = new object[] { types.typeName.ToString(),
                     types.percentDenominator.ToString(),
                    0 };
                        iMainPage.eventList.Rows.Add(row1);
                    }


                }
                //  iMainPage.eventList.DataSource = perEventPercentage;
                await Task.Delay(1000);
            }

        }



    }
}
