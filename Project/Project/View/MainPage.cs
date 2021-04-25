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

namespace Project.View
{
    public partial class MainPage : Form,IMainPage
    {

        UserInfObject _userInfObject;

        int _minuteRange = 5;

        MainPagePresenter presenter;
        public MainPage(UserInfObject _userInfObject)
        {
            InitializeComponent();
            this.presenter = new MainPagePresenter(this);
            this._userInfObject = _userInfObject;

            presenter.loadSubjectsAsync();
            txtMinuteRange.Text = _minuteRange.ToString();

        }
        public UserInfObject userInfo {
            get { return _userInfObject; }
            set {

                _userInfObject = value;
                lblName.Text = _userInfObject.getName();

            }
        }

        public DataGridView subjectList {
            get { return dataGridView1; }
            set { dataGridView1 = value; }
        }
        public DataGridView eventList {
            get { return dataGridView2; }
            set { dataGridView2 = value; }
        }

        public int minuteRange {
            get { return _minuteRange; }
            set { _minuteRange = value; }
        }

        Label IMainPage.lblUpComingEvents {
            get { return this.lblUpComingEvent; }
            set { this.lblUpComingEvent = value; }
        }

        Label IMainPage.lblSubjectsEnrolled {
            get { return this.lblSubjectsEnrolled; }
            set { this.lblSubjectsEnrolled = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            presenter.showAddSubjects();
  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            presenter.showTaskScheduler();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            presenter.showStudyHelper();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _minuteRange = Int32.Parse(txtMinuteRange.Text.ToString());
        }
    }
}
