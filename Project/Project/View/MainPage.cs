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

        DataTable _studyList = new DataTable();
        DataTable _studyProgress = new DataTable();
        UserInfObject _userInfObject;

        MainPagePresenter presenter;
        public MainPage(UserInfObject _userInfObject)
        {
            InitializeComponent();
            this.presenter = new MainPagePresenter(this);
            this._userInfObject = _userInfObject;

        }

        public DataTable studyList {
            get { return _studyList; }
            set { _studyList = value; } }
        public DataTable studyProgress {
            get { return _studyProgress; }
            set { _studyProgress = value; }
        }

        public UserInfObject userInfo
        {
            get { return _userInfObject; }
            set {

                _userInfObject = value;
                lblName.Text = _userInfObject.getName();

            }
        }

    
        private void button1_Click(object sender, EventArgs e)
        {

            presenter.showAddSubjects();
  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            presenter.showTaskScheduler();
        }
    }
}
