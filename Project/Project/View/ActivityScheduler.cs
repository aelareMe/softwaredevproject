using Project.Interface;
using Project.Object;
using Project.Presenter;
using Project.View;
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

    public partial class ActSched : Form, ISubjectEventScheduler
    {

        UserInfObject _userInfObject;
        SubjectEventScheduler presenter;
        DataTable _dtEventList = new DataTable();
    
        public ActSched(UserInfObject _userInfObject)
        {
            this._userInfObject = _userInfObject;
            presenter = new SubjectEventScheduler(this);
            InitializeComponent();
            presenter.loadSubjects();
        }

        public ComboBox cmbSubjectList {
            get { return comboBox1; }
            set { comboBox1 = value; }
        }

        public UserInfObject userInfo {
            get { return _userInfObject; }
            set { _userInfObject = value; }
        }

        public DataGridView listEvents {
            get { return eventList; }
            set { eventList = value; }
        }

        public DataTable dtEventList {
            get { return _dtEventList; }
            set { _dtEventList = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (eventList.Rows.Count == 300){ //puno na ang events
                MessageBox.Show("Maximum events reached.");
            }
            else
            {
                presenter.showAddEvent();
            }
            
            
            
        }

   

        private void button2_Click(object sender, EventArgs e)
        {
            presenter.loadStudyTime();
            numEvent.Text = eventList.Rows.Count.ToString() + "/300 Events"; //para ni sa number of events
        }

        private void eventList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow dr = this.dtEventList.Rows[e.RowIndex];
            ScheduleTime form = new ScheduleTime(this, dr);
            form.ShowDialog();
        }


    }
}
