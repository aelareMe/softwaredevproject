using Project.Interface;
using Project.Model;
using Project.Object;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.View
{
    public partial class Subject_Oversight : Form
    {

        UserInfObject _userInfObject;
        int total_subject;
        Adding_Subject Adding_Subject;
        Panel main_panel1;

        public Subject_Oversight()
        {

        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nleft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidthEllipse,
                int nHeightEllipse
            );
        private void Add_Subject_Load(object sender, EventArgs e)
        {
            close_btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, close_btn.Width, close_btn.Height, 30, 30));
            //maximize_btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, maximize_btn.Width, maximize_btn.Height, 30, 30));
            minimize_btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, minimize_btn.Width, minimize_btn.Height, 30, 30));
        }
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
            MainPage MainPage = new MainPage(_userInfObject);
            openChildForm(MainPage);
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
            openChildForm(Adding_Subject);
            edit_subject_btn.BackColor = Color.FromArgb(15, 39, 63);
            Schedule_btn.BackColor = Color.FromArgb(11, 17, 31);
            addAcitivty_btn.BackColor = Color.FromArgb(11, 17, 31);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            edit_subject_btn.BackColor = Color.FromArgb(11, 17, 31);
            Schedule_btn.BackColor = Color.FromArgb(15, 39, 63);
            addAcitivty_btn.BackColor = Color.FromArgb(11, 17, 31);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainPage MainPage = new MainPage(_userInfObject);
            openChildForm(MainPage);
        }

        private void addAcitivty_btn_Click(object sender, EventArgs e)
        {
            ActSched ActSched = new ActSched(_userInfObject);
            openChildForm(ActSched);
            edit_subject_btn.BackColor = Color.FromArgb(11, 17, 31);
            Schedule_btn.BackColor = Color.FromArgb(11, 17, 31);
            addAcitivty_btn.BackColor = Color.FromArgb(15, 39, 63);
        }
    }
}
