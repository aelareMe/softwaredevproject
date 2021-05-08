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


        int _minuteRange =1;
        int _minuteNotifyEvery = 1;

        MainPagePresenter presenter;

        public MainPage(UserInfObject _userInfObject)
        {
            InitializeComponent();
            this.presenter = new MainPagePresenter(this);
            this._userInfObject = _userInfObject;

            presenter.loadSubjectsAsync();
            txtMinuteRange.Text = _minuteRange.ToString();
            textBox1.Text = _minuteNotifyEvery.ToString();
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

        public int minuteNotifyEvery {
            get { return _minuteNotifyEvery; }
            set { _minuteNotifyEvery = value; }
        }

        public NotifyIcon notifyIcon {
            get { return notifyIcon1; }
            set { notifyIcon1 = value; }
        }
        public Form mainpageForm {
            get { return this; }
        }

        Label IMainPage.lblUpComingEvents {
            get { return this.lblUpComingEvent; }
            set { this.lblUpComingEvent = value; }
        }

        Label IMainPage.lblSubjectsEnrolled {
            get { return this.lblSubjectsEnrolled; }
            set { this.lblSubjectsEnrolled = value; }
        }

        public ContextMenuStrip contextMenu {
            get { return this.contextMenuStrip1; }
            set { this.contextMenuStrip1 = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            presenter.showAddSubjects();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //presenter.ShowScheduleTime();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _minuteRange = Int32.Parse(txtMinuteRange.Text.ToString());
        }


        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

       

        private void dataGridView2_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            presenter.ShowAllProgress(e.RowIndex);

        }
    }
}
