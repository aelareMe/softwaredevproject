using Project.Interface;
using Project.Model;
using Project.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.View
{
    public partial class Subject_Oversight : Form
    {

        private bool add_subject_btn = false;
        //private bool button2 = false;
        UserInfObject _userInfObject;
        int total_subject;
        Adding_Subject Adding_Subject;
        public Subject_Oversight(int value)
        {
            InitializeComponent();
            this.total_subject = value;
            this.Adding_Subject = new Adding_Subject(value);
            
        }
        public Subject_Oversight(UserInfObject _userInfObject)
        {
            InitializeComponent();
            this._userInfObject = _userInfObject;
            
        }
        private void celearningTextbox1_Click(object sender, EventArgs e)
        {

        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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
            main_panel.Controls.Add(childForm);
            main_panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e) // edit_subject_btn
        {
            Adding_Subject Adding_Subject = new Adding_Subject(_userInfObject);
            if (add_subject_btn == false)
            {
                openChildForm(Adding_Subject);
                add_subject_btn = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
        public void close_window()
        {
        }
        private void Add_Subject_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        bool size_return = true;
        private void maximize_btn_Click(object sender, EventArgs e)
        {
            //Control.DoMaximize(this);
        }
    }
}
