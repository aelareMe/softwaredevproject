using Project.Interface;
using Project.Model;
using Project.Object;
using Project.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.View
{
    public partial class Adding_Subject : Form,IAddSubject
    {
        public List<Subjects> Subject = new List<Subjects>();
        int PW;
        bool Hided;
        public string d;
        UserInfObject _userInfObject;
        AddSubjectPresenter presenter;
        int total_subject = 0;
        int _selectedIndex = 0;
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
        public Adding_Subject(int total_subject)
        {
       
        }
        private void Adding_Subject_Load(object sender, EventArgs e)
        {
            loadSubjects();
        }


        public void loadSubjects() {

            subject_list_view.Clear();
            subject_list_view.FocusedItem = null;
            subject_list_view.Items.Add("Add Subject", 0);
            add_subjectAdd_btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, add_subjectAdd_btn.Width, add_subjectAdd_btn.Height, 30, 30));
            cancel_subjectAdd_btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cancel_subjectAdd_btn.Width, cancel_subjectAdd_btn.Height, 30, 30));

            DataTable dt = presenter.loadSubjects();
            Subject.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                string name = dr["study_name"].ToString();
                string descr = dr["study_decription"].ToString();
                addToListStack(name, descr);
            }
        }
        public Adding_Subject(UserInfObject _userInfObject)
        {
            InitializeComponent();
            PW = adding_panel.Height;
            Hided = false;
            this._userInfObject = _userInfObject;
            add_subject_panel.Visible = false;
            view_subject_panel.Visible = true;
            edit_subject_panel.Visible = false;
            view_subject_details.Visible = false;
            back_btn.Visible = false;
            edit_btn.Visible = false;
            delete_btn.Visible = false;

            presenter = new AddSubjectPresenter(this, _userInfObject);

        }

        public string subjectCode
        {
            get { return SubjectCode_txt.Text; }
            set { SubjectCode_txt.Text = value; }

        }
        public string subjectDescription
        {
            get { return SubjectDescription_txt.Text; }
            set { SubjectDescription_txt.Text = value; }
        }

        public int selectedIndex   {
            get { return _selectedIndex; }
            set { _selectedIndex = value; }
        }

        private void subject_list_view_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subject_list_view.FocusedItem != null)
            {
                if (subject_list_view.FocusedItem.Index == 0)
                {
                    add_subject_panel.Visible = true;
                }
                else if(subject_list_view.FocusedItem.Index >=1)
                {
                    view_subject_details.Visible = true;
                    subject_list_view.Size = new Size(361, 296);
                    subjectCode_lbl.Text = Subject.ElementAt(subject_list_view.FocusedItem.Index - 1).Subject_Code;
                    view_subject_desription.Text = Subject.ElementAt(subject_list_view.FocusedItem.Index-1).Subject_Description;
                    edit_subject_panel.Visible = false;
                    back_btn.Visible = true;
                    edit_btn.Visible = true;
                    delete_btn.Visible = true;
                }
                subject_list_view.FocusedItem = null;
            }
        }
        private void add_subject_btn_Click(object sender, EventArgs e)
        {
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            if (add_Subject_limiter.MaxValue > Subject.Count)
            {
                if (SubjectCode_txt.Text == "")
                {
                    MessageBox.Show("Subject Code must have value!!");
                }
                else
                {
                    presenter.AddSubject();
                    loadSubjects();
                }
            }
            else 
            {
                MessageBox.Show("Subject is at limit");
            }
            add_subject_panel.Visible = false;
            view_subject_panel.Visible = true;
        }


        private void addToListStack(string code,string desrc) {

            subject_list_view.FocusedItem = null;
            subject_list_view.Items.Add(code, 1);
            Subject.Add(new Subjects { Subject_Code = code,
                Subject_Description = desrc
            });
            //Edit_Subject m = new Edit_Subject(Subject);
            SubjectCode_txt.Text = "";
            SubjectDescription_txt.Text = "";
            add_Subject_limiter.Value = Subject.Count();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cancel_btn_Click_1(object sender, EventArgs e) //add
        {
            subject_list_view.FocusedItem = null;
            add_subject_panel.Visible = false;
        }

        private void search_txtbox_TextChanged(object sender, EventArgs e)
        {
            subject_list_view.Items.Clear();
            subject_list_view.Items.Add("Add Subject", 0);
            char[] saerch_char = search_txtbox.Text.ToCharArray();
            for (int x = 0; x < Subject.Count; x++)
            {
                if (Subject.ElementAt(x).Subject_Code.ToLower().Contains(search_txtbox.Text.ToLower()))
                {
                    subject_list_view.Items.Add(Subject.ElementAt(x).Subject_Code,1);
                }
            }
        }
        private void Search_btn_Click(object sender, EventArgs e)
        {
            
        }

        // edit panel
        private void edit_btn_Click(object sender, EventArgs e)
        {
            edit_subject_panel.Visible = true;
            add_subject_panel.Visible = true;
            view_subject_details.Visible = false;
            edit_subject_code.Text = Subject.ElementAt(subject_list_view.FocusedItem.Index - 1).Subject_Code;
            edit_subject_description.Text = Subject.ElementAt(subject_list_view.FocusedItem.Index - 1).Subject_Description;
            edit_subject_code.Text = Subject.ElementAt(subject_list_view.FocusedItem.Index - 1).Subject_Code;
            edit_subject_description.Text = Subject.ElementAt(subject_list_view.FocusedItem.Index - 1).Subject_Description;
        }

        private void edit_cancel_btn_Click(object sender, EventArgs e)
        {
            edit_subject_panel.Visible = false;
            add_subject_panel.Visible = false;
        }
        public class Subjects
        {
            public string Subject_Code { get; set; }
            public string Subject_Description { get; set; }
        }
        private void edit_subject_edit_btn_Click(object sender, EventArgs e)
        {
            _selectedIndex = subject_list_view.FocusedItem.Index;
            subject_list_view.Items[subject_list_view.FocusedItem.Index].Text = edit_subject_code.Text;
            Subject.ElementAt(_selectedIndex - 1).Subject_Code = edit_subject_code.Text;
            Subject.ElementAt(_selectedIndex - 1).Subject_Description = edit_subject_description.Text;
            presenter.updateSubject();
            edit_subject_panel.Visible = false;
            add_subject_panel.Visible = false;
        }

        //view details
        private void add_activity_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello world");
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            view_subject_details.Visible = false;
            back_btn.Visible = false;
            subject_list_view.Size = new Size(711, 313);
            edit_btn.Visible = false;
            delete_btn.Visible = false;
        }
        private void delete_btn_Click(object sender, EventArgs e)
        {

            Subject.RemoveAt(subject_list_view.FocusedItem.Index - 1);
            subject_list_view.Items[subject_list_view.FocusedItem.Index].Remove();
            view_subject_details.Visible = false;
            back_btn.Visible = false;
            subject_list_view.Size = new Size(711, 313);
            edit_btn.Visible = false;
            delete_btn.Visible = false;

            _selectedIndex = subject_list_view.FocusedItem.Index;
            presenter.deleteSubject();
            
        }
    }
}
