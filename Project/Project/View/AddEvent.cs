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
  
        public AddEvent(ISubjectEventScheduler iSubjectEventScheduler)
        {
            this.iSubjectEventScheduler = iSubjectEventScheduler;
            presenter = new SubjectEventScheduler(iSubjectEventScheduler);
            InitializeComponent();
            eventDate.Format = DateTimePickerFormat.Custom;
            eventDate.CustomFormat = "MM/dd/yyyy hh:mm tt";
       
    
            cmbSubjectList.DataSource = EventType.getTypes();
            cmbSubjectList.DisplayMember = "typeName";
            cmbSubjectList.ValueMember = "typeId";
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
            presenter.addEvent(eventDate.Value, eventName.Text.ToString(), selectedValueMember);
           
            
        }

    }
}
