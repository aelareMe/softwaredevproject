using Project.Interface;
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
        List<Subjects> Subject = new List<Subjects>();
        public int s;
        int PW;
        bool Hided;
        UserInfObject _userInfObject;
        AddSubjectPresenter presenter;

        int ctrTraverse = 2;
        
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
        private void Adding_Subject_Load(object sender, EventArgs e)
        {
            adding_panel.Visible = false;
            subject_list_view.FocusedItem = null;
            subject_list_view.Items.Add("Add Subject", 0);
            add_subjectAdd_btn.Region = Region.FromHrgn(CreateRoundRectRgn(0,0, add_subjectAdd_btn.Width, add_subjectAdd_btn.Height, 30, 30));
            cancel_subjectAdd_btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cancel_subjectAdd_btn.Width, cancel_subjectAdd_btn.Height, 30, 30));
            close_application_btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, 32, 32, 50, 50));
            maximize_application_btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, maximize_application_btn.Height, maximize_application_btn.Height, 50, 50));
            minimize_application_btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, minimize_application_btn.Height, minimize_application_btn.Height, 50, 50));
            Add_List_of_Subject_btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Add_List_of_Subject_btn.Width, Add_List_of_Subject_btn.Height, 30, 30));
            Cancel_Add_Subject_btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Cancel_Add_Subject_btn.Width, Cancel_Add_Subject_btn.Height, 30, 30));
        }

        public Adding_Subject(UserInfObject _userInfObject)
        {
            InitializeComponent();
            PW = adding_panel.Height;
            Hided = false;
            //adding_panel.Visible = false;
            adding_panel.Visible = false;
            this._userInfObject = _userInfObject;
            presenter = new AddSubjectPresenter(this,_userInfObject);
            edit_panel.Hide();


            if (_userInfObject != null)
            {
                DataTable dt = presenter.loadSubjects();
     
                foreach (DataRow dr in dt.Rows)
                {
                  //bug
                    string subjectCode = dr["study_name"].ToString();
                    string description = dr["study_decription"].ToString();
                    subject_list_view.Items.Add(subjectCode, 1);
                    Subject.Add(new Subjects
                    {
                        Subject_Code = subjectCode,
                        Subject_Description = description
                    });
                    SubjectCode_txt.Text = "";
                    SubjectDescription_txt.Text = "";
                    adding_panel.Visible = false;
  
                }
            }

        }
        public List<Subjects> Subject_Adding_Subject
        {
            get { return Subject;}
            set { Subject = value; }
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

        public ListView subjectList {
            get { return subject_list_view; }
            set { subject_list_view = value; }
        }

        private void subject_list_view_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subject_list_view.FocusedItem != null)
            {
                if (subject_list_view.FocusedItem.Index == 0)
                {
                    adding_panel.Visible = true;
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
                    subject_list_view.FocusedItem = null;
                    presenter.AddSubject();
                    DataTable dt = presenter.loadSubjects();
                 
                    foreach (DataRow dr in dt.Rows)
                    {
                        //bug
                        string subjectCode = dr["study_name"].ToString();
                        string description = dr["study_decription"].ToString();
                        subject_list_view.Items.Add(subjectCode, 1);
                        Subject.Add(new Subjects
                        {
                            Subject_Code = subjectCode,
                            Subject_Description = description
                        });
                        SubjectCode_txt.Text = "";
                        SubjectDescription_txt.Text = "";
                        adding_panel.Visible = false;
                    }

                }
                add_Subject_limiter.Value = Subject.Count();

            }
            else 
            {
                MessageBox.Show("Subject is at limit");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cancel_btn_Click_1(object sender, EventArgs e)
        {
            subject_list_view.FocusedItem = null;
            adding_panel.Visible = false;
        }

        private void search_txtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (search_txtbox.Text != "")
                {
                    subject_list_view.Items.Clear();
                    subject_list_view.Items.Add("Add Subject", 0);
                    char[] search_text = search_txtbox.Text.ToCharArray();
                    char[,] text = new char[Subject.Count, search_text.Length];
                    for (int x = 0; x < Subject.Count; x++)
                    {
                        char[] text_temporary = Subject.ElementAt(x).Subject_Code.ToString().ToCharArray();
                        int d = 0;
                        for (int y = 0; y < search_text.Length; y++)
                        {
                            text[x, y] = text_temporary[y];
                        }

                    }
                    for (int x = 0; x < Subject.Count; x++)
                    {
                        for (int y = 0; y < search_text.Length; y++)
                        {
                            if (text[x, y] == search_text[y])
                            {
                                subject_list_view.Items.Add(Subject.ElementAt(x).Subject_Code.ToString(), 1);
                            }
                        }
                    }
                }
                else
                {
                    subject_list_view.Items.Clear();
                    subject_list_view.Items.Add("Add Subject", 0);
                    for (int x = 0; x < Subject.Count; x++)
                    {
                        subject_list_view.Items.Add(Subject.ElementAt(x).Subject_Code.ToString(), 1);
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }
        private void Search_btn_Click(object sender, EventArgs e)
        {
            
        }

        public class Subjects
        {
            public string Subject_Code { get; set;}
            public string Subject_Description { get; set;}
        }

        private int  subject_that_be_edited;
        private void edit_list_view_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (edit_list_view.FocusedItem != null)
            {
                edit_panel_subject.Visible = true;
                edit_SubjectCode_txt.Text = Subject.ElementAt(edit_list_view.FocusedItem.Index).Subject_Code;
                edit_description_txt.Text = Subject.ElementAt(edit_list_view.FocusedItem.Index).Subject_Description;
                subject_that_be_edited = edit_list_view.FocusedItem.Index;
            }
        }

        private void cancel_edit_btn_Click(object sender, EventArgs e)
        {
            edit_panel_subject.Hide();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if(subject_that_be_edited != null)
            {
                Subject.ElementAt(subject_that_be_edited).Subject_Code = edit_SubjectCode_txt.Text;
                Subject.ElementAt(subject_that_be_edited).Subject_Description = edit_description_txt.Text;
                edit_list_view.Items[subject_that_be_edited].Text = Subject.ElementAt(subject_that_be_edited).Subject_Code;
                edit_panel_subject.Visible = false;
            }
        }

        private void edit_list_view_VisibleChanged(object sender, EventArgs e)
        {
            edit_Subject_limiter.Value = add_Subject_limiter.Value;
        }

        private void edit_search_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (edit_search_txt.Text != "")
                {
                    edit_list_view.Items.Clear();
                    char[] search_text = edit_search_txt.Text.ToCharArray();
                    char[,] text = new char[Subject.Count, search_text.Length];
                    for (int x = 0; x < Subject.Count; x++)
                    {
                        char[] text_temporary = Subject.ElementAt(x).Subject_Code.ToString().ToCharArray();
                        int d = 0;
                        for (int y = 0; y < search_text.Length; y++)
                        {
                            text[x, y] = text_temporary[y];
                        }

                    }
                    for (int x = 0; x < Subject.Count; x++)
                    {
                        for (int y = 0; y < search_text.Length; y++)
                        {
                            if (text[x, y] == search_text[y])
                            {
                                edit_list_view.Items.Add(Subject.ElementAt(x).Subject_Code.ToString(), 1);
                            }
                        }
                    }
                }
                else
                {
                    edit_list_view.Items.Clear();
                    for (int x = 0; x < Subject.Count; x++)
                    {
                        edit_list_view.Items.Add(Subject.ElementAt(x).Subject_Code.ToString(), 1);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void temp_add_subject_btn_Click(object sender, EventArgs e)
        {
            add_subject_panel.Visible = true;
            edit_panel.Visible = false;
        }

        private void temp_edit_subject_btn_Click(object sender, EventArgs e)
        {
            edit_panel.Visible = true;
            edit_panel_subject.Visible = false;
            s = Subject.Count();
            for (int x = 0; x < Subject.Count; x++)
            {
                edit_list_view.Items.Add(Subject.ElementAt(x).Subject_Code, 1);
            }
        }

     
    }
}
