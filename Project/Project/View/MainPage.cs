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

        public MainPage MainPage1
        {
            get { return this;}
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
            get { return notifyIcon2; }
            set { notifyIcon2 = value; }
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
            presenter.ShowScheduleTime();
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

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            _minuteNotifyEvery = Int32.Parse(textBox1.Text.ToString());

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (eventList.Rows.Count > 0)
            {

                presenter.ShowAllProgress(eventList.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Nothing to Show");
            }
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            currentPanel.Show();
            currentPanel.BringToFront();
            currentPanel.Controls.Add(childForm);
            currentPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void edit_subject_btn_Click(object sender, EventArgs e)
        {
            Adding_Subject Adding_Subject = new Adding_Subject(_userInfObject);
            openChildForm(Adding_Subject);
            edit_subject_btn.BackColor = Color.FromArgb(15, 39, 63);
            Schedule_btn.BackColor = Color.FromArgb(11, 17, 31);
            addAcitivty_btn.BackColor = Color.FromArgb(11, 17, 31);
            Setting_btn.BackColor = Color.FromArgb(11, 17, 31);
        }

        private void addAcitivty_btn_Click(object sender, EventArgs e)
        {
            ActSched ActSched = new ActSched(_userInfObject);
            openChildForm(ActSched);
            edit_subject_btn.BackColor = Color.FromArgb(11, 17, 31);
            Schedule_btn.BackColor = Color.FromArgb(11, 17, 31);
            addAcitivty_btn.BackColor = Color.FromArgb(15, 39, 63);
            Setting_btn.BackColor = Color.FromArgb(11, 17, 31);
        }

        private void Schedule_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void minmize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void clse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            currentPanel.Hide();
            currentPanel.SendToBack();
        }

        private void Setting_btn_Click(object sender, EventArgs e)
        {
            Setting Setting = new Setting(userInfo,this);
            openChildForm(Setting);
            Setting_btn.BackColor = Color.FromArgb(15, 39, 63);
            edit_subject_btn.BackColor = Color.FromArgb(11, 17, 31);
            Schedule_btn.BackColor = Color.FromArgb(11, 17, 31);
            addAcitivty_btn.BackColor = Color.FromArgb(11, 17, 31);

   
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            Help Help = new Help();
            openChildForm(Help);
            help_btn.BackColor = Color.FromArgb(15, 39, 63);
            Setting_btn.BackColor = Color.FromArgb(11, 17, 31);
            edit_subject_btn.BackColor = Color.FromArgb(11, 17, 31);
            Schedule_btn.BackColor = Color.FromArgb(11, 17, 31);
            addAcitivty_btn.BackColor = Color.FromArgb(11, 17, 31);
        }
    }
}
