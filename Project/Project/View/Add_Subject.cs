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
    public partial class Add_Subject : Form
    {
        private bool add_subject_btn = false;

        UserInfObject _userInfObject;
        public Add_Subject(UserInfObject _userInfObject)
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


        private void button1_Click_1(object sender, EventArgs e) // add_subject_btn
        {
            /*Adding_Subject open_add_subject = new Adding_Subject();
            open_add_subject.Show();*/
            Adding_Subject form = new Adding_Subject(_userInfObject);
            if (add_subject_btn == false)
            {
                openChildForm(form);
                add_subject_btn = true;
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
            main_panel.Controls.Add(childForm);
            main_panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
