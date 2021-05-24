using Project.Interface;
using Project.Object;
using Project.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AddEvent : Form
    {
        public Event e1;
        public bool confirm_flag;
        SubjectEventScheduler presenter;
        ISubjectEventScheduler iSubjectEventScheduler;

        bool isEditClicked = false;
        int _studyDetailsID = 0;
  
        public AddEvent(ISubjectEventScheduler iSubjectEventScheduler)
        {
            this.iSubjectEventScheduler = iSubjectEventScheduler;
            presenter = new SubjectEventScheduler(iSubjectEventScheduler);
            InitializeComponent();
            setUpCmbDtp();
            printTimeSpan();
            btnEnableEdit.Visible = false;
        }


        public AddEvent(ISubjectEventScheduler iSubjectEventScheduler, DataRow dr) {

            this.iSubjectEventScheduler = iSubjectEventScheduler;
            presenter = new SubjectEventScheduler(iSubjectEventScheduler);
            InitializeComponent();
            setUpCmbDtp();
            if (!this.iSubjectEventScheduler.isAddEventMode)
            {
                btnEnableEdit.Visible = true;
                cmbSubjectList.SelectedValue = Convert.ToInt32(dr["_type"].ToString());
                eventName.Text = dr["Description"].ToString();
                label1.Text = "EDIT EVENT";
                days2Accomplish.Text = dr["Remaining Day/s"].ToString();
                noOfSession.Text = dr["No of Days To Accomplish"].ToString();
                eventDate.Value = DateTime.Parse(dr["Scheduled Date"].ToString());
                _studyDetailsID = Int32.Parse(dr["study_details_id"].ToString());
                isItemsDisable();
            }
        }

        public void setUpCmbDtp() {
            eventDate.Format = DateTimePickerFormat.Custom;
            eventDate.CustomFormat = "MM/dd/yyyy";
            cmbSubjectList.DataSource = EventType.getTypes();
            cmbSubjectList.DisplayMember = "typeName";
            cmbSubjectList.ValueMember = "typeId";
        }


        public void isItemsDisable() {

            cmbSubjectList.Enabled = isEditClicked;
            eventName.Enabled = isEditClicked;
            days2Accomplish.Enabled = isEditClicked;
            noOfSession.Enabled = isEditClicked;
            eventDate.Enabled = isEditClicked;
        }

        private void button2_Click(object sender, EventArgs e) //exit button
        {
            AddEvent.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e) //add event button
        {
            if (eventName.Text == "" || (eventDate.Value - DateTime.Today).TotalDays < 0) //if blank ang event name or ang date nga giset kay humana with respect sa date today
            {
                MessageBox.Show("Blank event name or event date can't be due past with today. Please try again.");
                return;
            }
            else
            {
                e1 = new Event(eventName.Text, eventDate.Value, Int32.Parse(days2Accomplish.Text), Int32.Parse(noOfSession.Text));
                confirm_flag = true;
                MessageBox.Show("Success");
                return;
            }


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            presenter.loadStudyTime();
            this.Close();
        }

        private void addEventConfirm_Click(object sender, EventArgs e)
        {
       
            int selectedValueMember =Int32.Parse( cmbSubjectList.SelectedValue.ToString());
            int numberOfDaysAccomplish = Int32.Parse(days2Accomplish.Text.ToString());
            int numberOfSessionsDay = Int32.Parse(noOfSession.Text.ToString());

            if (iSubjectEventScheduler.isAddEventMode)
            {
                presenter.addEvent(eventDate.Value, eventName.Text.ToString(),
                    selectedValueMember, numberOfDaysAccomplish, numberOfSessionsDay);
            }
            else {
                presenter.updateEvent(eventDate.Value, eventName.Text.ToString(),
                   selectedValueMember, numberOfDaysAccomplish, 
                   numberOfSessionsDay, _studyDetailsID);
            }
           
            
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            presenter.loadStudyTime();
            this.Close();
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEnableEdit_Click(object sender, EventArgs e)
        {
            isEditClicked = !isEditClicked;
            isItemsDisable();
        }

        private void eventDate_ValueChanged(object sender, EventArgs e)
        {
            printTimeSpan() ;
        }

        private void printTimeSpan() {
            TimeSpan temp = eventDate.Value.Date.Subtract(DateTime.Now);
            int result = Convert.ToInt32(Math.Round(temp.TotalDays));
            if (result <= 0)
            {
                result = 0;
            }
            days2Accomplish.Text = result.ToString();
        }
    }
}
