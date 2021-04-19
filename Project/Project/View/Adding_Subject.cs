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
    public partial class Adding_Subject : Form,IAddSubject
    {

        int PW;
        bool Hided;
        UserInfObject _userInfObject;
        AddSubjectPresenter presenter;

        public Adding_Subject(UserInfObject _userInfObject)
        {
            InitializeComponent();
            PW = adding_panel.Height;
            Hided = false;
            //adding_panel.Visible = false;
            adding_panel.Visible = false;
            this._userInfObject = _userInfObject;
            presenter = new AddSubjectPresenter(this,_userInfObject);
        }

        public string subjectCode
        {
            get { return txtSubjectCode.Text; }
            set { txtSubjectCode.Text = value; }

        }
        public string subjectDescription
        {
            get { return txtSubjectDescription.Text; }
            set { txtSubjectDescription.Text = value; }
        }

        private void Adding_Subject_Load(object sender, EventArgs e)
        {
            subject_list_view.Items.Add("Add Subject",0);
        }

        private void subject_list_view_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subject_list_view.FocusedItem != null)
            {
                if (subject_list_view.FocusedItem.Index == 0)
                {
                    if (Hided) cancel_subjectAdd_btn.Text = "Cancel";
                    else cancel_subjectAdd_btn.Text = "Cancel";
                    timer1.Start();
                    adding_panel.Visible = true;
                }

            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            if (Hided) cancel_subjectAdd_btn.Text = "Cancel";
            else cancel_subjectAdd_btn.Text = "Cancel";
            timer1.Start();
        }

        private void add_subject_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (Hided)
            {
                adding_panel.Height = adding_panel.Height + 20;
                if (adding_panel.Height >= PW)
                {
                    timer1.Stop();
                    Hided = false;
                    this.Refresh();
                }
            }
            else
            {
                adding_panel.Height = adding_panel.Height - 20;
                if (adding_panel.Height <= 0)
                {
                    timer1.Stop();
                    Hided = true;
                    this.Refresh();
                }
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            presenter.AddSubject();
            if (Hided) cancel_subjectAdd_btn.Text = "Cancel";
            else cancel_subjectAdd_btn.Text = "Cancel";
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
