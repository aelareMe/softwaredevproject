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
    public partial class Setting : Form, ISettings
    {
        UserInfObject _userInfObject;

        bool isEditMode = false;

        private bool _resultExit = false;

        MainPage _mainPage;

        SettingsPresenter presenter;

        public Setting(UserInfObject _userInfObject, MainPage _mainPage)
        {
            InitializeComponent();

            name_txt.Text = _userInfObject.getName();
            this._userInfObject = _userInfObject;
            userName_txt.Text = _userInfObject.getUsername();
            Id_txt.Text =_userInfObject.getId().ToString();
            passwordHide();
            this._mainPage = _mainPage;

            presenter = new SettingsPresenter(this);
        }

        public void passwordHide() {
            int numPassword = _userInfObject.getPassword().Length;
            password_txt.Text = "";
            for (int x = 0; x < numPassword; x++)
            {
                password_txt.Text += "*";
            }
        }

        public int id {
            get {return Convert.ToInt32(Id_txt.Text); }
        }
        public string name {
            get { return name_txt.Text;  }
        }
        public string userName {
            get { return userName_txt.Text;  } }
        public string password {
            get { return password_txt.Text; }
        }

        public bool resultExit { get { return _resultExit; } }

        public MainPage mainPageForm { get { return _mainPage; } }

        private void changeProfile_btn_Click(object sender, EventArgs e)
        {
            // setting profile change button
            if (isEditMode) {

                presenter.updateProfile();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isEditMode = !isEditMode;
            changeView(isEditMode);
        }

        public void changeView(bool changed) {
            userName_txt.Enabled = changed;
            password_txt.Enabled = changed;
            name_txt.Enabled = changed;
            password_txt.Text = _userInfObject.getPassword();
            if (!changed) {
                passwordHide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            presenter.exit(this);
        }
    }
}
