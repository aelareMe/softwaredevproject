using Project.Interface;
using Project.Presenter;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project.View
{
    public partial class ScheduleTime : Form
    {
  
        SubjectEventScheduler presenter;
        DataRow dr;
        ISubjectEventScheduler iSubjectEventScheduler;
        DataTable eventList = new DataTable();
        int selectedID = 0;
        public ScheduleTime(ISubjectEventScheduler iSubjectEventScheduler, DataRow dr)
        {
            presenter = new SubjectEventScheduler(iSubjectEventScheduler);
            InitializeComponent();
            loadItems(dr);
        }

            private void loadItems(DataRow dr) {
            this.dr = dr;

            lblEventName.Text = dr["Description"].ToString();
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.ShowUpDown = true;

            selectedID = Convert.ToInt32(dr["study_details_id"].ToString());

            presenter.loadScheduledTime(selectedID, dataGridView1);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            int selectedID = Convert.ToInt32(dr["study_details_id"].ToString());
            presenter.submitScheduledTime(selectedID,dateTimePicker1.Value);
            presenter.loadScheduledTime(selectedID, dataGridView1);
            numSched.Text = "Schedules:" + dataGridView1.RowCount.ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            presenter.showStudyHelper(dataGridView1.SelectedRows[0].Index);
            loadItems(dr);
        }

        private void ScheduleTime_Load(object sender, EventArgs e)
        {
            numSched.Text = "Schedules:" + dataGridView1.RowCount.ToString();
        }
    }
}
